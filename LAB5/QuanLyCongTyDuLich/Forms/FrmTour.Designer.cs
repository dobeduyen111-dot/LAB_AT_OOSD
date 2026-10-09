using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmTour
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabTour;
        private TabPage tabTourPage1, tabTourPage2,
                        tabTourPage3, tabTourPage4;

        private ComboBox cboTour, cboPT, cboDTQ;
        private TextBox txtMa, txtTen, txtMoTa;
        private TextBox txtDiemDung, txtGhiChuDD, txtGhiChuPT;

        private NumericUpDown numNgay, numDem, numGia;
        private NumericUpDown numThuTu, numSao, numChang, numThuTuTQ;

        private CheckBox chkDoiPT, chkAn, chkKS;

        private DataGridView dgvTour, dgvDiemDung, dgvChang, dgvTQ;

        private Button btnThemTour, btnThemDD,
                       btnThemChang, btnThemTQ, btnDong;

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
            l.Size = new Size(155, 28);
            p.Controls.Add(l);
        }

        private TextBox TaoText(Control p, string name, int x, int y, int w = 280)
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

        private ComboBox Combo(Control p, string name, int x, int y, int w = 280)
        {
            ComboBox c = new ComboBox();
            c.Name = name;
            c.Location = new Point(x, y);
            c.Size = new Size(w, 30);
            c.DropDownStyle = ComboBoxStyle.DropDownList;
            p.Controls.Add(c);
            return c;
        }

        private Button Nut(Control p, string text,
            int x, int y, EventHandler click)
        {
            Button b = new Button();
            b.Text = text;
            b.Location = new Point(x, y);
            b.Size = new Size(185, 36);
            b.Click += click;
            p.Controls.Add(b);
            return b;
        }

        private DataGridView Bang(Control p, string name, int y, int h = 350)
        {
            DataGridView d = new DataGridView();
            d.Name = name;
            d.Location = new Point(15, y);
            d.Size = new Size(1030, h);
            d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                       AnchorStyles.Left | AnchorStyles.Right;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.MultiSelect = false;
            d.ReadOnly = true;
            d.AllowUserToAddRows = false;
            d.RowHeadersVisible = false;
            d.BackgroundColor = Color.White;
            p.Controls.Add(d);
            return d;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            Nhan(this, "Chọn tour", 20, 20);
            cboTour = Combo(this, "cboTour", 170, 20, 750);
            cboTour.SelectedIndexChanged +=
                new EventHandler(cboTour_SelectedIndexChanged);

            tabTour = new TabControl();
            tabTour.Name = "tabTour";
            tabTour.Location = new Point(15, 70);
            tabTour.Size = new Size(1070, 640);
            tabTour.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                             AnchorStyles.Left | AnchorStyles.Right;

            tabTourPage1 = new TabPage("Thông tin tour");
            tabTourPage2 = new TabPage("Điểm dừng");
            tabTourPage3 = new TabPage("Chặng phương tiện");
            tabTourPage4 = new TabPage("Điểm tham quan");

            tabTour.TabPages.AddRange(new TabPage[]
            {
                tabTourPage1, tabTourPage2,
                tabTourPage3, tabTourPage4
            });

            // TAB 1: THÔNG TIN TOUR
            Nhan(tabTourPage1, "Mã tour", 20, 25);
            txtMa = TaoText(tabTourPage1, "txtMa", 175, 25);

            Nhan(tabTourPage1, "Tên tour", 530, 25);
            txtTen = TaoText(tabTourPage1, "txtTen", 685, 25, 330);

            Nhan(tabTourPage1, "Số ngày", 20, 75);
            numNgay = So(tabTourPage1, "numNgay", 175, 75, 1, 365);

            Nhan(tabTourPage1, "Số đêm", 530, 75);
            numDem = So(tabTourPage1, "numDem", 685, 75, 0, 364);

            Nhan(tabTourPage1, "Đơn giá/khách", 20, 125);
            numGia = So(tabTourPage1, "numGia", 175, 125, 0, 1000000000M);

            Nhan(tabTourPage1, "Mô tả", 20, 175);
            txtMoTa = TaoText(tabTourPage1, "txtMoTa", 175, 175, 840);

            btnThemTour = Nut(
                tabTourPage1, "Thêm tour", 830, 220, btnThemTour_Click);

            dgvTour = Bang(tabTourPage1, "dgvTour", 275, 295);

            // TAB 2: ĐIỂM DỪNG
            Nhan(tabTourPage2, "Thứ tự", 20, 25);
            numThuTu = So(tabTourPage2, "numThuTu", 175, 25, 1, 999);

            Nhan(tabTourPage2, "Tên điểm dừng", 530, 25);
            txtDiemDung = TaoText(
                tabTourPage2, "txtDiemDung", 685, 25, 330);

            chkDoiPT = new CheckBox();
            chkDoiPT.Name = "chkDoiPT";
            chkDoiPT.Text = "Đổi phương tiện";
            chkDoiPT.Location = new Point(175, 75);
            chkDoiPT.AutoSize = true;
            tabTourPage2.Controls.Add(chkDoiPT);

            chkAn = new CheckBox();
            chkAn.Name = "chkAn";
            chkAn.Text = "Có nơi ăn";
            chkAn.Location = new Point(390, 75);
            chkAn.AutoSize = true;
            tabTourPage2.Controls.Add(chkAn);

            chkKS = new CheckBox();
            chkKS.Name = "chkKS";
            chkKS.Text = "Có khách sạn";
            chkKS.Location = new Point(560, 75);
            chkKS.AutoSize = true;
            chkKS.CheckedChanged +=
                new EventHandler(chkKS_CheckedChanged);
            tabTourPage2.Controls.Add(chkKS);

            Nhan(tabTourPage2, "Hạng sao", 20, 125);
            numSao = So(tabTourPage2, "numSao", 175, 125, 2, 5);
            numSao.Enabled = false;

            Nhan(tabTourPage2, "Ghi chú", 530, 125);
            txtGhiChuDD = TaoText(
                tabTourPage2, "txtGhiChuDD", 685, 125, 330);

            btnThemDD = Nut(
                tabTourPage2, "Thêm điểm dừng",
                830, 175, btnThemDD_Click);

            dgvDiemDung = Bang(
                tabTourPage2, "dgvDiemDung", 230, 340);

            // TAB 3: CHẶNG PHƯƠNG TIỆN
            Nhan(tabTourPage3, "Thứ tự chặng", 20, 30);
            numChang = So(
                tabTourPage3, "numChang", 175, 30, 1, 999);

            Nhan(tabTourPage3, "Phương tiện", 530, 30);
            cboPT = Combo(
                tabTourPage3, "cboPT", 685, 30, 330);

            Nhan(tabTourPage3, "Ghi chú", 20, 85);
            txtGhiChuPT = TaoText(
                tabTourPage3, "txtGhiChuPT", 175, 85, 840);

            btnThemChang = Nut(
                tabTourPage3, "Thêm chặng",
                830, 135, btnThemChang_Click);

            dgvChang = Bang(
                tabTourPage3, "dgvChang", 195, 375);

            // TAB 4: ĐIỂM THAM QUAN
            Nhan(tabTourPage4, "Điểm tham quan", 20, 30);
            cboDTQ = Combo(
                tabTourPage4, "cboDTQ", 175, 30, 430);

            Nhan(tabTourPage4, "Thứ tự tham quan", 20, 85);
            numThuTuTQ = So(
                tabTourPage4, "numThuTuTQ", 175, 85, 1, 999);

            btnThemTQ = Nut(
                tabTourPage4, "Gắn điểm tham quan",
                820, 90, btnThemTQ_Click);

            dgvTQ = Bang(
                tabTourPage4, "dgvTQ", 170, 400);

            this.Controls.Add(tabTour);

            btnDong = Nut(
                this, "Đóng", 880, 720, btnDong_Click);

            this.ClientSize = new Size(1110, 785);
            this.MinimumSize = new Size(850, 620);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.WhiteSmoke;
            this.Name = "FrmTour";
            this.Text = "QUẢN LÝ TOUR VÀ HÀNH TRÌNH";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(FrmTour_Load);

            this.ResumeLayout(false);
        }
    }
}
