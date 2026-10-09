
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmLuongThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabTK;
        private TabPage tabTKPage1, tabTKPage2;

        private NumericUpDown numThang, numNam;
        private DateTimePicker dtTu, dtDen;

        private Button btnLuong, btnTongHop, btnDong;

        private DataGridView dgvLuong, dgvTongHop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void Nhan(Control p, string text, int x, int y)
        {
            Label l = new Label();
            l.Text = text;
            l.Location = new Point(x, y);
            l.Size = new Size(145, 28);
            p.Controls.Add(l);
        }

        private DataGridView Bang(
            Control p, string name, int y)
        {
            DataGridView dgv = new DataGridView();
            dgv.Name = name;
            dgv.Location = new Point(20, y);
            dgv.Size = new Size(1020, 425);
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            p.Controls.Add(dgv);
            return dgv;
        }

        private Button Nut(Control p, string text,
            int x, int y, EventHandler click)
        {
            Button b = new Button();
            b.Text = text;
            b.Location = new Point(x, y);
            b.Size = new Size(195, 36);
            b.Click += click;
            p.Controls.Add(b);
            return b;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            tabTK = new TabControl();
            tabTK.Name = "tabTK";
            tabTK.Location = new Point(15, 15);
            tabTK.Size = new Size(1080, 650);
            tabTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                           AnchorStyles.Left | AnchorStyles.Right;

            tabTKPage1 = new TabPage("Tính lương HDV");
            tabTKPage2 = new TabPage("Thống kê tổng hợp");

            tabTK.TabPages.Add(tabTKPage1);
            tabTK.TabPages.Add(tabTKPage2);

            // TAB 1: TÍNH LƯƠNG HƯỚNG DẪN VIÊN
            Nhan(tabTKPage1, "Tháng", 20, 35);
            numThang = new NumericUpDown();
            numThang.Name = "numThang";
            numThang.Location = new Point(175, 35);
            numThang.Size = new Size(190, 30);
            numThang.Minimum = 1;
            numThang.Maximum = 12;
            numThang.Value = 1;
            tabTKPage1.Controls.Add(numThang);

            Nhan(tabTKPage1, "Năm", 430, 35);
            numNam = new NumericUpDown();
            numNam.Name = "numNam";
            numNam.Location = new Point(575, 35);
            numNam.Size = new Size(190, 30);
            numNam.Minimum = 2000;
            numNam.Maximum = 2100;
            numNam.Value = 2026;
            tabTKPage1.Controls.Add(numNam);

            btnLuong = Nut(
                tabTKPage1, "Tính lương HDV",
                825, 35, btnLuong_Click);

            dgvLuong = Bang(
                tabTKPage1, "dgvLuong", 110);

            // TAB 2: THỐNG KÊ TỔNG HỢP
            Nhan(tabTKPage2, "Từ ngày", 20, 35);
            dtTu = new DateTimePicker();
            dtTu.Name = "dtTu";
            dtTu.Location = new Point(175, 35);
            dtTu.Size = new Size(240, 30);
            dtTu.Format = DateTimePickerFormat.Custom;
            dtTu.CustomFormat = "dd/MM/yyyy";
            tabTKPage2.Controls.Add(dtTu);

            Nhan(tabTKPage2, "Đến ngày", 450, 35);
            dtDen = new DateTimePicker();
            dtDen.Name = "dtDen";
            dtDen.Location = new Point(595, 35);
            dtDen.Size = new Size(240, 30);
            dtDen.Format = DateTimePickerFormat.Custom;
            dtDen.CustomFormat = "dd/MM/yyyy";
            tabTKPage2.Controls.Add(dtDen);

            btnTongHop = Nut(
                tabTKPage2, "Thống kê",
                850, 35, btnTongHop_Click);
            btnTongHop.Width = 175;

            dgvTongHop = Bang(
                tabTKPage2, "dgvTongHop", 110);

            this.Controls.Add(tabTK);

            btnDong = Nut(
                this, "Đóng", 885, 680, btnDong_Click);

            this.ClientSize = new Size(1120, 730);
            this.MinimumSize = new Size(850, 560);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.WhiteSmoke;
            this.Name = "FrmLuongThongKe";
            this.Text = "TÍNH LƯƠNG VÀ THỐNG KÊ";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(FrmLuongThongKe_Load);

            this.ResumeLayout(false);
        }
    }
}
