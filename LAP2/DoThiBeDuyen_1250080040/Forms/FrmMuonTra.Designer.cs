namespace QuanLyThuVien.Forms
{
    partial class FrmMuonTra
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cboDocGia;
        private System.Windows.Forms.ComboBox cboDocGiaTra;
        private System.Windows.Forms.ComboBox cboNhanVienMuon;
        private System.Windows.Forms.ComboBox cboNhanVienTra;
        private System.Windows.Forms.ComboBox cboTinhTrang;

        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.DateTimePicker dtHenTra;
        private System.Windows.Forms.DateTimePicker dtNgayTra;

        private System.Windows.Forms.DataGridView dgvSachCon;
        private System.Windows.Forms.DataGridView dgvSachChon;
        private System.Windows.Forms.DataGridView dgvDangMuon;

        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.NumericUpDown numPhiPhat;

        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnBoSach;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Button btnTaiSachMuon;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.cboDocGia = new System.Windows.Forms.ComboBox();
            this.cboDocGiaTra = new System.Windows.Forms.ComboBox();
            this.cboNhanVienMuon = new System.Windows.Forms.ComboBox();
            this.cboNhanVienTra = new System.Windows.Forms.ComboBox();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();

            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtHenTra = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();

            this.dgvSachCon = new System.Windows.Forms.DataGridView();
            this.dgvSachChon = new System.Windows.Forms.DataGridView();
            this.dgvDangMuon = new System.Windows.Forms.DataGridView();

            this.lblTrangThai = new System.Windows.Forms.Label();

            this.numPhiPhat = new System.Windows.Forms.NumericUpDown();

            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnBoSach = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnTaiSachMuon = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).BeginInit();

            this.SuspendLayout();

            // =====================================================
            // cboDocGia
            // =====================================================

            this.cboDocGia.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboDocGia.FormattingEnabled = true;
            this.cboDocGia.Location = new System.Drawing.Point(120, 20);
            this.cboDocGia.Name = "cboDocGia";
            this.cboDocGia.Size = new System.Drawing.Size(230, 24);
            this.cboDocGia.TabIndex = 0;

            // =====================================================
            // cboNhanVienMuon
            // =====================================================

            this.cboNhanVienMuon.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboNhanVienMuon.FormattingEnabled = true;
            this.cboNhanVienMuon.Location = new System.Drawing.Point(500, 20);
            this.cboNhanVienMuon.Name = "cboNhanVienMuon";
            this.cboNhanVienMuon.Size = new System.Drawing.Size(180, 24);
            this.cboNhanVienMuon.TabIndex = 1;

            // =====================================================
            // dtNgayMuon
            // =====================================================

            this.dtNgayMuon.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtNgayMuon.Location = new System.Drawing.Point(120, 55);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(180, 22);
            this.dtNgayMuon.TabIndex = 2;

            // =====================================================
            // dtHenTra
            // =====================================================

            this.dtHenTra.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtHenTra.Location = new System.Drawing.Point(500, 55);
            this.dtHenTra.Name = "dtHenTra";
            this.dtHenTra.Size = new System.Drawing.Size(180, 22);
            this.dtHenTra.TabIndex = 3;

            // =====================================================
            // btnKiemTra
            // =====================================================

            this.btnKiemTra.Location = new System.Drawing.Point(720, 20);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(120, 35);
            this.btnKiemTra.TabIndex = 4;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click +=
                new System.EventHandler(this.btnKiemTra_Click);

            // =====================================================
            // btnLapPhieu
            // =====================================================

            this.btnLapPhieu.Location = new System.Drawing.Point(850, 20);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(120, 35);
            this.btnLapPhieu.TabIndex = 5;
            this.btnLapPhieu.Text = "Lập phiếu mượn";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click +=
                new System.EventHandler(this.btnLapPhieu_Click);

            // =====================================================
            // lblTrangThai
            // =====================================================

            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(120, 90);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(70, 16);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trạng thái";

            // =====================================================
            // dgvSachCon
            // =====================================================

            this.dgvSachCon.Location = new System.Drawing.Point(12, 130);
            this.dgvSachCon.Name = "dgvSachCon";
            this.dgvSachCon.Size = new System.Drawing.Size(470, 230);
            this.dgvSachCon.TabIndex = 7;

            this.dgvSachCon.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSachCon.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvSachCon.MultiSelect = false;
            this.dgvSachCon.ReadOnly = true;
            this.dgvSachCon.AllowUserToAddRows = false;

            // =====================================================
            // dgvSachChon
            // =====================================================

            this.dgvSachChon.Location = new System.Drawing.Point(500, 130);
            this.dgvSachChon.Name = "dgvSachChon";
            this.dgvSachChon.Size = new System.Drawing.Size(470, 230);
            this.dgvSachChon.TabIndex = 8;

            this.dgvSachChon.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSachChon.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvSachChon.MultiSelect = false;
            this.dgvSachChon.ReadOnly = true;
            this.dgvSachChon.AllowUserToAddRows = false;

            // =====================================================
            // btnThemSach
            // =====================================================

            this.btnThemSach.Location = new System.Drawing.Point(170, 375);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(120, 35);
            this.btnThemSach.TabIndex = 9;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click +=
                new System.EventHandler(this.btnThemSach_Click);

            // =====================================================
            // btnBoSach
            // =====================================================

            this.btnBoSach.Location = new System.Drawing.Point(690, 375);
            this.btnBoSach.Name = "btnBoSach";
            this.btnBoSach.Size = new System.Drawing.Size(120, 35);
            this.btnBoSach.TabIndex = 10;
            this.btnBoSach.Text = "Bỏ sách";
            this.btnBoSach.UseVisualStyleBackColor = true;
            this.btnBoSach.Click +=
                new System.EventHandler(this.btnBoSach_Click);

            // =====================================================
            // cboDocGiaTra
            // =====================================================

            this.cboDocGiaTra.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboDocGiaTra.FormattingEnabled = true;
            this.cboDocGiaTra.Location = new System.Drawing.Point(120, 445);
            this.cboDocGiaTra.Name = "cboDocGiaTra";
            this.cboDocGiaTra.Size = new System.Drawing.Size(230, 24);
            this.cboDocGiaTra.TabIndex = 11;

            this.cboDocGiaTra.SelectedIndexChanged +=
                new System.EventHandler(this.cboDocGiaTra_SelectedIndexChanged);

            // =====================================================
            // cboNhanVienTra
            // =====================================================

            this.cboNhanVienTra.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboNhanVienTra.FormattingEnabled = true;
            this.cboNhanVienTra.Location = new System.Drawing.Point(500, 445);
            this.cboNhanVienTra.Name = "cboNhanVienTra";
            this.cboNhanVienTra.Size = new System.Drawing.Size(180, 24);
            this.cboNhanVienTra.TabIndex = 12;

            // =====================================================
            // dtNgayTra
            // =====================================================

            this.dtNgayTra.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtNgayTra.Location = new System.Drawing.Point(720, 445);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(180, 22);
            this.dtNgayTra.TabIndex = 13;

            // =====================================================
            // cboTinhTrang
            // =====================================================

            this.cboTinhTrang.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(120, 480);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(230, 24);
            this.cboTinhTrang.TabIndex = 14;

            // =====================================================
            // numPhiPhat
            // =====================================================

            this.numPhiPhat.DecimalPlaces = 0;
            this.numPhiPhat.Maximum =
                new decimal(new int[]
                {
                    100000000, 0, 0, 0
                });

            this.numPhiPhat.Location = new System.Drawing.Point(500, 480);
            this.numPhiPhat.Name = "numPhiPhat";
            this.numPhiPhat.Size = new System.Drawing.Size(180, 22);
            this.numPhiPhat.TabIndex = 15;

            // =====================================================
            // btnTaiSachMuon
            // =====================================================

            this.btnTaiSachMuon.Location = new System.Drawing.Point(720, 480);
            this.btnTaiSachMuon.Name = "btnTaiSachMuon";
            this.btnTaiSachMuon.Size = new System.Drawing.Size(120, 35);
            this.btnTaiSachMuon.TabIndex = 16;
            this.btnTaiSachMuon.Text = "Tải sách mượn";
            this.btnTaiSachMuon.UseVisualStyleBackColor = true;
            this.btnTaiSachMuon.Click +=
                new System.EventHandler(this.btnTaiSachMuon_Click);

            // =====================================================
            // dgvDangMuon
            // =====================================================

            this.dgvDangMuon.Location = new System.Drawing.Point(12, 535);
            this.dgvDangMuon.Name = "dgvDangMuon";
            this.dgvDangMuon.Size = new System.Drawing.Size(958, 220);
            this.dgvDangMuon.TabIndex = 17;

            this.dgvDangMuon.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvDangMuon.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvDangMuon.MultiSelect = false;
            this.dgvDangMuon.ReadOnly = true;
            this.dgvDangMuon.AllowUserToAddRows = false;

            // =====================================================
            // btnTraSach
            // =====================================================

            this.btnTraSach.Location = new System.Drawing.Point(720, 770);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(120, 35);
            this.btnTraSach.TabIndex = 18;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click +=
                new System.EventHandler(this.btnTraSach_Click);

            // =====================================================
            // btnDong
            // =====================================================

            this.btnDong.Location = new System.Drawing.Point(850, 770);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click +=
                new System.EventHandler(this.btnDong_Click);

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1000, 830);

            this.Controls.Add(this.cboDocGia);
            this.Controls.Add(this.cboDocGiaTra);

            this.Controls.Add(this.cboNhanVienMuon);
            this.Controls.Add(this.cboNhanVienTra);

            this.Controls.Add(this.cboTinhTrang);

            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.dtHenTra);
            this.Controls.Add(this.dtNgayTra);

            this.Controls.Add(this.dgvSachCon);
            this.Controls.Add(this.dgvSachChon);
            this.Controls.Add(this.dgvDangMuon);

            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.numPhiPhat);

            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnBoSach);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.btnTaiSachMuon);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnDong);

            this.Name = "FrmMuonTra";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý mượn trả";

            ((System.ComponentModel.ISupportInitialize)(this.dgvSachCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiPhat)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}