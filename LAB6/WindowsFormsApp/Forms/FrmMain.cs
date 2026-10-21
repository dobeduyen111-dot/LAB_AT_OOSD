using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        { using (var f = new FrmDanhMuc()) f.ShowDialog(this); }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        { using (var f = new FrmBenhNhan()) f.ShowDialog(this); }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        { using (var f = new FrmKhamBenh()) f.ShowDialog(this); }

        private void btnLapToa_Click(object sender, EventArgs e)
        { using (var f = new FrmLapToaThuoc()) f.ShowDialog(this); }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                var tenDb = Db.Scalar("SELECT DB_NAME()");
                MessageBox.Show("Kết nối thành công!\nDatabase: " + tenDb, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối SQL Server:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
