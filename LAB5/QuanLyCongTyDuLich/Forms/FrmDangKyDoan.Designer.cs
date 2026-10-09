using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKyDoan
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox grpDoan, grpDangKy;

        private TextBox txtMaDoan, txtTenCQ, txtDiaChi,
                        txtDT, txtDaiDien;
        private TextBox txtSo, txtDon;

        private ComboBox cboTour;
        private DateTimePicker dtDi;

        private NumericUpDown numNguoi, numCoc;
        private CheckBox chkBH;

        private Label lblKetThuc, lblTong;

        private DataGridView dgvThanhVien, dgv;
        private Button btnDangKy, btnHuy, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void Nhan(Control p, string text, int x, int y)
        {
            Label lb = new Label();
            lb.Text = text;
            lb.Location = new Point(x, y);
            lb.Size = new Size(155, 28);
            p.Controls.Add(lb);
        }

        private TextBox TaoText(Control p, string name,
            int x, int y, int w = 280)
        {
            TextBox t = new TextBox();
            t.Name = name;
            t.Location = new Point(x, y);
            t.Size = new Size(w, 29);
            p.Controls.Add(t);
            return t;
        }

        private NumericUpDown So(Control p, string name,
            int x, int y, decimal min, decimal max)
        {
            NumericUpDown n = new NumericUpDown();
            n.Name = name;
            n.Location = new Point(x, y);
            n.Size = new Size(220, 29);
            n.Minimum = min;
            n.Maximum = max;
            n.Value = min;
            n.ThousandsSeparator = true;
            p.Controls.Add(n);
            return n;
        }

        private Button Nut(string text, int x, int y, EventHandler click)
        {
            Button b = new Button();
            b.Text = text;
            b.Location = new Point(x, y);
            b.Size = new Size(190, 38);
            b.Click += click;
            this.Controls.Add(b);
            return b;
        }

        private DataGridView Bang(string name, int x, int y, int w, int h)
        {
            DataGridView d = new DataGridView();
            d.Name = name;
            d.Location = new Point(x, y);
            d.Size = new Size(w, h);
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.MultiSelect = false;
            d.RowHeadersVisible = false;
            d.BackgroundColor = Color.White;
            this.Controls.Add(d);
            return d;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // THÔNG TIN ĐOÀN
            grpDoan = new GroupBox();
            grpDoan.Name = "grpDoan";
            grpDoan.Text = "Thông tin đoàn khách";
            grpDoan.Location = new Point(15, 15);
            grpDoan.Size = new Size(1080, 195);
            this.Controls.Add(grpDoan);

            Nhan(grpDoan, "Mã đoàn", 20, 32);
            txtMaDoan = TaoText(grpDoan, "txtMaDoan", 175, 30);

            Nhan(grpDoan, "Tên cơ quan/đoàn", 535, 32);
            txtTenCQ = TaoText(grpDoan, "txtTenCQ", 695, 30, 345);

            Nhan(grpDoan, "Địa chỉ", 20, 82);
            txtDiaChi = TaoText(grpDoan, "txtDiaChi", 175, 80, 865);

            Nhan(grpDoan, "Điện thoại", 20, 132);
            txtDT = TaoText(grpDoan, "txtDT", 175, 130);

            Nhan(grpDoan, "Người đại diện", 535, 132);
            txtDaiDien = TaoText(grpDoan, "txtDaiDien", 695, 130, 345);

            // THÔNG TIN ĐĂNG KÝ
            grpDangKy = new GroupBox();
            grpDangKy.Name = "grpDangKy";
            grpDangKy.Text = "Thông tin đăng ký tour";
            grpDangKy.Location = new Point(15, 220);
            grpDangKy.Size = new Size(1080, 245);
            this.Controls.Add(grpDangKy);

            Nhan(grpDangKy, "Số đăng ký", 20, 32);
            txtSo = TaoText(grpDangKy, "txtSo", 175, 30);

            Nhan(grpDangKy, "Tour", 535, 32);
            cboTour = new ComboBox();
            cboTour.Name = "cboTour";
            cboTour.Location = new Point(695, 30);
            cboTour.Size = new Size(345, 30);
            cboTour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTour.SelectedIndexChanged += new EventHandler(TinhTong);
            grpDangKy.Controls.Add(cboTour);

            Nhan(grpDangKy, "Ngày đi", 20, 82);
            dtDi = new DateTimePicker();
            dtDi.Name = "dtDi";
            dtDi.Location = new Point(175, 80);
            dtDi.Size = new Size(280, 30);
            dtDi.Format = DateTimePickerFormat.Custom;
            dtDi.CustomFormat = "dd/MM/yyyy";
            dtDi.ValueChanged += new EventHandler(TinhTong);
            grpDangKy.Controls.Add(dtDi);

            Nhan(grpDangKy, "Số người (> 12)", 535, 82);
            numNguoi = So(
                grpDangKy, "numNguoi", 695, 80, 13, 10000);
            numNguoi.ValueChanged += new EventHandler(TinhTong);

            Nhan(grpDangKy, "Nơi đón", 20, 132);
            txtDon = TaoText(grpDangKy, "txtDon", 175, 130);

            Nhan(grpDangKy, "Tiền đặt cọc", 535, 132);
            numCoc = So(
                grpDangKy, "numCoc", 695, 130, 0, 1000000000M);

            chkBH = new CheckBox();
            chkBH.Name = "chkBH";
            chkBH.Text = "Mua bảo hiểm";
            chkBH.AutoSize = true;
            chkBH.Location = new Point(175, 183);
            chkBH.CheckedChanged +=
                new EventHandler(chkBH_CheckedChanged);
            grpDangKy.Controls.Add(chkBH);

            Nhan(grpDangKy, "Ngày kết thúc", 360, 183);
            lblKetThuc = new Label();
            lblKetThuc.Name = "lblKetThuc";
            lblKetThuc.Location = new Point(515, 183);
            lblKetThuc.Size = new Size(160, 30);
            lblKetThuc.Text = "-";
            grpDangKy.Controls.Add(lblKetThuc);

            Nhan(grpDangKy, "Tổng dự kiến", 705, 183);
            lblTong = new Label();
            lblTong.Name = "lblTong";
            lblTong.Location = new Point(865, 183);
            lblTong.Size = new Size(175, 30);
            lblTong.Font = new Font(
                "Segoe UI", 11F, FontStyle.Bold);
            lblTong.Text = "0 đ";
            grpDangKy.Controls.Add(lblTong);

            // DANH SÁCH THÀNH VIÊN
            Label lblTV = new Label();
            lblTV.Text = "DANH SÁCH NGƯỜI CÙNG ĐI (KHI MUA BẢO HIỂM)";
            lblTV.Location = new Point(20, 480);
            lblTV.Size = new Size(700, 30);
            lblTV.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblTV);

            dgvThanhVien = Bang(
                "dgvThanhVien", 20, 515, 1060, 130);
            dgvThanhVien.AllowUserToAddRows = true;
            dgvThanhVien.ReadOnly = false;
            dgvThanhVien.EditMode =
                DataGridViewEditMode.EditOnEnter;

            // NÚT CHỨC NĂNG
            btnDangKy = Nut(
                "Lập phiếu đăng ký", 410, 655, btnDangKy_Click);

            btnHuy = Nut(
                "Hủy đăng ký (mất cọc)", 610, 655, btnHuy_Click);
            btnHuy.Width = 215;

            btnDong = Nut(
                "Đóng", 835, 655, btnDong_Click);

            // DANH SÁCH PHIẾU
            Label lblDS = new Label();
            lblDS.Text = "DANH SÁCH PHIẾU ĐĂNG KÝ ĐOÀN";
            lblDS.Location = new Point(20, 715);
            lblDS.Size = new Size(600, 30);
            lblDS.Font = new Font(
                "Segoe UI", 10F, FontStyle.Bold);
            this.Controls.Add(lblDS);

            dgv = Bang("dgv", 20, 750, 1060, 230);
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;

            this.ClientSize = new Size(1120, 1010);
            this.AutoScroll = true;
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.WhiteSmoke;
            this.Name = "FrmDangKyDoan";
            this.Text = "ĐĂNG KÝ TOUR THEO ĐOÀN";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(FrmDangKyDoan_Load);

            this.ResumeLayout(false);
        }
    }
}
