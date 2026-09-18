namespace QuanLyThuVien.Forms
{
    partial class FrmSach
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvSach;

        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;

        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.NumericUpDown numSoLuong;

        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboNXB;

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

            this.dgvSach = new System.Windows.Forms.DataGridView();

            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();

            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();

            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboNXB = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();

            this.SuspendLayout();

            // =====================================================
            // txtTim
            // =====================================================

            this.txtTim.Location = new System.Drawing.Point(120, 20);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(300, 22);
            this.txtTim.TabIndex = 0;

            // =====================================================
            // txtMa
            // =====================================================

            this.txtMa.Location = new System.Drawing.Point(120, 60);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(180, 22);
            this.txtMa.TabIndex = 1;

            // =====================================================
            // txtTen
            // =====================================================

            this.txtTen.Location = new System.Drawing.Point(120, 95);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(250, 22);
            this.txtTen.TabIndex = 2;

            // =====================================================
            // numNam
            // =====================================================

            this.numNam.Location = new System.Drawing.Point(500, 60);
            this.numNam.Maximum = new decimal(new int[]
            {
                2100, 0, 0, 0
            });

            this.numNam.Minimum = new decimal(new int[]
            {
                1900, 0, 0, 0
            });

            this.numNam.Name = "numNam";
            this.numNam.Size = new System.Drawing.Size(120, 22);
            this.numNam.TabIndex = 3;
            this.numNam.Value = new decimal(new int[]
            {
                2026, 0, 0, 0
            });

            // =====================================================
            // numSoLuong
            // =====================================================

            this.numSoLuong.Location = new System.Drawing.Point(500, 95);
            this.numSoLuong.Maximum = new decimal(new int[]
            {
                100000, 0, 0, 0
            });

            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 22);
            this.numSoLuong.TabIndex = 4;

            // =====================================================
            // cboTheLoai
            // =====================================================

            this.cboTheLoai.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(720, 60);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(200, 24);
            this.cboTheLoai.TabIndex = 5;

            // =====================================================
            // cboNXB
            // =====================================================

            this.cboNXB.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(720, 95);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(200, 24);
            this.cboNXB.TabIndex = 6;

            // =====================================================
            // btnThem
            // =====================================================

            this.btnThem.Location = new System.Drawing.Point(120, 140);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;

            // =====================================================
            // btnCapNhat
            // =====================================================

            this.btnCapNhat.Location = new System.Drawing.Point(240, 140);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;

            // =====================================================
            // btnXoa
            // =====================================================

            this.btnXoa.Location = new System.Drawing.Point(360, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;

            // =====================================================
            // btnMoi
            // =====================================================

            this.btnMoi.Location = new System.Drawing.Point(480, 140);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(100, 35);
            this.btnMoi.TabIndex = 10;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;

            // =====================================================
            // dgvSach
            // =====================================================

            this.dgvSach.Location = new System.Drawing.Point(12, 200);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(1050, 350);
            this.dgvSach.TabIndex = 11;

            this.dgvSach.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSach.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvSach.MultiSelect = false;
            this.dgvSach.ReadOnly = true;
            this.dgvSach.AllowUserToAddRows = false;

            // =====================================================
            // btnDong
            // =====================================================

            this.btnDong.Location = new System.Drawing.Point(950, 570);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 12;
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
                new System.Drawing.Size(1080, 630);

            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtTen);

            this.Controls.Add(this.numNam);
            this.Controls.Add(this.numSoLuong);

            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.cboNXB);

            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMoi);

            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnDong);

            this.Name = "FrmSach";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Quản lý sách";

            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}