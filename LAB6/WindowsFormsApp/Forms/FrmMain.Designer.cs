namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnDanhMuc, btnBenhNhan, btnKhamBenh, btnLapToa, btnKiemTraKetNoi;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDanhMuc = MakeButton("btnDanhMuc", "Quản lý danh mục", 30, 35, btnDanhMuc_Click);
            btnBenhNhan = MakeButton("btnBenhNhan", "Đăng ký bệnh nhân", 220, 35, btnBenhNhan_Click);
            btnKhamBenh = MakeButton("btnKhamBenh", "Khám bệnh", 30, 95, btnKhamBenh_Click);
            btnLapToa = MakeButton("btnLapToa", "Lập toa thuốc", 220, 95, btnLapToa_Click);
            btnKiemTraKetNoi = MakeButton("btnKiemTraKetNoi", "Kiểm tra kết nối SQL", 30, 155, btnKiemTraKetNoi_Click);
            Controls.AddRange(new System.Windows.Forms.Control[] { btnDanhMuc, btnBenhNhan, btnKhamBenh, btnLapToa, btnKiemTraKetNoi });
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; ClientSize = new System.Drawing.Size(470, 230);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; Text = "Quản lý hồ sơ bệnh án";
        }
        private System.Windows.Forms.Button MakeButton(string name, string text, int x, int y, System.EventHandler click)
        { var b = new System.Windows.Forms.Button { Name = name, Text = text, Location = new System.Drawing.Point(x, y), Size = new System.Drawing.Size(160, 35) }; b.Click += click; return b; }
    }
}
