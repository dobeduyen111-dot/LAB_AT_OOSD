namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboDat, cboNV, cboNV2, cboHT;
        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvDBChon, dgvHD;
        private System.Windows.Forms.TextBox txtPhong, txtSoDB, txtMucDo, txtSoHD, txtHDChon, txtMaTT;
        private System.Windows.Forms.NumericUpDown numDenBu, numSoNgay, numTienTT;
        private System.Windows.Forms.Button btnThemDB, btnLapDB, btnLapHD, btnThanhToan, btnTraPhong, btnDong;

        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private System.Windows.Forms.Label LBL(string text, int x, int y, int w) { var l = new System.Windows.Forms.Label(); l.Text = text; l.Location = new System.Drawing.Point(x, y); l.Size = new System.Drawing.Size(w, 18); return l; }
        private System.Windows.Forms.ComboBox CB(string n, int x, int y, int w) { var c = new System.Windows.Forms.ComboBox(); c.Name = n; c.Location = new System.Drawing.Point(x, y); c.Size = new System.Drawing.Size(w, 25); c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; return c; }
        private System.Windows.Forms.TextBox TB(string n, int x, int y, int w) { var t = new System.Windows.Forms.TextBox(); t.Name = n; t.Location = new System.Drawing.Point(x, y); t.Size = new System.Drawing.Size(w, 25); return t; }
        private System.Windows.Forms.DataGridView DG(string n, int x, int y, int w, int h) { var d = new System.Windows.Forms.DataGridView(); d.Name = n; d.Location = new System.Drawing.Point(x, y); d.Size = new System.Drawing.Size(w, h); d.ReadOnly = true; d.MultiSelect = false; d.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; return d; }
        private System.Windows.Forms.Button BT(string n, string tx, int x, int y) { var b = new System.Windows.Forms.Button(); b.Name = n; b.Text = tx; b.Location = new System.Drawing.Point(x, y); b.Size = new System.Drawing.Size(115, 28); return b; }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            cboDat = CB("cboDat", 15, 25, 170); cboNV = CB("cboNV", 195, 25, 140); cboNV2 = CB("cboNV2", 345, 25, 140); cboHT = CB("cboHT", 495, 25, 130);

            txtPhong = TB("txtPhong", 15, 75, 100); txtPhong.ReadOnly = true;
            txtSoDB = TB("txtSoDB", 125, 75, 100); txtMucDo = TB("txtMucDo", 235, 75, 120);
            numDenBu = new System.Windows.Forms.NumericUpDown(); numDenBu.Name = "numDenBu"; numDenBu.Location = new System.Drawing.Point(365, 75); numDenBu.Size = new System.Drawing.Size(120, 25); numDenBu.Maximum = 1000000000;

            txtSoHD = TB("txtSoHD", 495, 75, 100);
            numSoNgay = new System.Windows.Forms.NumericUpDown(); numSoNgay.Name = "numSoNgay"; numSoNgay.Location = new System.Drawing.Point(605, 75); numSoNgay.Size = new System.Drawing.Size(80, 25); numSoNgay.Minimum = 1; numSoNgay.Value = 1;

            txtHDChon = TB("txtHDChon", 15, 125, 100); txtHDChon.ReadOnly = true;
            txtMaTT = TB("txtMaTT", 125, 125, 100);
            numTienTT = new System.Windows.Forms.NumericUpDown(); numTienTT.Name = "numTienTT"; numTienTT.Location = new System.Drawing.Point(235, 125); numTienTT.Size = new System.Drawing.Size(130, 25); numTienTT.Maximum = 1000000000;

            dgvPhong = DG("dgvPhong", 15, 175, 380, 140);
            dgvTN = DG("dgvTN", 410, 175, 380, 140);
            dgvDBChon = DG("dgvDBChon", 15, 340, 380, 130);
            dgvHD = DG("dgvHD", 410, 340, 380, 130);

            btnThemDB = BT("btnThemDB", "Thêm đền bù", 15, 480);
            btnLapDB = BT("btnLapDB", "Lập đền bù", 140, 480);
            btnLapHD = BT("btnLapHD", "Lập hóa đơn", 265, 480);
            btnThanhToan = BT("btnThanhToan", "Thanh toán", 390, 480);
            btnTraPhong = BT("btnTraPhong", "Trả phòng", 515, 480);
            btnDong = BT("btnDong", "Đóng", 675, 480);

            this.Controls.AddRange(new System.Windows.Forms.Control[]{
                LBL("Phiếu đặt:", 15, 8, 170), cboDat, LBL("NV Đền bù:", 195, 8, 140), cboNV, LBL("NV Hóa đơn:", 345, 8, 140), cboNV2, LBL("Hình thức TT:", 495, 8, 130), cboHT,
                LBL("Phòng:", 15, 55, 100), txtPhong, LBL("Số đền bù:", 125, 55, 100), txtSoDB, LBL("Mức độ:", 235, 55, 120), txtMucDo, LBL("Tiền đền bù:", 365, 55, 120), numDenBu,
                LBL("Số hóa đơn:", 495, 55, 100), txtSoHD, LBL("Số ngày ở:", 605, 55, 80), numSoNgay,
                LBL("HĐ chọn:", 15, 105, 100), txtHDChon, LBL("Mã TT:", 125, 105, 100), txtMaTT, LBL("Số tiền TT:", 235, 105, 130), numTienTT,

                LBL("Danh sách phòng trong phiếu:", 15, 155, 200), dgvPhong,
                LBL("Danh sách tiện nghi hỏng:", 410, 155, 200), dgvTN,
                LBL("Chi tiết đền bù đã chọn:", 15, 320, 200), dgvDBChon,
                LBL("Danh sách hóa đơn & thanh toán:", 410, 320, 200), dgvHD,

                btnThemDB, btnLapDB, btnLapHD, btnThanhToan, btnTraPhong, btnDong
            });

            dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.Load += new System.EventHandler(this.Frm_Load);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 520);
            this.Name = "FrmTraPhong"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả phòng & Thanh toán";
        }
    }
}