using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }
        private void btnTuyenDung_Click(object sender, EventArgs e) { using (var f = new FrmTuyenDung()) f.ShowDialog(this); }
        private void btnHopDong_Click(object sender, EventArgs e) { using (var f = new FrmHopDong()) f.ShowDialog(this); }
        private void btnKhenThuong_Click(object sender, EventArgs e) { using (var f = new FrmKhenThuong()) f.ShowDialog(this); }
        private void btnThoat_Click(object sender, EventArgs e) { Close(); }
    }
}
