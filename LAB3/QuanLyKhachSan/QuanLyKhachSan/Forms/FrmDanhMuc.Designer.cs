namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabKhu, tabNV, tabLoaiTN, tabDV, tabQD;
        private System.Windows.Forms.TextBox txtKhuMa, txtKhuTen;
        private System.Windows.Forms.TextBox txtNVMa, txtNVTen, txtNVVaiTro, txtNVSDT;
        private System.Windows.Forms.TextBox txtLoaiMa, txtLoaiTen;
        private System.Windows.Forms.TextBox txtDVMa, txtDVTen, txtDVDVT;
        private System.Windows.Forms.TextBox txtQDMa, txtQDMucDo;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.NumericUpDown numDVGia, numQDTien;
        private System.Windows.Forms.DataGridView dgvKhu, dgvNV, dgvLoaiTN, dgvDV, dgvQD;
        private System.Windows.Forms.Button btnThemKhu, btnThemNV, btnThemLoaiTN, btnThemDV, btnThemQD, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose(); base.Dispose(disposing);
        }

        private System.Windows.Forms.Label LBL(string text, int x, int y, int w)
        {
            var l = new System.Windows.Forms.Label(); l.Text = text; l.Location = new System.Drawing.Point(x, y); l.Size = new System.Drawing.Size(w, 18); return l;
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
            var b = new System.Windows.Forms.Button(); b.Name = name; b.Text = text; b.Location = new System.Drawing.Point(x, y); b.Size = new System.Drawing.Size(100, 28); return b;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabKhu = new System.Windows.Forms.TabPage();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.tabDV = new System.Windows.Forms.TabPage();
            this.tabQD = new System.Windows.Forms.TabPage();

            // Tab 1: Khu vuc
            this.txtKhuMa = TB("txtKhuMa", 15, 30, 150);
            this.txtKhuTen = TB("txtKhuTen", 180, 30, 250);
            this.btnThemKhu = BT("btnThemKhu", "Thêm", 440, 28);
            this.dgvKhu = DG("dgvKhu", 15, 70, 780, 380);
            this.tabKhu.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Mã khu:", 15, 10, 150), txtKhuMa, LBL("Tên khu vực:", 180, 10, 250), txtKhuTen, btnThemKhu, dgvKhu
            });

            // Tab 2: Nhan vien
            this.txtNVMa = TB("txtNVMa", 15, 30, 120);
            this.txtNVTen = TB("txtNVTen", 145, 30, 180);
            this.txtNVVaiTro = TB("txtNVVaiTro", 335, 30, 150);
            this.txtNVSDT = TB("txtNVSDT", 495, 30, 140);
            this.btnThemNV = BT("btnThemNV", "Thêm", 645, 28);
            this.dgvNV = DG("dgvNV", 15, 70, 780, 380);
            this.tabNV.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Mã NV:", 15, 10, 120), txtNVMa, LBL("Họ tên:", 145, 10, 180), txtNVTen,
                LBL("Vai trò:", 335, 10, 150), txtNVVaiTro, LBL("Số ĐT:", 495, 10, 140), txtNVSDT, btnThemNV, dgvNV
            });

            // Tab 3: Loai tien nghi
            this.txtLoaiMa = TB("txtLoaiMa", 15, 30, 150);
            this.txtLoaiTen = TB("txtLoaiTen", 180, 30, 250);
            this.btnThemLoaiTN = BT("btnThemLoaiTN", "Thêm", 440, 28);
            this.dgvLoaiTN = DG("dgvLoaiTN", 15, 70, 780, 380);
            this.tabLoaiTN.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Mã loại:", 15, 10, 150), txtLoaiMa, LBL("Tên loại tiện nghi:", 180, 10, 250), txtLoaiTen, btnThemLoaiTN, dgvLoaiTN
            });

            // Tab 4: Dich vu
            this.txtDVMa = TB("txtDVMa", 15, 30, 120);
            this.txtDVTen = TB("txtDVTen", 145, 30, 180);
            this.txtDVDVT = TB("txtDVDVT", 335, 30, 120);
            this.numDVGia = new System.Windows.Forms.NumericUpDown(); this.numDVGia.Name = "numDVGia"; this.numDVGia.Location = new System.Drawing.Point(465, 30); this.numDVGia.Size = new System.Drawing.Size(140, 25); this.numDVGia.Maximum = 1000000000;
            this.btnThemDV = BT("btnThemDV", "Thêm", 615, 28);
            this.dgvDV = DG("dgvDV", 15, 70, 780, 380);
            this.tabDV.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Mã DV:", 15, 10, 120), txtDVMa, LBL("Tên dịch vụ:", 145, 10, 180), txtDVTen,
                LBL("Đơn vị tính:", 335, 10, 120), txtDVDVT, LBL("Đơn giá:", 465, 10, 140), numDVGia, btnThemDV, dgvDV
            });

            // Tab 5: Quy dinh den bu
            this.txtQDMa = TB("txtQDMa", 15, 30, 110);
            this.cboQDLoai = new System.Windows.Forms.ComboBox(); this.cboQDLoai.Name = "cboQDLoai"; this.cboQDLoai.Location = new System.Drawing.Point(135, 30); this.cboQDLoai.Size = new System.Drawing.Size(160, 25); this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQDMucDo = TB("txtQDMucDo", 305, 30, 160);
            this.numQDTien = new System.Windows.Forms.NumericUpDown(); this.numQDTien.Name = "numQDTien"; this.numQDTien.Location = new System.Drawing.Point(475, 30); this.numQDTien.Size = new System.Drawing.Size(140, 25); this.numQDTien.Maximum = 1000000000;
            this.btnThemQD = BT("btnThemQD", "Thêm", 625, 28);
            this.dgvQD = DG("dgvQD", 15, 70, 780, 380);
            this.tabQD.Controls.AddRange(new System.Windows.Forms.Control[] {
                LBL("Mã QĐ:", 15, 10, 110), txtQDMa, LBL("Loại tiện nghi:", 135, 10, 160), cboQDLoai,
                LBL("Mức độ hỏng:", 305, 10, 160), txtQDMucDo, LBL("Tiền đền bù:", 475, 10, 140), numQDTien, btnThemQD, dgvQD
            });

            // Tabs setup
            this.tabKhu.Text = "Khu vực"; this.tabNV.Text = "Nhân viên"; this.tabLoaiTN.Text = "Loại tiện nghi"; this.tabDV.Text = "Dịch vụ"; this.tabQD.Text = "Quy định đền bù";
            this.tabs.TabPages.AddRange(new System.Windows.Forms.TabPage[] { tabKhu, tabNV, tabLoaiTN, tabDV, tabQD });
            this.tabs.Location = new System.Drawing.Point(10, 10); this.tabs.Size = new System.Drawing.Size(820, 485);

            this.btnDong = BT("btnDong", "Đóng", 730, 505);

            this.Controls.Add(this.tabs); this.Controls.Add(this.btnDong);
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 545);
            this.Name = "FrmDanhMuc"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục hệ thống";
        }
    }
}