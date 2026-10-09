using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabDanhMuc;
        private TabPage tabDanhMucPage1, tabDanhMucPage2,
                        tabDanhMucPage3, tabDanhMucPage4;

        private TextBox txtPTMa, txtPTTen, txtPTGhiChu;
        private TextBox txtDBMa, txtDBTen, txtDBDiaChi, txtDBDT;
        private TextBox txtHDVMa, txtHDVTen, txtHDVDT;
        private TextBox txtDTQMa, txtDTQTen, txtDTQDiaDiem,
                        txtDTQNoiDung, txtDTQYNghia;

        private NumericUpDown numLuong;

        private DataGridView dgvPT, dgvDB, dgvHDV, dgvDTQ;

        private Button btnThemPT, btnThemDB, btnThemHDV,
                       btnThemDTQ, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private Label TaoNhan(Control parent, string text, int x, int y)
        {
            Label lb = new Label();
            lb.Text = text;
            lb.Location = new Point(x, y);
            lb.Size = new Size(145, 28);
            parent.Controls.Add(lb);
            return lb;
        }

        private TextBox TaoText(Control parent, string name, int x, int y, int width = 300)
        {
            TextBox txt = new TextBox();
            txt.Name = name;
            txt.Location = new Point(x, y);
            txt.Size = new Size(width, 29);
            parent.Controls.Add(txt);
            return txt;
        }

        private Button TaoNut(Control parent, string text, int x, int y, EventHandler click)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(170, 36);
            btn.Click += click;
            parent.Controls.Add(btn);
            return btn;
        }

        private DataGridView TaoBang(Control parent, int y)
        {
            DataGridView dgv = new DataGridView();
            dgv.Location = new Point(15, y);
            dgv.Size = new Size(1010, 360);
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.BackgroundColor = Color.White;
            parent.Controls.Add(dgv);
            return dgv;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            tabDanhMuc = new TabControl();
            tabDanhMuc.Name = "tabDanhMuc";
            tabDanhMuc.Location = new Point(15, 15);
            tabDanhMuc.Size = new Size(1050, 650);
            tabDanhMuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                AnchorStyles.Left | AnchorStyles.Right;

            tabDanhMucPage1 = new TabPage("Phương tiện");
            tabDanhMucPage2 = new TabPage("Điểm bán vé");
            tabDanhMucPage3 = new TabPage("Hướng dẫn viên");
            tabDanhMucPage4 = new TabPage("Điểm tham quan");

            tabDanhMuc.TabPages.AddRange(new TabPage[]
            {
                tabDanhMucPage1, tabDanhMucPage2,
                tabDanhMucPage3, tabDanhMucPage4
            });

            // TAB 1: PHƯƠNG TIỆN
            TaoNhan(tabDanhMucPage1, "Mã phương tiện", 20, 25);
            txtPTMa = TaoText(tabDanhMucPage1, "txtPTMa", 175, 25);

            TaoNhan(tabDanhMucPage1, "Tên phương tiện", 525, 25);
            txtPTTen = TaoText(tabDanhMucPage1, "txtPTTen", 675, 25);

            TaoNhan(tabDanhMucPage1, "Ghi chú", 20, 75);
            txtPTGhiChu = TaoText(tabDanhMucPage1, "txtPTGhiChu", 175, 75, 800);

            btnThemPT = TaoNut(
                tabDanhMucPage1, "Thêm phương tiện",
                805, 120, btnThemPT_Click);

            dgvPT = TaoBang(tabDanhMucPage1, 175);
            dgvPT.Name = "dgvPT";

            // TAB 2: ĐIỂM BÁN VÉ
            TaoNhan(tabDanhMucPage2, "Mã điểm bán", 20, 25);
            txtDBMa = TaoText(tabDanhMucPage2, "txtDBMa", 175, 25);

            TaoNhan(tabDanhMucPage2, "Tên điểm bán", 525, 25);
            txtDBTen = TaoText(tabDanhMucPage2, "txtDBTen", 675, 25);

            TaoNhan(tabDanhMucPage2, "Địa chỉ", 20, 75);
            txtDBDiaChi = TaoText(tabDanhMucPage2, "txtDBDiaChi", 175, 75);

            TaoNhan(tabDanhMucPage2, "Điện thoại", 525, 75);
            txtDBDT = TaoText(tabDanhMucPage2, "txtDBDT", 675, 75);

            btnThemDB = TaoNut(
                tabDanhMucPage2, "Thêm điểm bán",
                805, 120, btnThemDB_Click);

            dgvDB = TaoBang(tabDanhMucPage2, 175);
            dgvDB.Name = "dgvDB";

            // TAB 3: HƯỚNG DẪN VIÊN
            TaoNhan(tabDanhMucPage3, "Mã HDV", 20, 25);
            txtHDVMa = TaoText(tabDanhMucPage3, "txtHDVMa", 175, 25);

            TaoNhan(tabDanhMucPage3, "Họ tên", 525, 25);
            txtHDVTen = TaoText(tabDanhMucPage3, "txtHDVTen", 675, 25);

            TaoNhan(tabDanhMucPage3, "Điện thoại", 20, 75);
            txtHDVDT = TaoText(tabDanhMucPage3, "txtHDVDT", 175, 75);

            TaoNhan(tabDanhMucPage3, "Lương cơ bản", 525, 75);
            numLuong = new NumericUpDown();
            numLuong.Name = "numLuong";
            numLuong.Location = new Point(675, 75);
            numLuong.Size = new Size(300, 29);
            numLuong.Maximum = 1000000000M;
            numLuong.DecimalPlaces = 0;
            numLuong.ThousandsSeparator = true;
            tabDanhMucPage3.Controls.Add(numLuong);

            btnThemHDV = TaoNut(
                tabDanhMucPage3, "Thêm HDV",
                805, 120, btnThemHDV_Click);

            dgvHDV = TaoBang(tabDanhMucPage3, 175);
            dgvHDV.Name = "dgvHDV";

            // TAB 4: ĐIỂM THAM QUAN
            TaoNhan(tabDanhMucPage4, "Mã điểm", 20, 25);
            txtDTQMa = TaoText(tabDanhMucPage4, "txtDTQMa", 175, 25);

            TaoNhan(tabDanhMucPage4, "Tên điểm", 525, 25);
            txtDTQTen = TaoText(tabDanhMucPage4, "txtDTQTen", 675, 25);

            TaoNhan(tabDanhMucPage4, "Địa điểm", 20, 75);
            txtDTQDiaDiem = TaoText(tabDanhMucPage4, "txtDTQDiaDiem", 175, 75, 800);

            TaoNhan(tabDanhMucPage4, "Nội dung", 20, 125);
            txtDTQNoiDung = TaoText(tabDanhMucPage4, "txtDTQNoiDung", 175, 125, 800);

            TaoNhan(tabDanhMucPage4, "Ý nghĩa", 20, 175);
            txtDTQYNghia = TaoText(tabDanhMucPage4, "txtDTQYNghia", 175, 175, 800);

            btnThemDTQ = TaoNut(
                tabDanhMucPage4, "Thêm điểm tham quan",
                785, 220, btnThemDTQ_Click);
            btnThemDTQ.Width = 190;

            dgvDTQ = TaoBang(tabDanhMucPage4, 275);
            dgvDTQ.Name = "dgvDTQ";
            dgvDTQ.Height = 275;

            // NÚT ĐÓNG
            btnDong = TaoNut(
                this, "Đóng", 890, 675, btnDong_Click);

            this.Controls.Add(tabDanhMuc);

            this.ClientSize = new Size(1090, 740);
            this.MinimumSize = new Size(850, 600);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.WhiteSmoke;
            this.Text = "QUẢN LÝ DANH MỤC";
            this.Name = "FrmDanhMuc";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(FrmDanhMuc_Load);

            this.ResumeLayout(false);
        }
    }
}
