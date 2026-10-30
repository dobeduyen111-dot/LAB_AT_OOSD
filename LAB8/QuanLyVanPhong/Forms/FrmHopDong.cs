using QuanLyVanPhong.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using QuanLyVanPhong.Services;

namespace QuanLyVanPhong.Forms
{
    public partial class FrmHopDong : Form
    {
        private readonly HopDongService service=new HopDongService();
        private readonly BindingList<PhongThueChon> phongDaChon=new BindingList<PhongThueChon>();
        private int? maHopDongDaLuu;
        public FrmHopDong(){InitializeComponent();}
        private void FrmHopDong_Load(object sender,EventArgs e)
        {
            dgvPhongChon.DataSource=phongDaChon;
            NapKhach();NapPhongTrong();NapHopDong();LamMoi();
        }
        private void NapKhach()
        {
            try
            {
                DataTable dt=service.LayKhachThue();
                cboKhach.DataSource=dt;cboKhach.DisplayMember="TenDonVi";cboKhach.ValueMember="MaKH";
                if(dt.Rows.Count>0)cboKhach.SelectedIndex=0;
            }
            catch(Exception ex){BaoLoi(ex);}
        }
        private void NapPhongTrong()
        {
            try
            {
                var dt=service.LayPhongTrong(dtpNgayBatDau.Value,(int)nudSoThang.Value);
                cboPhong.DataSource=dt;cboPhong.DisplayMember="TenPhong";cboPhong.ValueMember="MaVP";
                if(dt.Rows.Count>0)cboPhong.SelectedIndex=0;
                btnThemPhong.Enabled=dt.Rows.Count>0;
            }
            catch(Exception ex){BaoLoi(ex);}
        }
        private void NapHopDong()
        {
            try{dgvHopDong.DataSource=service.LayHopDong();dgvHopDong.ClearSelection();}
            catch(Exception ex){BaoLoi(ex);}
        }
        private static void BaoLoi(Exception ex)
        {
            MessageBox.Show(ex.Message,"Lỗi truy cập SQL Server",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void LamMoi()
        {
            maHopDongDaLuu=null;
            txtMaHD.Clear();txtSoHD.Text="HD-"+DateTime.Now.ToString("yyyyMMdd-HHmmss");
            txtNoiDung.Clear();dtpNgayKy.Value=DateTime.Today;
            dtpNgayBatDau.Value=DateTime.Today.AddDays(1);
            dtpNgayThu.Value=DateTime.Today;
            nudSoThang.Value=6;phongDaChon.Clear();
            btnLapHopDong.Enabled=true;btnCapNhatNoiDung.Enabled=false;btnThu6.Enabled=false;
            NapPhongTrong();TinhTien();
        }
        private void TinhTien()
        {
            decimal tong=phongDaChon.Sum(x=>x.DonGiaThang);
            lblTongThang.Text=tong.ToString("N0")+" đ";
            lblTraTruoc.Text=(tong*6).ToString("N0")+" đ";
        }
        private void btnThemPhong_Click(object sender,EventArgs e)
        {
            if(maHopDongDaLuu.HasValue){MessageBox.Show("Hợp đồng đã lưu. Bấm Làm mới để lập hợp đồng khác.");return;}
            var row=cboPhong.SelectedItem as DataRowView;
            if(row==null){MessageBox.Show("Không có văn phòng trống cho kỳ thuê đang chọn.");return;}
            int ma=Convert.ToInt32(row["MaVP"]);
            if(phongDaChon.Any(x=>x.MaVP==ma)){MessageBox.Show("Phòng này đã được chọn.");return;}
            decimal gia=Convert.ToDecimal(row["DonGiaNiemYet"]);
            phongDaChon.Add(new PhongThueChon{
                MaVP=ma,Tang=Convert.ToInt32(row["Tang"]),
                SoPhong=Convert.ToString(row["SoPhong"]),DonGiaThang=gia});
            TinhTien();
        }
        private void btnBoPhong_Click(object sender,EventArgs e)
        {
            if(maHopDongDaLuu.HasValue)return;
            var row=dgvPhongChon.CurrentRow;
            if(row!=null && row.DataBoundItem is PhongThueChon)
            {phongDaChon.Remove((PhongThueChon)row.DataBoundItem);TinhTien();}
        }
        private void btnLamMoi_Click(object sender,EventArgs e){LamMoi();}
        private void btnTaiPhong_Click(object sender,EventArgs e){if(!maHopDongDaLuu.HasValue)NapPhongTrong();}
        private void dtpNgayBatDau_ValueChanged(object sender,EventArgs e)
        {if(!maHopDongDaLuu.HasValue && cboPhong!=null)NapPhongTrong();}
        private void nudSoThang_ValueChanged(object sender,EventArgs e)
        {if(!maHopDongDaLuu.HasValue && cboPhong!=null)NapPhongTrong();}
        private void btnLapHopDong_Click(object sender,EventArgs e)
        {
            try
            {
                if(cboKhach.SelectedValue==null || !(cboKhach.SelectedValue is int))
                {MessageBox.Show("Chưa có khách thuê. Hãy thêm trong Danh mục.");return;}
                int id=service.LapHopDong(txtSoHD.Text,(int)cboKhach.SelectedValue,
                    dtpNgayKy.Value,dtpNgayBatDau.Value,(int)nudSoThang.Value,
                    phongDaChon.ToList(),txtNoiDung.Text);
                maHopDongDaLuu=id;txtMaHD.Text=id.ToString();
                btnLapHopDong.Enabled=false;btnCapNhatNoiDung.Enabled=true;btnThu6.Enabled=true;
                NapHopDong();
                MessageBox.Show("Đã lưu hợp đồng #"+id+" và sinh các kỳ tiền thuê. Chưa thu trước 6 tháng.",
                    "Lập hợp đồng",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex){BaoLoi(ex);}
        }
        private void btnCapNhatNoiDung_Click(object sender,EventArgs e)
        {
            if(!maHopDongDaLuu.HasValue)return;
            try
            {
                var result=service.CapNhatNoiDung(maHopDongDaLuu.Value,txtNoiDung.Text);
                MessageBox.Show(result.ThongBao);if(result.ThanhCong)NapHopDong();
            }
            catch(Exception ex){BaoLoi(ex);}
        }
        private void btnThu6_Click(object sender,EventArgs e)
        {
            if(!maHopDongDaLuu.HasValue)return;
            if(MessageBox.Show("Xác nhận thu đủ tiền thuê sáu tháng đầu của TẤT CẢ văn phòng trong hợp đồng?",
                "Xác nhận thu tiền",MessageBoxButtons.YesNo,MessageBoxIcon.Question)!=DialogResult.Yes)return;
            try
            {
                service.ThuTruoc6Thang(maHopDongDaLuu.Value,dtpNgayThu.Value,txtChungTu.Text);
                MessageBox.Show("Đã ghi nhận thu đủ 6 tháng và kích hoạt hợp đồng.");
                btnThu6.Enabled=false;btnCapNhatNoiDung.Enabled=false;NapHopDong();
            }
            catch(Exception ex){BaoLoi(ex);}
        }
        private void dgvHopDong_SelectionChanged(object sender,EventArgs e)
        {
            var row=dgvHopDong.CurrentRow==null || !dgvHopDong.CurrentRow.Selected?null:dgvHopDong.CurrentRow.DataBoundItem as DataRowView;
            if(row==null)return;
            try
            {
                maHopDongDaLuu=Convert.ToInt32(row["MaHD"]);
                txtMaHD.Text=maHopDongDaLuu.Value.ToString();txtSoHD.Text=Convert.ToString(row["SoHD"]);
                txtNoiDung.Text=Convert.ToString(row["NoiDung"]);
                if(cboKhach.DataSource!=null)cboKhach.SelectedValue=Convert.ToInt32(row["MaKH"]);
                dtpNgayKy.Value=Convert.ToDateTime(row["NgayKy"]);
                dtpNgayBatDau.Value=Convert.ToDateTime(row["NgayBatDau"]);
                nudSoThang.Value=Convert.ToDecimal(row["SoThang"]);
                phongDaChon.Clear();
                var details=service.LayChiTiet(maHopDongDaLuu.Value);
                foreach(DataRow p in details.Rows)
                    phongDaChon.Add(new PhongThueChon{
                        MaVP=Convert.ToInt32(p["MaVP"]),Tang=Convert.ToInt32(p["Tang"]),
                        SoPhong=Convert.ToString(p["SoPhong"]),DonGiaThang=Convert.ToDecimal(p["DonGiaThang"])});
                btnLapHopDong.Enabled=false;
                string status=Convert.ToString(row["TrangThai"]);
                btnThu6.Enabled=status=="ChoThanhToan";
                btnCapNhatNoiDung.Enabled=status=="ChoThanhToan";
                TinhTien();
            }
            catch(Exception ex){BaoLoi(ex);}
        }
    }
}
