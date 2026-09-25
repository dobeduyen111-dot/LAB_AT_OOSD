namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtTu, dtDen;
        private System.Windows.Forms.DataGridView dgvTongHop, dgvDV;
        private System.Windows.Forms.Button btnTK, btnDong;

        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private System.Windows.Forms.Label LBL(string text, int x, int y, int w) { var l = new System.Windows.Forms.Label(); l.Text = text; l.Location = new System.Drawing.Point(x, y); l.Size = new System.Drawing.Size(w, 18); return l; }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            dtTu = new System.Windows.Forms.DateTimePicker(); dtTu.Name = "dtTu"; dtTu.Location = new System.Drawing.Point(15, 30); dtTu.Size = new System.Drawing.Size(130, 25); dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtDen = new System.Windows.Forms.DateTimePicker(); dtDen.Name = "dtDen"; dtDen.Location = new System.Drawing.Point(155, 30); dtDen.Size = new System.Drawing.Size(130, 25); dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            btnTK = new System.Windows.Forms.Button(); btnTK.Name = "btnTK"; btnTK.Text = "Thống kê"; btnTK.Location = new System.Drawing.Point(300, 28); btnTK.Size = new System.Drawing.Size(100, 28);
            btnDong = new System.Windows.Forms.Button(); btnDong.Name = "btnDong"; btnDong.Text = "Đóng"; btnDong.Location = new System.Drawing.Point(665, 28); btnDong.Size = new System.Drawing.Size(90, 28);

            dgvTongHop = new System.Windows.Forms.DataGridView(); dgvTongHop.Name = "dgvTongHop"; dgvTongHop.Location = new System.Drawing.Point(15, 85); dgvTongHop.Size = new System.Drawing.Size(740, 140); dgvTongHop.ReadOnly = true; dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDV = new System.Windows.Forms.DataGridView(); dgvDV.Name = "dgvDV"; dgvDV.Location = new System.Drawing.Point(15, 260); dgvDV.Size = new System.Drawing.Size(740, 220); dgvDV.ReadOnly = true; dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.AddRange(new System.Windows.Forms.Control[]{
                LBL("Từ ngày:", 15, 10, 130), dtTu,
                LBL("Đến ngày:", 155, 10, 130), dtDen,
                btnTK, btnDong,
                LBL("Tổng hợp hoạt động & doanh thu:", 15, 65, 250), dgvTongHop,
                LBL("Chi tiết dịch vụ đã sử dụng:", 15, 240, 250), dgvDV
            });

            btnTK.Click += new System.EventHandler(this.btnTK_Click);
            btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 495);
            this.Name = "FrmThongKe"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê hoạt động & Doanh thu";
        }
    }
}