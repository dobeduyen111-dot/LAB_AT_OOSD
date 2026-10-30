using System;
using System.Windows.Forms;

namespace QuanLyVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain() { InitializeComponent(); }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmHopDong()) f.ShowDialog(this);
        }
        private void btnThoat_Click(object sender, EventArgs e) { Close(); }
    }
}
