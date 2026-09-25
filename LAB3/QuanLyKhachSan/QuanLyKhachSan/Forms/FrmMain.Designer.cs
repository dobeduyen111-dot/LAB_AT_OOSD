namespace QuanLyKhachSan.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(560, 45);
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Row 1
            this.btnDanhMuc.Location = new System.Drawing.Point(50, 85);
            this.btnDanhMuc.Size = new System.Drawing.Size(240, 50);
            this.btnDanhMuc.Text = "📋  Danh mục";
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.btnPhong.Location = new System.Drawing.Point(310, 85);
            this.btnPhong.Size = new System.Drawing.Size(240, 50);
            this.btnPhong.Text = "🛏️  Phòng - Tiện nghi";
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Row 2
            this.btnDatPhong.Location = new System.Drawing.Point(50, 150);
            this.btnDatPhong.Size = new System.Drawing.Size(240, 50);
            this.btnDatPhong.Text = "🔑  Đặt / Nhận phòng";
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.btnDichVu.Location = new System.Drawing.Point(310, 150);
            this.btnDichVu.Size = new System.Drawing.Size(240, 50);
            this.btnDichVu.Text = "⚙️  Sử dụng dịch vụ";
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Row 3
            this.btnTraPhong.Location = new System.Drawing.Point(50, 215);
            this.btnTraPhong.Size = new System.Drawing.Size(240, 50);
            this.btnTraPhong.Text = "💳  Trả phòng - Thanh toán";
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.btnThongKe.Location = new System.Drawing.Point(310, 215);
            this.btnThongKe.Size = new System.Drawing.Size(240, 50);
            this.btnThongKe.Text = "📊  Thống kê";
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Button Exit
            this.btnThoat.Location = new System.Drawing.Point(230, 285);
            this.btnThoat.Size = new System.Drawing.Size(140, 40);
            this.btnThoat.Text = "🚪  Thoát";
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            // Events
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.btnDanhMuc, this.btnPhong, this.btnDatPhong,
                this.btnDichVu, this.btnTraPhong, this.btnThongKe, this.btnThoat
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.ResumeLayout(false);
        }
    }
}