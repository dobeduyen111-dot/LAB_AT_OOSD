using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using QuanLyVanPhong.Services;

namespace QuanLyVanPhong.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService service = new DanhMucService();
        private int? maVP, maKH;
        private DataTable bangVP, bangKH;
        public FrmDanhMuc() { InitializeComponent(); }
        private void FrmDanhMuc_Load(object sender, EventArgs e) { NapDuLieu(); }
        private void NapDuLieu()
        {
            try
            {
                bangVP = service.LayVanPhong();
                bangKH = service.LayKhachThue();
                dgvVanPhong.DataSource = bangVP;
                dgvKhachThue.DataSource = bangKH;
                dgvVanPhong.ClearSelection();
                dgvKhachThue.ClearSelection();
            }
            catch (Exception ex) { BaoLoi(ex); }
        }
        private static void BaoLoi(Exception ex)
        {
            MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private static void HienThi(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao,k.ThanhCong?"Thành công":"Không thể thực hiện",
                MessageBoxButtons.OK,k.ThanhCong?MessageBoxIcon.Information:MessageBoxIcon.Warning);
        }
        private void XoaTrangVP()
        {
            maVP=null; txtMaVP.Clear(); txtSoPhong.Clear(); txtHuong.Clear();
            nudTang.Value=0; nudDienTich.Value=1; nudGia.Value=1; dgvVanPhong.ClearSelection();
        }
        private void XoaTrangKH()
        {
            maKH=null; txtMaKH.Clear(); txtTenDonVi.Clear(); txtNguoiDaiDien.Clear();
            txtDiaChi.Clear(); txtDienThoai.Clear(); dgvKhachThue.ClearSelection();
        }
        private void btnLuuVP_Click(object sender,EventArgs e)
        {
            var k=service.LuuVanPhong(maVP,(int)nudTang.Value,txtSoPhong.Text,txtHuong.Text,
                nudDienTich.Value,nudGia.Value);
            HienThi(k);
            if(k.ThanhCong) { NapDuLieu(); XoaTrangVP(); }
        }
        private void btnXoaVP_Click(object sender,EventArgs e)
        {
            if(!maVP.HasValue) { MessageBox.Show("Chọn văn phòng trước khi xóa.");return; }
            if(MessageBox.Show("Xóa văn phòng đã chọn?","Xác nhận",MessageBoxButtons.YesNo)!=DialogResult.Yes)return;
            var k=service.XoaVanPhong(maVP.Value);HienThi(k);
            if(k.ThanhCong){NapDuLieu();XoaTrangVP();}
        }
        private void btnMoiVP_Click(object sender,EventArgs e){XoaTrangVP();}
        private void dgvVanPhong_SelectionChanged(object sender,EventArgs e)
        {
            if(dgvVanPhong.CurrentRow==null || !dgvVanPhong.CurrentRow.Selected || dgvVanPhong.CurrentRow.DataBoundItem==null)return;
            var row=dgvVanPhong.CurrentRow.DataBoundItem as DataRowView;
            if(row==null)return;
            maVP=Convert.ToInt32(row["MaVP"]);txtMaVP.Text=maVP.ToString();
            nudTang.Value=Convert.ToDecimal(row["Tang"]);txtSoPhong.Text=Convert.ToString(row["SoPhong"]);
            txtHuong.Text=Convert.ToString(row["Huong"]);nudDienTich.Value=Convert.ToDecimal(row["DienTich"]);
            nudGia.Value=Convert.ToDecimal(row["DonGiaNiemYet"]);
        }
        private void btnTimVP_Click(object sender,EventArgs e)
        {
            if(bangVP==null)return;
            var val=txtTimVP.Text.Trim().Replace("'","''").Replace("[","[[]").Replace("%","[%]");
            bangVP.DefaultView.RowFilter="SoPhong LIKE '%"+val+"%'";
        }
        private void btnLuuKH_Click(object sender,EventArgs e)
        {
            var k=service.LuuKhachThue(maKH,txtTenDonVi.Text,txtNguoiDaiDien.Text,txtDiaChi.Text,txtDienThoai.Text);
            HienThi(k);if(k.ThanhCong){NapDuLieu();XoaTrangKH();}
        }
        private void btnXoaKH_Click(object sender,EventArgs e)
        {
            if(!maKH.HasValue){MessageBox.Show("Chọn khách thuê trước khi xóa.");return;}
            if(MessageBox.Show("Xóa khách thuê đã chọn?","Xác nhận",MessageBoxButtons.YesNo)!=DialogResult.Yes)return;
            var k=service.XoaKhachThue(maKH.Value);HienThi(k);
            if(k.ThanhCong){NapDuLieu();XoaTrangKH();}
        }
        private void btnMoiKH_Click(object sender,EventArgs e){XoaTrangKH();}
        private void dgvKhachThue_SelectionChanged(object sender,EventArgs e)
        {
            if(dgvKhachThue.CurrentRow==null || !dgvKhachThue.CurrentRow.Selected || dgvKhachThue.CurrentRow.DataBoundItem==null)return;
            var row=dgvKhachThue.CurrentRow.DataBoundItem as DataRowView;if(row==null)return;
            maKH=Convert.ToInt32(row["MaKH"]);txtMaKH.Text=maKH.ToString();
            txtTenDonVi.Text=Convert.ToString(row["TenDonVi"]);txtNguoiDaiDien.Text=Convert.ToString(row["NguoiDaiDien"]);
            txtDiaChi.Text=Convert.ToString(row["DiaChi"]);txtDienThoai.Text=Convert.ToString(row["DienThoai"]);
        }
        private void btnTimKH_Click(object sender,EventArgs e)
        {
            if(bangKH==null)return;
            var val=txtTimKH.Text.Trim().Replace("'","''").Replace("[","[[]").Replace("%","[%]");
            bangKH.DefaultView.RowFilter="TenDonVi LIKE '%"+val+"%'";
        }
    }
}
