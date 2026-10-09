using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmPhanCongHDV
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtMaPC;
        private ComboBox cboHDV, cboLoai, cboDoiTuong;
        private NumericUpDown numThuLao;
        private Button btnPhanCong, btnDong;
        private DataGridView dgv;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void Nhan(string text, int x, int y)
        {
            Label l = new Label();
            l.Text = text;
            l.Location = new Point(x, y);
            l.Size = new Size(155, 28);
            this.Controls.Add(l);
        }

        private ComboBox Combo(string name, int x, int y)
        {
            ComboBox c = new ComboBox();
            c.Name = name;
            c.Location = new Point(x, y);
            c.Size = new Size(345, 30);
            c.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(c);
            return c;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            Label lblTitle = new Label();
            lblTitle.Text = "PHÂN CÔNG HƯỚNG DẪN VIÊN";
            lblTitle.Location = new Point(20, 15);
            lblTitle.Size = new Size(800, 35);
            lblTitle.Font = new Font(
                "Segoe UI", 15F, FontStyle.Bold);
            this.Controls.Add(lblTitle);

            Nhan("Mã phân công", 20, 75);
            txtMaPC = new TextBox();
            txtMaPC.Name = "txtMaPC";
            txtMaPC.Location = new Point(175, 75);
            txtMaPC.Size = new Size(345, 29);
            this.Controls.Add(txtMaPC);

            Nhan("Hướng dẫn viên", 560, 75);
            cboHDV = Combo("cboHDV", 715, 75);

            Nhan("Loại đối tượng", 20, 130);
            cboLoai = Combo("cboLoai", 175, 130);
            cboLoai.SelectedIndexChanged +=
                new EventHandler(cboLoai_SelectedIndexChanged);

            Nhan("Chuyến / Đoàn", 560, 130);
            cboDoiTuong = Combo("cboDoiTuong", 715, 130);

            Nhan("Thù lao tour", 20, 185);
            numThuLao = new NumericUpDown();
            numThuLao.Name = "numThuLao";
            numThuLao.Location = new Point(175, 185);
            numThuLao.Size = new Size(345, 30);
            numThuLao.Maximum = 1000000000M;
            numThuLao.ThousandsSeparator = true;
            this.Controls.Add(numThuLao);

            btnPhanCong = new Button();
            btnPhanCong.Name = "btnPhanCong";
            btnPhanCong.Text = "Phân công";
            btnPhanCong.Location = new Point(700, 185);
            btnPhanCong.Size = new Size(170, 36);
            btnPhanCong.Click +=
                new EventHandler(btnPhanCong_Click);
            this.Controls.Add(btnPhanCong);

            btnDong = new Button();
            btnDong.Name = "btnDong";
            btnDong.Text = "Đóng";
            btnDong.Location = new Point(885, 185);
            btnDong.Size = new Size(170, 36);
            btnDong.Click += new EventHandler(btnDong_Click);
            this.Controls.Add(btnDong);

            dgv = new DataGridView();
            dgv.Name = "dgv";
            dgv.Location = new Point(20, 260);
            dgv.Size = new Size(1035, 420);
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            this.Controls.Add(dgv);

            this.ClientSize = new Size(1120, 730);
            this.MinimumSize = new Size(850, 550);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.WhiteSmoke;
            this.Name = "FrmPhanCongHDV";
            this.Text = "PHÂN CÔNG HƯỚNG DẪN VIÊN";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(FrmPhanCongHDV_Load);

            this.ResumeLayout(false);
        }
    }
}
