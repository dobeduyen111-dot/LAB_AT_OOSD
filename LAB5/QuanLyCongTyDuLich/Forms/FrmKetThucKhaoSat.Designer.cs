
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmKetThucKhaoSat
    {
        private System.ComponentModel.IContainer components = null;

        // TabControl
        private TabControl tabKT;
        private TabPage tabThanhToan;
        private TabPage tabKhaoSat;

        // Thanh toán đoàn
        private DataGridView dgvDoan;
        private TextBox txtSoTT;
        private TextBox txtSoDK;
        private TextBox txtGhiChu;
        private DateTimePicker dtTT;
        private NumericUpDown numTien;
        private Button btnThanhToan;

        // Khảo sát khách hàng
        private ComboBox cboLoaiKS;
        private ComboBox cboDangKy;
        private TextBox txtMaKS;
        private TextBox txtKSChon;
        private TextBox txtGopY;
        private DateTimePicker dtGui;
        private DateTimePicker dtPH;
        private NumericUpDown numDiem;
        private DataGridView dgvKS;
        private Button btnGui;
        private Button btnGhiPH;

        // Nút đóng
        private Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Hàm tạo Label
        private Label TaoNhan(
            Control parent,
            string noiDung,
            int x,
            int y)
        {
            Label lbl = new Label();

            lbl.Text = noiDung;
            lbl.Location = new Point(x, y);
            lbl.Size = new Size(150, 28);
            lbl.TextAlign = ContentAlignment.MiddleLeft;

            parent.Controls.Add(lbl);

            return lbl;
        }

        // Hàm tạo TextBox
        // Đổi tên thành TaoTextBox để không trùng Form.Text
        private TextBox TaoTextBox(
            Control parent,
            string ten,
            int x,
            int y,
            int rong = 300)
        {
            TextBox txt = new TextBox();

            txt.Name = ten;
            txt.Location = new Point(x, y);
            txt.Size = new Size(rong, 30);

            parent.Controls.Add(txt);

            return txt;
        }

        // Hàm tạo ComboBox
        private ComboBox TaoComboBox(
            Control parent,
            string ten,
            int x,
            int y)
        {
            ComboBox cbo = new ComboBox();

            cbo.Name = ten;
            cbo.Location = new Point(x, y);
            cbo.Size = new Size(300, 30);
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;

            parent.Controls.Add(cbo);

            return cbo;
        }

        // Hàm tạo DateTimePicker
        private DateTimePicker TaoNgay(
            Control parent,
            string ten,
            int x,
            int y)
        {
            DateTimePicker dt = new DateTimePicker();

            dt.Name = ten;
            dt.Location = new Point(x, y);
            dt.Size = new Size(300, 30);
            dt.Format = DateTimePickerFormat.Custom;
            dt.CustomFormat = "dd/MM/yyyy";

            parent.Controls.Add(dt);

            return dt;
        }

        // Hàm tạo Button
        private Button TaoNut(
            Control parent,
            string ten,
            string noiDung,
            int x,
            int y,
            EventHandler suKien)
        {
            Button btn = new Button();

            btn.Name = ten;
            btn.Text = noiDung;
            btn.Location = new Point(x, y);
            btn.Size = new Size(190, 38);
            btn.UseVisualStyleBackColor = true;

            if (suKien != null)
            {
                btn.Click += suKien;
            }

            parent.Controls.Add(btn);

            return btn;
        }

        // Hàm tạo DataGridView
        private DataGridView TaoBang(
            Control parent,
            string ten,
            int x,
            int y,
            int rong,
            int cao)
        {
            DataGridView dgv = new DataGridView();

            dgv.Name = ten;
            dgv.Location = new Point(x, y);
            dgv.Size = new Size(rong, cao);

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;

            parent.Controls.Add(dgv);

            return dgv;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // =====================================
            // TAB CONTROL
            // =====================================

            this.tabKT = new TabControl();
            this.tabKT.Name = "tabKT";
            this.tabKT.Location = new Point(15, 15);
            this.tabKT.Size = new Size(1080, 680);

            this.tabKT.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            this.tabThanhToan = new TabPage();
            this.tabThanhToan.Name = "tabThanhToan";
            this.tabThanhToan.Text = "Thanh toán đoàn";
            this.tabThanhToan.BackColor = Color.White;

            this.tabKhaoSat = new TabPage();
            this.tabKhaoSat.Name = "tabKhaoSat";
            this.tabKhaoSat.Text = "Khảo sát khách hàng";
            this.tabKhaoSat.BackColor = Color.White;

            this.tabKT.TabPages.Add(this.tabThanhToan);
            this.tabKT.TabPages.Add(this.tabKhaoSat);

            this.Controls.Add(this.tabKT);

            // =====================================
            // TAB 1: THANH TOÁN ĐOÀN
            // =====================================

            TaoNhan(
                this.tabThanhToan,
                "Danh sách đoàn cần thanh toán",
                20, 20
            ).Width = 400;

            // Bảng danh sách đoàn
            this.dgvDoan = TaoBang(
                this.tabThanhToan,
                "dgvDoan",
                20, 55, 1020, 230
            );

            this.dgvDoan.SelectionChanged +=
                new EventHandler(
                    this.dgvDoan_SelectionChanged
                );

            // Số thanh toán
            TaoNhan(
                this.tabThanhToan,
                "Số thanh toán",
                20, 315
            );

            this.txtSoTT = TaoTextBox(
                this.tabThanhToan,
                "txtSoTT",
                175, 315
            );

            // Số đăng ký đoàn
            TaoNhan(
                this.tabThanhToan,
                "Số đăng ký",
                540, 315
            );

            this.txtSoDK = TaoTextBox(
                this.tabThanhToan,
                "txtSoDK",
                695, 315
            );

            this.txtSoDK.ReadOnly = true;

            // Ngày thanh toán
            TaoNhan(
                this.tabThanhToan,
                "Ngày thanh toán",
                20, 370
            );

            this.dtTT = TaoNgay(
                this.tabThanhToan,
                "dtTT",
                175, 370
            );

            // Số tiền thanh toán
            TaoNhan(
                this.tabThanhToan,
                "Số tiền",
                540, 370
            );

            this.numTien = new NumericUpDown();
            this.numTien.Name = "numTien";
            this.numTien.Location = new Point(695, 370);
            this.numTien.Size = new Size(300, 30);

            this.numTien.Minimum = 0;
            this.numTien.Maximum = 1000000000000M;
            this.numTien.DecimalPlaces = 0;
            this.numTien.ThousandsSeparator = true;

            this.tabThanhToan.Controls.Add(this.numTien);

            // Ghi chú
            TaoNhan(
                this.tabThanhToan,
                "Ghi chú",
                20, 425
            );

            this.txtGhiChu = TaoTextBox(
                this.tabThanhToan,
                "txtGhiChu",
                175, 425, 820
            );

            // Nút thanh toán
            this.btnThanhToan = TaoNut(
                this.tabThanhToan,
                "btnThanhToan",
                "Ghi nhận thanh toán",
                795, 480,
                this.btnThanhToan_Click
            );

            this.btnThanhToan.Width = 200;

            // =====================================
            // TAB 2: KHẢO SÁT KHÁCH HÀNG
            // =====================================

            // Loại khách
            TaoNhan(
                this.tabKhaoSat,
                "Loại khách",
                20, 25
            );

            this.cboLoaiKS = TaoComboBox(
                this.tabKhaoSat,
                "cboLoaiKS",
                175, 25
            );

            this.cboLoaiKS.SelectedIndexChanged +=
                new EventHandler(
                    this.cboLoaiKS_SelectedIndexChanged
                );

            // Đăng ký đã kết thúc
            TaoNhan(
                this.tabKhaoSat,
                "Đăng ký đã kết thúc",
                525, 25
            ).Width = 165;

            this.cboDangKy = TaoComboBox(
                this.tabKhaoSat,
                "cboDangKy",
                695, 25
            );

            // Mã khảo sát
            TaoNhan(
                this.tabKhaoSat,
                "Mã khảo sát",
                20, 75
            );

            this.txtMaKS = TaoTextBox(
                this.tabKhaoSat,
                "txtMaKS",
                175, 75
            );

            // Ngày gửi khảo sát
            TaoNhan(
                this.tabKhaoSat,
                "Ngày gửi",
                540, 75
            );

            this.dtGui = TaoNgay(
                this.tabKhaoSat,
                "dtGui",
                695, 75
            );

            // Nút gửi khảo sát
            this.btnGui = TaoNut(
                this.tabKhaoSat,
                "btnGui",
                "Gửi phiếu khảo sát",
                805, 125,
                this.btnGui_Click
            );

            // Danh sách khảo sát
            TaoNhan(
                this.tabKhaoSat,
                "Danh sách phiếu khảo sát",
                20, 178
            ).Width = 400;

            this.dgvKS = TaoBang(
                this.tabKhaoSat,
                "dgvKS",
                20, 210, 1020, 190
            );

            this.dgvKS.SelectionChanged +=
                new EventHandler(
                    this.dgvKS_SelectionChanged
                );

            // Mã phiếu khảo sát đã chọn
            TaoNhan(
                this.tabKhaoSat,
                "Phiếu chọn",
                20, 420
            );

            this.txtKSChon = TaoTextBox(
                this.tabKhaoSat,
                "txtKSChon",
                175, 420
            );

            this.txtKSChon.ReadOnly = true;

            // Ngày phản hồi
            TaoNhan(
                this.tabKhaoSat,
                "Ngày phản hồi",
                540, 420
            );

            this.dtPH = TaoNgay(
                this.tabKhaoSat,
                "dtPH",
                695, 420
            );

            // Điểm đánh giá
            TaoNhan(
                this.tabKhaoSat,
                "Điểm đánh giá",
                20, 470
            );

            this.numDiem = new NumericUpDown();
            this.numDiem.Name = "numDiem";
            this.numDiem.Location = new Point(175, 470);
            this.numDiem.Size = new Size(160, 30);

            this.numDiem.Minimum = 1;
            this.numDiem.Maximum = 5;
            this.numDiem.Value = 5;

            this.tabKhaoSat.Controls.Add(this.numDiem);

            // Nội dung góp ý
            TaoNhan(
                this.tabKhaoSat,
                "Góp ý",
                20, 525
            );

            this.txtGopY = TaoTextBox(
                this.tabKhaoSat,
                "txtGopY",
                175, 525, 820
            );

            this.txtGopY.Multiline = true;
            this.txtGopY.ScrollBars =
                ScrollBars.Vertical;
            this.txtGopY.Height = 65;

            // Nút ghi nhận phản hồi
            this.btnGhiPH = TaoNut(
                this.tabKhaoSat,
                "btnGhiPH",
                "Ghi nhận góp ý",
                805, 600,
                this.btnGhiPH_Click
            );

            // =====================================
            // NÚT ĐÓNG FORM
            // =====================================

            this.btnDong = TaoNut(
                this,
                "btnDong",
                "Đóng",
                875, 705,
                this.btnDong_Click
            );

            // =====================================
            // CẤU HÌNH FORM
            // =====================================

            this.AutoScaleDimensions =
                new SizeF(8F, 16F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.ClientSize =
                new Size(1120, 770);

            this.MinimumSize =
                new Size(850, 600);

            this.Font =
                new Font("Segoe UI", 10F);

            this.BackColor =
                Color.WhiteSmoke;

            this.Name =
                "FrmKetThucKhaoSat";

            this.Text =
                "KẾT THÚC TOUR - THANH TOÁN - KHẢO SÁT";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            // Sự kiện Load
            this.Load +=
                new EventHandler(
                    this.FrmKetThucKhaoSat_Load
                );

            this.ResumeLayout(false);
        }
    }
}
