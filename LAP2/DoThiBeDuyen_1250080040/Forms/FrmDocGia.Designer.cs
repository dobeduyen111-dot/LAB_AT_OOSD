namespace QuanLyThuVien.Forms
{
    partial class FrmDocGia
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvDocGia;

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAnh;

        private System.Windows.Forms.ComboBox cboPhai;

        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private System.Windows.Forms.DateTimePicker dtHan;

        private System.Windows.Forms.CheckBox chkLePhi;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
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

            this.dgvDocGia = new System.Windows.Forms.DataGridView();

            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();

            this.cboPhai = new System.Windows.Forms.ComboBox();

            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.dtHan = new System.Windows.Forms.DateTimePicker();

            this.chkLePhi = new System.Windows.Forms.CheckBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();

            this.SuspendLayout();

            // =====================================================
            // dgvDocGia
            // =====================================================

            this.dgvDocGia.Location = new System.Drawing.Point(12, 270);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(1050, 300);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.AllowUserToAddRows = false;

            // =====================================================
            // txtMa
            // =====================================================

            this.txtMa.Location = new System.Drawing.Point(120, 20);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(180, 22);
            this.txtMa.TabIndex = 1;

            // =====================================================
            // txtHo
            // =====================================================

            this.txtHo.Location = new System.Drawing.Point(120, 55);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(180, 22);
            this.txtHo.TabIndex = 2;

            // =====================================================
            // txtTen
            // =====================================================

            this.txtTen.Location = new System.Drawing.Point(120, 90);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(180, 22);
            this.txtTen.TabIndex = 3;

            // =====================================================
            // dtNgaySinh
            // =====================================================

            this.dtNgaySinh.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(120, 125);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(180, 22);
            this.dtNgaySinh.TabIndex = 4;

            // =====================================================
            // cboPhai
            // =====================================================

            this.cboPhai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Location = new System.Drawing.Point(420, 20);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(180, 24);
            this.cboPhai.TabIndex = 5;

            // =====================================================
            // txtSDT
            // =====================================================

            this.txtSDT.Location = new System.Drawing.Point(420, 55);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 22);
            this.txtSDT.TabIndex = 6;

            // =====================================================
            // txtDiaChi
            // =====================================================

            this.txtDiaChi.Location = new System.Drawing.Point(420, 90);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 22);
            this.txtDiaChi.TabIndex = 7;

            // =====================================================
            // txtEmail
            // =====================================================

            this.txtEmail.Location = new System.Drawing.Point(420, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 8;

            // =====================================================
            // txtAnh
            // =====================================================

            this.txtAnh.Location = new System.Drawing.Point(720, 20);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(200, 22);
            this.txtAnh.TabIndex = 9;

            // =====================================================
            // dtNgayCap
            // =====================================================

            this.dtNgayCap.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayCap.Location = new System.Drawing.Point(720, 55);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(200, 22);
            this.dtNgayCap.TabIndex = 10;

            // =====================================================
            // dtHan
            // =====================================================

            this.dtHan.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHan.Location = new System.Drawing.Point(720, 90);
            this.dtHan.Name = "dtHan";
            this.dtHan.Size = new System.Drawing.Size(200, 22);
            this.dtHan.TabIndex = 11;

            // =====================================================
            // chkLePhi
            // =====================================================

            this.chkLePhi.AutoSize = true;
            this.chkLePhi.Location = new System.Drawing.Point(720, 125);
            this.chkLePhi.Name = "chkLePhi";
            this.chkLePhi.Size = new System.Drawing.Size(115, 20);
            this.chkLePhi.TabIndex = 12;
            this.chkLePhi.Text = "Đã đóng lệ phí";
            this.chkLePhi.UseVisualStyleBackColor = true;

            // =====================================================
            // btnThem
            // =====================================================

            this.btnThem.Location = new System.Drawing.Point(120, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;

            // =====================================================
            // btnCapNhat
            // =====================================================

            this.btnCapNhat.Location = new System.Drawing.Point(240, 180);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;

            // =====================================================
            // btnXoa
            // =====================================================

            this.btnXoa.Location = new System.Drawing.Point(360, 180);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;

            // =====================================================
            // btnMoi
            // =====================================================

            this.btnMoi.Location = new System.Drawing.Point(480, 180);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(100, 35);
            this.btnMoi.TabIndex = 16;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;

            // =====================================================
            // btnDong
            // =====================================================

            this.btnDong.Location = new System.Drawing.Point(950, 590);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;

            // =====================================================
            // FORM
            // =====================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1080, 640);

            this.Controls.Add(this.dgvDocGia);

            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAnh);

            this.Controls.Add(this.cboPhai);

            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.dtNgayCap);
            this.Controls.Add(this.dtHan);

            this.Controls.Add(this.chkLePhi);

            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnDong);

            this.Name = "FrmDocGia";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý độc giả";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}