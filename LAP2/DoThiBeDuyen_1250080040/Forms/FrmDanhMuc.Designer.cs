namespace QuanLyThuVien.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabTheLoai;
        private System.Windows.Forms.TabPage tabNhaXuatBan;

        // Nhân viên
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.TextBox txtNVHo;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.ComboBox cboNVPhai;
        private System.Windows.Forms.DateTimePicker dtNVNgaySinh;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.Button btnNVCapNhat;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVMoi;

        // Thể loại
        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.TextBox txtTLMa;
        private System.Windows.Forms.TextBox txtTLTen;
        private System.Windows.Forms.Button btnTLThem;
        private System.Windows.Forms.Button btnTLCapNhat;
        private System.Windows.Forms.Button btnTLXoa;
        private System.Windows.Forms.Button btnTLMoi;

        // Nhà xuất bản
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.TextBox txtNXBMa;
        private System.Windows.Forms.TextBox txtNXBDiaChi;
        private System.Windows.Forms.TextBox txtNXBSDT;
        private System.Windows.Forms.Button btnNXBThem;
        private System.Windows.Forms.Button btnNXBCapNhat;
        private System.Windows.Forms.Button btnNXBXoa;
        private System.Windows.Forms.Button btnNXBMoi;

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

            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabTheLoai = new System.Windows.Forms.TabPage();
            this.tabNhaXuatBan = new System.Windows.Forms.TabPage();

            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.txtNVHo = new System.Windows.Forms.TextBox();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.cboNVPhai = new System.Windows.Forms.ComboBox();
            this.dtNVNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.btnNVCapNhat = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVMoi = new System.Windows.Forms.Button();

            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.txtTLMa = new System.Windows.Forms.TextBox();
            this.txtTLTen = new System.Windows.Forms.TextBox();
            this.btnTLThem = new System.Windows.Forms.Button();
            this.btnTLCapNhat = new System.Windows.Forms.Button();
            this.btnTLXoa = new System.Windows.Forms.Button();
            this.btnTLMoi = new System.Windows.Forms.Button();

            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.txtNXBMa = new System.Windows.Forms.TextBox();
            this.txtNXBDiaChi = new System.Windows.Forms.TextBox();
            this.txtNXBSDT = new System.Windows.Forms.TextBox();
            this.btnNXBThem = new System.Windows.Forms.Button();
            this.btnNXBCapNhat = new System.Windows.Forms.Button();
            this.btnNXBXoa = new System.Windows.Forms.Button();
            this.btnNXBMoi = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabDanhMuc.SuspendLayout();
            this.tabNhanVien.SuspendLayout();
            this.tabTheLoai.SuspendLayout();
            this.tabNhaXuatBan.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();

            this.SuspendLayout();

            // =====================================================
            // TAB CONTROL
            // =====================================================

            this.tabDanhMuc.Controls.Add(this.tabNhanVien);
            this.tabDanhMuc.Controls.Add(this.tabTheLoai);
            this.tabDanhMuc.Controls.Add(this.tabNhaXuatBan);

            this.tabDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 0;
            this.tabDanhMuc.Size = new System.Drawing.Size(1050, 600);

            // =====================================================
            // TAB NHÂN VIÊN
            // =====================================================

            this.tabNhanVien.Controls.Add(this.dgvNV);

            this.tabNhanVien.Controls.Add(this.txtNVMa);
            this.tabNhanVien.Controls.Add(this.txtNVHo);
            this.tabNhanVien.Controls.Add(this.txtNVTen);
            this.tabNhanVien.Controls.Add(this.cboNVPhai);
            this.tabNhanVien.Controls.Add(this.dtNVNgaySinh);
            this.tabNhanVien.Controls.Add(this.txtNVChucVu);
            this.tabNhanVien.Controls.Add(this.txtNVSDT);

            this.tabNhanVien.Controls.Add(this.btnNVThem);
            this.tabNhanVien.Controls.Add(this.btnNVCapNhat);
            this.tabNhanVien.Controls.Add(this.btnNVXoa);
            this.tabNhanVien.Controls.Add(this.btnNVMoi);

            this.tabNhanVien.Location = new System.Drawing.Point(4, 24);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1042, 572);
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;

            // DataGridView nhân viên
            this.dgvNV.Location = new System.Drawing.Point(10, 170);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(1010, 330);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.SelectionChanged +=
                new System.EventHandler(this.dgvNV_SelectionChanged);

            // Mã nhân viên
            this.txtNVMa.Location = new System.Drawing.Point(100, 20);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(180, 22);

            // Họ
            this.txtNVHo.Location = new System.Drawing.Point(100, 50);
            this.txtNVHo.Name = "txtNVHo";
            this.txtNVHo.Size = new System.Drawing.Size(180, 22);

            // Tên
            this.txtNVTen.Location = new System.Drawing.Point(100, 80);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(180, 22);

            // Phái
            this.cboNVPhai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVPhai.Location = new System.Drawing.Point(400, 20);
            this.cboNVPhai.Name = "cboNVPhai";
            this.cboNVPhai.Size = new System.Drawing.Size(180, 24);

            // Ngày sinh
            this.dtNVNgaySinh.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVNgaySinh.Location = new System.Drawing.Point(400, 50);
            this.dtNVNgaySinh.Name = "dtNVNgaySinh";
            this.dtNVNgaySinh.Size = new System.Drawing.Size(180, 22);

            // Chức vụ
            this.txtNVChucVu.Location = new System.Drawing.Point(400, 80);
            this.txtNVChucVu.Name = "txtNVChucVu";
            this.txtNVChucVu.Size = new System.Drawing.Size(180, 22);

            // Số điện thoại
            this.txtNVSDT.Location = new System.Drawing.Point(700, 20);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(180, 22);

            // Nút thêm
            this.btnNVThem.Location = new System.Drawing.Point(700, 60);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(90, 35);
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.UseVisualStyleBackColor = true;
            this.btnNVThem.Click +=
                new System.EventHandler(this.btnNVThem_Click);

            // Nút cập nhật
            this.btnNVCapNhat.Location = new System.Drawing.Point(800, 60);
            this.btnNVCapNhat.Name = "btnNVCapNhat";
            this.btnNVCapNhat.Size = new System.Drawing.Size(90, 35);
            this.btnNVCapNhat.Text = "Cập nhật";
            this.btnNVCapNhat.UseVisualStyleBackColor = true;
            this.btnNVCapNhat.Click +=
                new System.EventHandler(this.btnNVCapNhat_Click);

            // Nút xóa
            this.btnNVXoa.Location = new System.Drawing.Point(900, 60);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(90, 35);
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.UseVisualStyleBackColor = true;
            this.btnNVXoa.Click +=
                new System.EventHandler(this.btnNVXoa_Click);

            // Nút mới
            this.btnNVMoi.Location = new System.Drawing.Point(700, 105);
            this.btnNVMoi.Name = "btnNVMoi";
            this.btnNVMoi.Size = new System.Drawing.Size(90, 35);
            this.btnNVMoi.Text = "Mới";
            this.btnNVMoi.UseVisualStyleBackColor = true;
            this.btnNVMoi.Click +=
                new System.EventHandler(this.btnNVMoi_Click);

            // =====================================================
            // TAB THỂ LOẠI
            // =====================================================

            this.tabTheLoai.Controls.Add(this.dgvTL);
            this.tabTheLoai.Controls.Add(this.txtTLMa);
            this.tabTheLoai.Controls.Add(this.txtTLTen);
            this.tabTheLoai.Controls.Add(this.btnTLThem);
            this.tabTheLoai.Controls.Add(this.btnTLCapNhat);
            this.tabTheLoai.Controls.Add(this.btnTLXoa);
            this.tabTheLoai.Controls.Add(this.btnTLMoi);

            this.tabTheLoai.Location = new System.Drawing.Point(4, 24);
            this.tabTheLoai.Name = "tabTheLoai";
            this.tabTheLoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheLoai.Size = new System.Drawing.Size(1042, 572);
            this.tabTheLoai.Text = "Thể loại";
            this.tabTheLoai.UseVisualStyleBackColor = true;

            // DataGridView thể loại
            this.dgvTL.Location = new System.Drawing.Point(10, 130);
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.Size = new System.Drawing.Size(1010, 370);
            this.dgvTL.TabIndex = 0;
            this.dgvTL.SelectionChanged +=
                new System.EventHandler(this.dgvTL_SelectionChanged);

            // Mã thể loại
            this.txtTLMa.Location = new System.Drawing.Point(100, 25);
            this.txtTLMa.Name = "txtTLMa";
            this.txtTLMa.Size = new System.Drawing.Size(200, 22);

            // Tên thể loại
            this.txtTLTen.Location = new System.Drawing.Point(100, 60);
            this.txtTLTen.Name = "txtTLTen";
            this.txtTLTen.Size = new System.Drawing.Size(200, 22);

            // Thêm
            this.btnTLThem.Location = new System.Drawing.Point(350, 25);
            this.btnTLThem.Name = "btnTLThem";
            this.btnTLThem.Size = new System.Drawing.Size(90, 35);
            this.btnTLThem.Text = "Thêm";
            this.btnTLThem.UseVisualStyleBackColor = true;
            this.btnTLThem.Click +=
                new System.EventHandler(this.btnTLThem_Click);

            // Cập nhật
            this.btnTLCapNhat.Location = new System.Drawing.Point(450, 25);
            this.btnTLCapNhat.Name = "btnTLCapNhat";
            this.btnTLCapNhat.Size = new System.Drawing.Size(90, 35);
            this.btnTLCapNhat.Text = "Cập nhật";
            this.btnTLCapNhat.UseVisualStyleBackColor = true;
            this.btnTLCapNhat.Click +=
                new System.EventHandler(this.btnTLCapNhat_Click);

            // Xóa
            this.btnTLXoa.Location = new System.Drawing.Point(550, 25);
            this.btnTLXoa.Name = "btnTLXoa";
            this.btnTLXoa.Size = new System.Drawing.Size(90, 35);
            this.btnTLXoa.Text = "Xóa";
            this.btnTLXoa.UseVisualStyleBackColor = true;
            this.btnTLXoa.Click +=
                new System.EventHandler(this.btnTLXoa_Click);

            // Mới
            this.btnTLMoi.Location = new System.Drawing.Point(650, 25);
            this.btnTLMoi.Name = "btnTLMoi";
            this.btnTLMoi.Size = new System.Drawing.Size(90, 35);
            this.btnTLMoi.Text = "Mới";
            this.btnTLMoi.UseVisualStyleBackColor = true;
            this.btnTLMoi.Click +=
                new System.EventHandler(this.btnTLMoi_Click);

            // =====================================================
            // TAB NHÀ XUẤT BẢN
            // =====================================================

            this.tabNhaXuatBan.Controls.Add(this.dgvNXB);
            this.tabNhaXuatBan.Controls.Add(this.txtNXBMa);
            this.tabNhaXuatBan.Controls.Add(this.txtNXBDiaChi);
            this.tabNhaXuatBan.Controls.Add(this.txtNXBSDT);
            this.tabNhaXuatBan.Controls.Add(this.btnNXBThem);
            this.tabNhaXuatBan.Controls.Add(this.btnNXBCapNhat);
            this.tabNhaXuatBan.Controls.Add(this.btnNXBXoa);
            this.tabNhaXuatBan.Controls.Add(this.btnNXBMoi);

            this.tabNhaXuatBan.Location = new System.Drawing.Point(4, 24);
            this.tabNhaXuatBan.Name = "tabNhaXuatBan";
            this.tabNhaXuatBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhaXuatBan.Size = new System.Drawing.Size(1042, 572);
            this.tabNhaXuatBan.Text = "Nhà xuất bản";
            this.tabNhaXuatBan.UseVisualStyleBackColor = true;

            // DataGridView nhà xuất bản
            this.dgvNXB.Location = new System.Drawing.Point(10, 150);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(1010, 350);
            this.dgvNXB.TabIndex = 0;
            this.dgvNXB.SelectionChanged +=
                new System.EventHandler(this.dgvNXB_SelectionChanged);

            // Mã NXB
            this.txtNXBMa.Location = new System.Drawing.Point(100, 25);
            this.txtNXBMa.Name = "txtNXBMa";
            this.txtNXBMa.Size = new System.Drawing.Size(200, 22);

            // Địa chỉ
            this.txtNXBDiaChi.Location = new System.Drawing.Point(100, 60);
            this.txtNXBDiaChi.Name = "txtNXBDiaChi";
            this.txtNXBDiaChi.Size = new System.Drawing.Size(250, 22);

            // Số điện thoại
            this.txtNXBSDT.Location = new System.Drawing.Point(100, 95);
            this.txtNXBSDT.Name = "txtNXBSDT";
            this.txtNXBSDT.Size = new System.Drawing.Size(200, 22);

            // Thêm
            this.btnNXBThem.Location = new System.Drawing.Point(400, 25);
            this.btnNXBThem.Name = "btnNXBThem";
            this.btnNXBThem.Size = new System.Drawing.Size(90, 35);
            this.btnNXBThem.Text = "Thêm";
            this.btnNXBThem.UseVisualStyleBackColor = true;
            this.btnNXBThem.Click +=
                new System.EventHandler(this.btnNXBThem_Click);

            // Cập nhật
            this.btnNXBCapNhat.Location = new System.Drawing.Point(500, 25);
            this.btnNXBCapNhat.Name = "btnNXBCapNhat";
            this.btnNXBCapNhat.Size = new System.Drawing.Size(90, 35);
            this.btnNXBCapNhat.Text = "Cập nhật";
            this.btnNXBCapNhat.UseVisualStyleBackColor = true;
            this.btnNXBCapNhat.Click +=
                new System.EventHandler(this.btnNXBCapNhat_Click);

            // Xóa
            this.btnNXBXoa.Location = new System.Drawing.Point(600, 25);
            this.btnNXBXoa.Name = "btnNXBXoa";
            this.btnNXBXoa.Size = new System.Drawing.Size(90, 35);
            this.btnNXBXoa.Text = "Xóa";
            this.btnNXBXoa.UseVisualStyleBackColor = true;
            this.btnNXBXoa.Click +=
                new System.EventHandler(this.btnNXBXoa_Click);

            // Mới
            this.btnNXBMoi.Location = new System.Drawing.Point(700, 25);
            this.btnNXBMoi.Name = "btnNXBMoi";
            this.btnNXBMoi.Size = new System.Drawing.Size(90, 35);
            this.btnNXBMoi.Text = "Mới";
            this.btnNXBMoi.UseVisualStyleBackColor = true;
            this.btnNXBMoi.Click +=
                new System.EventHandler(this.btnNXBMoi_Click);

            // =====================================================
            // BUTTON ĐÓNG
            // =====================================================

            this.btnDong.Location = new System.Drawing.Point(950, 625);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
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
                new System.Drawing.Size(1080, 680);

            this.Controls.Add(this.tabDanhMuc);
            this.Controls.Add(this.btnDong);

            this.Name = "FrmDanhMuc";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý danh mục";

            this.Load +=
                new System.EventHandler(this.FrmDanhMuc_Load);

            this.tabDanhMuc.ResumeLayout(false);

            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();

            this.tabTheLoai.ResumeLayout(false);
            this.tabTheLoai.PerformLayout();

            this.tabNhaXuatBan.ResumeLayout(false);
            this.tabNhaXuatBan.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();

            this.ResumeLayout(false);
        }
    }
}