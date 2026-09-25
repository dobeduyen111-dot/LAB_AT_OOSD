namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboLuot, cboDV, cboNV;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Button btnGhi, btnDong;

        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private System.Windows.Forms.Label LBL(string text, int x, int y, int w)
        {
            var l = new System.Windows.Forms.Label(); l.Text = text; l.Location = new System.Drawing.Point(x, y); l.Size = new System.Drawing.Size(w, 18); return l;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            cboLuot = new System.Windows.Forms.ComboBox(); cboLuot.Name = "cboLuot"; cboLuot.Location = new System.Drawing.Point(15, 30); cboLuot.Size = new System.Drawing.Size(180, 25); cboLuot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtPhong = new System.Windows.Forms.TextBox(); txtPhong.Name = "txtPhong"; txtPhong.Location = new System.Drawing.Point(205, 30); txtPhong.Size = new System.Drawing.Size(100, 25); txtPhong.ReadOnly = true;
            cboDV = new System.Windows.Forms.ComboBox(); cboDV.Name = "cboDV"; cboDV.Location = new System.Drawing.Point(315, 30); cboDV.Size = new System.Drawing.Size(170, 25); cboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dtNgay = new System.Windows.Forms.DateTimePicker(); dtNgay.Name = "dtNgay"; dtNgay.Location = new System.Drawing.Point(495, 30); dtNgay.Size = new System.Drawing.Size(120, 25); dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            cboNV = new System.Windows.Forms.ComboBox(); cboNV.Name = "cboNV"; cboNV.Location = new System.Drawing.Point(625, 30); cboNV.Size = new System.Drawing.Size(150, 25); cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            numSL = new System.Windows.Forms.NumericUpDown(); numSL.Name = "numSL"; numSL.Location = new System.Drawing.Point(15, 80); numSL.Size = new System.Drawing.Size(100, 25); numSL.Minimum = 1; numSL.Maximum = 1000; numSL.Value = 1;
            btnGhi = new System.Windows.Forms.Button(); btnGhi.Name = "btnGhi"; btnGhi.Text = "Ghi dịch vụ"; btnGhi.Location = new System.Drawing.Point(130, 78); btnGhi.Size = new System.Drawing.Size(110, 28);
            btnDong = new System.Windows.Forms.Button(); btnDong.Name = "btnDong"; btnDong.Text = "Đóng"; btnDong.Location = new System.Drawing.Point(685, 78); btnDong.Size = new System.Drawing.Size(90, 28);

            dgvLichSu = new System.Windows.Forms.DataGridView(); dgvLichSu.Name = "dgvLichSu"; dgvLichSu.Location = new System.Drawing.Point(15, 130); dgvLichSu.Size = new System.Drawing.Size(760, 320); dgvLichSu.ReadOnly = true; dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.AddRange(new System.Windows.Forms.Control[]{
                LBL("Phiếu / Lượt ở:", 15, 10, 180), cboLuot,
                LBL("Phòng:", 205, 10, 100), txtPhong,
                LBL("Dịch vụ:", 315, 10, 170), cboDV,
                LBL("Ngày dùng:", 495, 10, 120), dtNgay,
                LBL("Nhân viên:", 625, 10, 150), cboNV,
                LBL("Số lượng:", 15, 60, 100), numSL, btnGhi, btnDong,
                LBL("Lịch sử sử dụng dịch vụ:", 15, 110, 200), dgvLichSu
            });

            cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);
            btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            this.Load += new System.EventHandler(this.Frm_Load);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 465);
            this.Name = "FrmDichVu"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi nhận dịch vụ";
        }
    }
}