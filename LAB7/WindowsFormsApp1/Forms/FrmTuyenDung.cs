using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmTuyenDung : Form
    {
        private readonly DanhMucReadService danhMuc = new DanhMucReadService();
        private readonly TuyenDungService service = new TuyenDungService();
        private int? selectedId;
        public FrmTuyenDung() { InitializeComponent(); Load += FrmTuyenDung_Load; }
        private void FrmTuyenDung_Load(object sender, EventArgs e) { LoadData(); }
        private void LoadData()
        {
            try
            {
                var nv = danhMuc.LayNhanVien(); cboNhanVien.DataSource = nv; cboNhanVien.DisplayMember = "HoTen"; cboNhanVien.ValueMember = "MaNV";
                var pb = danhMuc.LayPhongBan(); cboPhongBan.DataSource = pb; cboPhongBan.DisplayMember = "TenPhongBan"; cboPhongBan.ValueMember = "MaPhongBan";
                dgvDanhSach.DataSource = service.LayDanhSach(); dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ClearInput();
            }
            catch (Exception ex) { MessageBox.Show("Không thể tải dữ liệu SQL: " + ex.Message, "Kết nối dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void ClearInput() { selectedId = null; txtSoQuyetDinh.Clear(); dtpNgayKy.Value = DateTime.Today; dtpBatDau.Value = DateTime.Today; dtpKetThuc.Value = DateTime.Today.AddMonths(2); numLuongThuViec.Value = 0; txtDieuKhoan.Clear(); }
        private void btnLap_Click(object sender, EventArgs e) { Save(null); }
        private void btnCapNhat_Click(object sender, EventArgs e) { if (!selectedId.HasValue) { MessageBox.Show("Chọn một quyết định trong danh sách trước."); return; } Save(selectedId); }
        private void Save(int? id)
        {
            var result = service.Luu(id, Convert.ToInt32(cboNhanVien.SelectedValue), Convert.ToInt32(cboPhongBan.SelectedValue), dtpNgayKy.Value, dtpBatDau.Value, dtpKetThuc.Value, numLuongThuViec.Value, txtDieuKhoan.Text);
            MessageBox.Show(result.ThongBao, result.ThanhCong ? "Thông báo" : "Kiểm tra nghiệp vụ", MessageBoxButtons.OK, result.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning); if (result.ThanhCong) LoadData();
        }
        private void btnLamMoi_Click(object sender, EventArgs e) { ClearInput(); }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvDanhSach.Rows[e.RowIndex].Cells["SoQDTD"].Value == null) return; var r = dgvDanhSach.Rows[e.RowIndex]; selectedId = Convert.ToInt32(r.Cells["SoQDTD"].Value); txtSoQuyetDinh.Text = selectedId.ToString(); cboNhanVien.SelectedValue = r.Cells["MaNV"].Value; cboPhongBan.SelectedValue = r.Cells["MaPhongBan"].Value; dtpNgayKy.Value = Convert.ToDateTime(r.Cells["NgayKy"].Value); dtpBatDau.Value = Convert.ToDateTime(r.Cells["BatDauThuViec"].Value); dtpKetThuc.Value = Convert.ToDateTime(r.Cells["KetThucThuViec"].Value); numLuongThuViec.Value = Convert.ToDecimal(r.Cells["LuongThuViec"].Value); txtDieuKhoan.Text = Convert.ToString(r.Cells["DieuKhoan"].Value);
        }
    }
}
