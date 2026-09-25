namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPhong, tabTN, tabLD;
        private System.Windows.Forms.TextBox txtPhong, txtMaTN, txtTinhTrang, txtSoLD, txtTTLD, txtGhiChu;
        private System.Windows.Forms.ComboBox cboKhu, cboLoai, cboTN, cboPhong, cboNV;
        private System.Windows.Forms.NumericUpDown numMax, numGia, numSTT;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvLD;
        private System.Windows.Forms.Button btnThemPhong, btnThemTN, btnLapDat, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose(); base.Dispose(disposing);
        }

        private System.Windows.Forms.Label LBL(string text, int x, int y, int w)
        {
            var l = new System.Windows.Forms.Label(); l.Text = text; l.Location = new System.Drawing.Point(x, y); l.Size = new System.Drawing.Size(w, 18); return l;
        }
        private System.Windows.Forms.ComboBox CB(string name, int x, int y, int w)
        {
            var c = new System.Windows.Forms.ComboBox(); c.Name = name; c.Location = new System.Drawing.Point(x, y); c.Size = new System.Drawing.Size(w, 25); c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; return c;
        }
        private System.Windows.Forms.TextBox TB(string name, int x, int y, int w)
        {
            var t = new System.Windows.Forms.TextBox(); t.Name = name; t.Location = new System.Drawing.Point(x, y); t.Size = new System.Drawing.Size(w, 25); return t;
        }
        private System.Windows.Forms.DataGridView DG(string name, int x, int y, int w, int h)
        {
            var d = new System.Windows.Forms.DataGridView(); d.Name = name; d.Location = new System.Drawing.Point(x, y); d.Size = new System.Drawing.Size(w, h);
            d.ReadOnly = true; d.MultiSelect = false; d.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; return d;
        }
        private System.Windows.Forms.Button BT(string name, string text, int x, int y)
        {
            var b = new System.Windows.Forms.Button(); b.Name = name; b.Text = text; b.Location = new System.Drawing.Point(x, y); b.Size = new System.Drawing.Size(110, 28); return b;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.tabTN = new System.Windows.Forms.TabPage();
            this.tabLD = new System.Windows.Forms.TabPage();

            // Tab Phong
            this.txtPhong = TB("txtPhong", 15, 30, 130);
            this.cboKhu = CB("cboKhu", 155, 30, 170);
            this.numMax = new System.Windows.Forms.NumericUpDown(); this.numMax.Name = "numMax"; this.numMax.Location = new System.Drawing.Point(335, 30); this.numMax.Size = new System.Drawing.Size(110, 25); this.numMax.Maximum = 100;
            this.numGia = new System.Windows.Forms.NumericUpDown(); this.numGia.Name = "numGia"; this.numGia.Location = new System.Drawing.Point(455, 30); this.numGia.Size = new System.Drawing.Size(150, 25); this.numGia.Maximum = 1000000000;
            this.btnThemPhong = BT("btnThemPhong", "Thêm phòng", 615, 28);
            this.dgvPhong = DG("dgvPhong", 15, 70, 810, 380);
            this.tabPhong.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Số phòng:", 15, 10, 130), txtPhong, LBL("Khu vực:", 155, 10, 170), cboKhu,
                LBL("Số người tối đa:", 335, 10, 110), numMax, LBL("Đơn giá/ngày:", 455, 10, 150), numGia, btnThemPhong, dgvPhong
            });

            // Tab Tien Nghi
            this.txtMaTN = TB("txtMaTN", 15, 30, 130);
            this.cboLoai = CB("cboLoai", 155, 30, 170);
            this.numSTT = new System.Windows.Forms.NumericUpDown(); this.numSTT.Name = "numSTT"; this.numSTT.Location = new System.Drawing.Point(335, 30); this.numSTT.Size = new System.Drawing.Size(100, 25); this.numSTT.Maximum = 1000;
            this.txtTinhTrang = TB("txtTinhTrang", 445, 30, 160);
            this.btnThemTN = BT("btnThemTN", "Thêm tiện nghi", 615, 28);
            this.dgvTN = DG("dgvTN", 15, 70, 810, 380);
            this.tabTN.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Mã tiện nghi:", 15, 10, 130), txtMaTN, LBL("Loại tiện nghi:", 155, 10, 170), cboLoai,
                LBL("STT:", 335, 10, 100), numSTT, LBL("Tình trạng:", 445, 10, 160), txtTinhTrang, btnThemTN, dgvTN
            });

            // Tab Lap Dat / Luan Chuyen
            this.txtSoLD = TB("txtSoLD", 15, 30, 120);
            this.cboTN = CB("cboTN", 145, 30, 150);
            this.cboPhong = CB("cboPhong", 305, 30, 130);
            this.dtNgay = new System.Windows.Forms.DateTimePicker(); this.dtNgay.Name = "dtNgay"; this.dtNgay.Location = new System.Drawing.Point(445, 30); this.dtNgay.Size = new System.Drawing.Size(130, 25); this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTTLD = TB("txtTTLD", 15, 85, 120);
            this.cboNV = CB("cboNV", 145, 85, 150);
            this.txtGhiChu = TB("txtGhiChu", 305, 85, 270);
            this.btnLapDat = BT("btnLapDat", "Lập phiếu", 590, 83);
            this.dgvLD = DG("dgvLD", 15, 125, 810, 320);
            this.tabLD.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Số LĐ:", 15, 10, 120), txtSoLD, LBL("Tiện nghi:", 145, 10, 150), cboTN,
                LBL("Phòng:", 305, 10, 130), cboPhong, LBL("Ngày lập:", 445, 10, 130), dtNgay,
                LBL("Tình trạng LĐ:", 15, 65, 120), txtTTLD, LBL("Nhân viên:", 145, 65, 150), cboNV,
                LBL("Ghi chú:", 305, 65, 270), txtGhiChu, btnLapDat, dgvLD
            });

            this.tabPhong.Text = "Phòng"; this.tabTN.Text = "Tiện nghi"; this.tabLD.Text = "Lắp đặt / luân chuyển";
            this.tabs.TabPages.AddRange(new System.Windows.Forms.TabPage[] { tabPhong, tabTN, tabLD });
            this.tabs.Location = new System.Drawing.Point(10, 10); this.tabs.Size = new System.Drawing.Size(850, 490);

            this.btnDong = BT("btnDong", "Đóng", 750, 510);

            this.Controls.Add(this.tabs); this.Controls.Add(this.btnDong);
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.Load += new System.EventHandler(this.Frm_Load);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 550);
            this.Name = "FrmPhongTienNghi"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Phòng & Tiện nghi";
        }
    }
}