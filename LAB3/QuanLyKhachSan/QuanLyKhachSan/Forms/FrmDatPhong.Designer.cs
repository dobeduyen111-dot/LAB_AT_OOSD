namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaKH, txtTenKH, txtCMND, txtQT, txtSDT, txtSoPhieu;
        private System.Windows.Forms.ComboBox cboKhach, cboNV, cboKenh;
        private System.Windows.Forms.DateTimePicker dtLap, dtNhan, dtTra;
        private System.Windows.Forms.NumericUpDown numCoc, numSoNguoi;
        private System.Windows.Forms.DataGridView dgvKhach, dgvPhong, dgvChon, dgvPhieu, dgvCT, dgvNguoi;
        private System.Windows.Forms.TextBox txtPhieuChon, txtNguoiPhong, txtNguoiTen, txtNguoiCMND, txtNguoiQT;
        private System.Windows.Forms.Button btnThemKhach, btnThemPhong, btnBoPhong, btnLapPhieu, btnThemNguoi, btnNhanPhong, btnNoShow, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose(); base.Dispose(disposing);
        }

        private System.Windows.Forms.Label LBL(string text, int x, int y, int w)
        {
            var l = new System.Windows.Forms.Label(); l.Text = text; l.Location = new System.Drawing.Point(x, y); l.Size = new System.Drawing.Size(w, 18); return l;
        }
        private System.Windows.Forms.TextBox TB(string n, int x, int y, int w) { var t = new System.Windows.Forms.TextBox(); t.Name = n; t.Location = new System.Drawing.Point(x, y); t.Size = new System.Drawing.Size(w, 25); return t; }
        private System.Windows.Forms.ComboBox CB(string n, int x, int y, int w) { var c = new System.Windows.Forms.ComboBox(); c.Name = n; c.Location = new System.Drawing.Point(x, y); c.Size = new System.Drawing.Size(w, 25); c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; return c; }
        private System.Windows.Forms.DataGridView DG(string n, int x, int y, int w, int h) { var d = new System.Windows.Forms.DataGridView(); d.Name = n; d.Location = new System.Drawing.Point(x, y); d.Size = new System.Drawing.Size(w, h); d.ReadOnly = true; d.MultiSelect = false; d.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; return d; }
        private System.Windows.Forms.Button BT(string n, string tx, int x, int y) { var b = new System.Windows.Forms.Button(); b.Name = n; b.Text = tx; b.Location = new System.Drawing.Point(x, y); b.Size = new System.Drawing.Size(105, 28); return b; }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Row 1: Them Khach
            txtMaKH = TB("txtMaKH", 15, 25, 90); txtTenKH = TB("txtTenKH", 110, 25, 150); txtCMND = TB("txtCMND", 265, 25, 110); txtQT = TB("txtQT", 380, 25, 100); txtSDT = TB("txtSDT", 485, 25, 110);
            btnThemKhach = BT("btnThemKhach", "Thêm khách", 600, 23);

            // Row 2: Thong tin Phieu Dat
            txtSoPhieu = TB("txtSoPhieu", 15, 75, 100); cboKhach = CB("cboKhach", 120, 75, 150); cboNV = CB("cboNV", 275, 75, 130); cboKenh = CB("cboKenh", 410, 75, 110);
            dtLap = new System.Windows.Forms.DateTimePicker(); dtLap.Name = "dtLap"; dtLap.Location = new System.Drawing.Point(525, 75); dtLap.Size = new System.Drawing.Size(110, 25); dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtNhan = new System.Windows.Forms.DateTimePicker(); dtNhan.Name = "dtNhan"; dtNhan.Location = new System.Drawing.Point(640, 75); dtNhan.Size = new System.Drawing.Size(110, 25); dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtTra = new System.Windows.Forms.DateTimePicker(); dtTra.Name = "dtTra"; dtTra.Location = new System.Drawing.Point(755, 75); dtTra.Size = new System.Drawing.Size(110, 25); dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            numCoc = new System.Windows.Forms.NumericUpDown(); numCoc.Name = "numCoc"; numCoc.Location = new System.Drawing.Point(15, 125); numCoc.Size = new System.Drawing.Size(120, 25); numCoc.Maximum = 1000000000;
            numSoNguoi = new System.Windows.Forms.NumericUpDown(); numSoNguoi.Name = "numSoNguoi"; numSoNguoi.Location = new System.Drawing.Point(145, 125); numSoNguoi.Size = new System.Drawing.Size(80, 25); numSoNguoi.Minimum = 1; numSoNguoi.Value = 1;

            // Grids Middle
            dgvKhach = DG("dgvKhach", 15, 180, 420, 140);
            dgvPhong = DG("dgvPhong", 445, 180, 420, 140);
            dgvChon = DG("dgvChon", 15, 350, 420, 120);
            dgvPhieu = DG("dgvPhieu", 445, 350, 420, 120);

            btnThemPhong = BT("btnThemPhong", "Chọn phòng", 15, 478);
            btnBoPhong = BT("btnBoPhong", "Bỏ phòng", 125, 478);
            btnLapPhieu = BT("btnLapPhieu", "Lập phiếu", 235, 478);

            // Bottom Section
            txtPhieuChon = TB("txtPhieuChon", 445, 495, 100);
            txtNguoiPhong = TB("txtNguoiPhong", 550, 495, 80);
            txtNguoiTen = TB("txtNguoiTen", 635, 495, 120);
            txtNguoiCMND = TB("txtNguoiCMND", 15, 545, 110);
            txtNguoiQT = TB("txtNguoiQT", 130, 545, 110);

            btnThemNguoi = BT("btnThemNguoi", "Thêm người", 250, 543);
            btnNhanPhong = BT("btnNhanPhong", "Nhận phòng", 360, 543);
            btnNoShow = BT("btnNoShow", "No Show", 470, 543);
            btnDong = BT("btnDong", "Đóng", 760, 543);

            dgvCT = DG("dgvCT", 15, 580, 420, 110);
            dgvNguoi = DG("dgvNguoi", 445, 580, 420, 110);

            this.Controls.AddRange(new System.Windows.Forms.Control[]{
                LBL("Mã KH:", 15, 8, 90), txtMaKH, LBL("Tên khách hàng:", 110, 8, 150), txtTenKH,
                LBL("CMND/CCCD:", 265, 8, 110), txtCMND, LBL("Quốc tịch:", 380, 8, 100), txtQT,
                LBL("Số điện thoại:", 485, 8, 110), txtSDT, btnThemKhach,

                LBL("Số phiếu:", 15, 55, 100), txtSoPhieu, LBL("Khách hàng:", 120, 55, 150), cboKhach,
                LBL("Nhân viên:", 275, 55, 130), cboNV, LBL("Kênh đặt:", 410, 55, 110), cboKenh,
                LBL("Ngày lập:", 525, 55, 110), dtLap, LBL("Ngày nhận:", 640, 55, 110), dtNhan, LBL("Ngày trả:", 755, 55, 110), dtTra,
                LBL("Tiền cọc:", 15, 105, 120), numCoc, LBL("Số người:", 145, 105, 80), numSoNguoi,

                LBL("Khách hàng trong hệ thống:", 15, 160, 200), dgvKhach,
                LBL("Danh sách phòng khả dụng:", 445, 160, 200), dgvPhong,
                LBL("Phòng chọn đặt:", 15, 330, 200), dgvChon,
                LBL("Danh sách phiếu đặt phòng:", 445, 330, 200), dgvPhieu,

                btnThemPhong, btnBoPhong, btnLapPhieu,

                LBL("Phiếu chọn:", 445, 475, 100), txtPhieuChon, LBL("Phòng:", 550, 475, 80), txtNguoiPhong, LBL("Họ tên người ở:", 635, 475, 120), txtNguoiTen,
                LBL("CMND người ở:", 15, 525, 110), txtNguoiCMND, LBL("Quốc tịch:", 130, 525, 110), txtNguoiQT,
                btnThemNguoi, btnNhanPhong, btnNoShow, btnDong,

                LBL("Chi tiết đặt phòng:", 15, 560, 200), dgvCT,
                LBL("Người lưu trú cùng:", 445, 560, 200), dgvNguoi
            });

            btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            this.Load += new System.EventHandler(this.Frm_Load);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 705);
            this.Name = "FrmDatPhong"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt phòng & Nhận phòng";
        }
    }
}