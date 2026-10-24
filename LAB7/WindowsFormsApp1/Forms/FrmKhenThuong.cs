using System;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmKhenThuong : Form
    {
        private readonly DanhMucReadService danhMuc = new DanhMucReadService(); private readonly KhenThuongService service = new KhenThuongService(); private int? selectedId;
        public FrmKhenThuong() { InitializeComponent(); Load += FrmKhenThuong_Load; }
        private void FrmKhenThuong_Load(object sender, EventArgs e) { try { var nv = danhMuc.LayNhanVien(); cboNhanVien.DataSource = nv; cboNhanVien.DisplayMember = "HoTen"; cboNhanVien.ValueMember = "MaNV"; var pb = danhMuc.LayPhongBan(); cboPhongBan.DataSource = pb; cboPhongBan.DisplayMember = "TenPhongBan"; cboPhongBan.ValueMember = "MaPhongBan"; dgvDanhSach.DataSource = service.LayDanhSach(); dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ToggleTarget(); } catch (Exception ex) { MessageBox.Show("Không thể tải dữ liệu SQL: " + ex.Message, "Kết nối dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }
        private string TargetValue() { var item = cboLoaiDoiTuong.SelectedItem as TargetType; return item == null ? "" : item.Value; }
        private void ToggleTarget() { bool person = TargetValue() == "CaNhan"; cboNhanVien.Enabled = person; cboPhongBan.Enabled = !person; }
        private void cboLoaiDoiTuong_SelectedIndexChanged(object sender, EventArgs e) { ToggleTarget(); }
        private void btnLap_Click(object sender, EventArgs e) { int? nv = TargetValue() == "CaNhan" ? (int?)Convert.ToInt32(cboNhanVien.SelectedValue) : null; int? pb = nv.HasValue ? null : (int?)Convert.ToInt32(cboPhongBan.SelectedValue); var result = service.LapQuyetDinh(nv, pb, dtpNgayQuyetDinh.Value, txtNoiDung.Text, numSoTienThuong.Value); MessageBox.Show(result.ThongBao, result.ThanhCong ? "Thông báo" : "Kiểm tra nghiệp vụ", MessageBoxButtons.OK, result.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning); if (result.ThanhCong) RefreshGrid(); }
        private void btnKy_Click(object sender, EventArgs e) { if (!selectedId.HasValue) { MessageBox.Show("Chọn quyết định cần ký."); return; } var result = service.XacNhanKy(selectedId.Value); MessageBox.Show(result.ThongBao); if (result.ThanhCong) RefreshGrid(); }
        private void btnPhieuChi_Click(object sender, EventArgs e) { if (!selectedId.HasValue) { MessageBox.Show("Chọn quyết định cần chi."); return; } var result = service.LapPhieuChi(selectedId.Value, dtpNgayChi.Value, numSoTienChi.Value); MessageBox.Show(result.ThongBao, result.ThanhCong ? "Thông báo" : "Kiểm tra nghiệp vụ", MessageBoxButtons.OK, result.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning); if (result.ThanhCong) RefreshGrid(); }
        private void RefreshGrid() { dgvDanhSach.DataSource = service.LayDanhSach(); dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; }
        private void btnLamMoi_Click(object sender, EventArgs e) { selectedId = null; txtSoQuyetDinh.Clear(); txtNoiDung.Clear(); numSoTienThuong.Value = 0; numSoTienChi.Value = 0; RefreshGrid(); }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e) { if (e.RowIndex < 0 || dgvDanhSach.Rows[e.RowIndex].Cells["SoQDKT"].Value == null) return; selectedId = Convert.ToInt32(dgvDanhSach.Rows[e.RowIndex].Cells["SoQDKT"].Value); txtSoQuyetDinh.Text = selectedId.ToString(); }
    }
}
