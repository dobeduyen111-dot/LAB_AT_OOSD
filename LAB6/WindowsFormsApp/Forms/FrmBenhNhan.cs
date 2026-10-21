using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;
namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmBenhNhan : Form
    {
        private readonly BenhNhanService service = new BenhNhanService();
        public FrmBenhNhan() { InitializeComponent(); }
        private void NavBenhNhan_Click(object s, EventArgs e) { }
        private void NavKhamBenh_Click(object s, EventArgs e) { using (var f = new FrmKhamBenh()) f.ShowDialog(this); }
        private void NavLapToa_Click(object s, EventArgs e) { using (var f = new FrmLapToaThuoc()) f.ShowDialog(this); }
        private void btnChonAnh_Click(object s, EventArgs e) { using (var d = new OpenFileDialog { Filter = "Ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" }) if (d.ShowDialog(this) == DialogResult.OK) picAnh.Image = Image.FromFile(d.FileName); }
        private void btnDangKy_Click(object s, EventArgs e) { var r=service.DangKyBenhNhan(); MessageBox.Show(r.ThongBao, "Thông báo", MessageBoxButtons.OK, r.ThanhCong?MessageBoxIcon.Information:MessageBoxIcon.Error); }
        private void btnGhiPhi_Click(object s, EventArgs e) { txtMaHoSo.Text="HS001"; txtTrangThai.Text="Hoạt động"; MessageBox.Show("Đã ghi phí và cấp hồ sơ.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information); }
    }
}
