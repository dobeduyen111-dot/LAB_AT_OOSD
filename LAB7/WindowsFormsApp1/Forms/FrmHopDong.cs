using System;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmHopDong : Form
    {
        private readonly DanhMucReadService danhMuc = new DanhMucReadService(); private readonly HopDongService hopDong = new HopDongService(); private readonly BaoHiemService baoHiem = new BaoHiemService();
        public FrmHopDong() { InitializeComponent(); Load += FrmHopDong_Load; }
        private void FrmHopDong_Load(object sender, EventArgs e) { LoadData(); }
        private void LoadData()
        {
            try { var nv = danhMuc.LayNhanVien(); cboNhanVien.DataSource = nv; cboNhanVien.DisplayMember = "HoTen"; cboNhanVien.ValueMember = "MaNV"; dgvDanhSach.DataSource = hopDong.LayDanhSach(); dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ToggleInsurance(); }
            catch (Exception ex) { MessageBox.Show("Không thể tải dữ liệu SQL: " + ex.Message, "Kết nối dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void cboLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e) { ToggleInsurance(); }
        private string ContractValue() { var item = cboLoaiHopDong.SelectedItem as ContractType; return item == null ? "" : item.Value; }
        private void ToggleInsurance() { grpBaoHiem.Enabled = ContractValue() == "DaiHan"; }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime? end = chkCoThoiHan.Checked ? (DateTime?)dtpNgayKetThuc.Value.Date : null;
            var loai = ContractValue(); var result = hopDong.Luu(Convert.ToInt32(cboNhanVien.SelectedValue), loai, dtpNgayKy.Value, dtpNgayBatDau.Value, end, txtNoiDung.Text);
            if (result.ThanhCong && loai == "DaiHan" && (txtBHYT.Text.Trim().Length > 0 || txtBHXH.Text.Trim().Length > 0)) result = baoHiem.LuuHoSo(Convert.ToInt32(cboNhanVien.SelectedValue), txtBHYT.Text, txtBHXH.Text, numBHYT.Value, numBHXH.Value);
            MessageBox.Show(result.ThongBao, result.ThanhCong ? "Thông báo" : "Kiểm tra nghiệp vụ", MessageBoxButtons.OK, result.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning); if (result.ThanhCong) { dgvDanhSach.DataSource = hopDong.LayDanhSach(); ClearInput(); }
        }
        private void btnCapNhat_Click(object sender, EventArgs e) { MessageBox.Show("Phiên bản theo báo cáo chỉ cập nhật hồ sơ bảo hiểm bằng nút lưu; cập nhật hợp đồng cần bổ sung khóa SoHopDong."); }
        private void btnLamMoi_Click(object sender, EventArgs e) { ClearInput(); }
        private void ClearInput() { dtpNgayKy.Value = DateTime.Today; dtpNgayBatDau.Value = DateTime.Today; dtpNgayKetThuc.Value = DateTime.Today.AddYears(1); chkCoThoiHan.Checked = false; txtNoiDung.Clear(); txtBHYT.Clear(); txtBHXH.Clear(); numBHYT.Value = 0; numBHXH.Value = 0; }
    }
}
