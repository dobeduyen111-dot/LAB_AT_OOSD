namespace WindowsFormsApp1.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel layoutButtons;
        private System.Windows.Forms.Button btnDanhMuc, btnTuyenDung, btnHopDong, btnQuyetDinh, btnPhanCong, btnChamCong, btnLuong, btnKhenThuong, btnThoat;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new System.Windows.Forms.Label(); layoutButtons = new System.Windows.Forms.TableLayoutPanel();
            btnDanhMuc = Button("btnDanhMuc", "Danh mục", false); btnTuyenDung = Button("btnTuyenDung", "Tuyển dụng - thử việc", true);
            btnHopDong = Button("btnHopDong", "Hợp đồng lao động", true); btnQuyetDinh = Button("btnQuyetDinh", "Quyết định chức vụ - lương", false);
            btnPhanCong = Button("btnPhanCong", "Kế hoạch phân công", false); btnChamCong = Button("btnChamCong", "Chấm công - phụ trội", false);
            btnLuong = Button("btnLuong", "Lương - bảo hiểm", false); btnKhenThuong = Button("btnKhenThuong", "Khen thưởng - kỷ luật", true); btnThoat = Button("btnThoat", "Thoát", true);
            SuspendLayout();
            Text = "Hệ thống quản lý nhân sự"; StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; ClientSize = new System.Drawing.Size(1000, 650); BackColor = System.Drawing.Color.White; MinimumSize = new System.Drawing.Size(850, 560);
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ"; lblTitle.Dock = System.Windows.Forms.DockStyle.Top; lblTitle.Height = 100; lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold); lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 79, 130); Controls.Add(lblTitle);
            layoutButtons.Dock = System.Windows.Forms.DockStyle.Top; layoutButtons.Height = 330; layoutButtons.Padding = new System.Windows.Forms.Padding(80, 20, 80, 10); layoutButtons.ColumnCount = 2; layoutButtons.RowCount = 4; layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50)); layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50)); for (int i = 0; i < 4; i++) layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
            layoutButtons.Controls.Add(btnDanhMuc, 0, 0); layoutButtons.Controls.Add(btnTuyenDung, 1, 0); layoutButtons.Controls.Add(btnHopDong, 0, 1); layoutButtons.Controls.Add(btnQuyetDinh, 1, 1); layoutButtons.Controls.Add(btnPhanCong, 0, 2); layoutButtons.Controls.Add(btnChamCong, 1, 2); layoutButtons.Controls.Add(btnLuong, 0, 3); layoutButtons.Controls.Add(btnKhenThuong, 1, 3); Controls.Add(layoutButtons);
            btnTuyenDung.Click += btnTuyenDung_Click; btnHopDong.Click += btnHopDong_Click; btnKhenThuong.Click += btnKhenThuong_Click; btnThoat.Click += btnThoat_Click;
            btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top; btnThoat.Width = 150; btnThoat.Height = 44; btnThoat.Location = new System.Drawing.Point(425, 470); Controls.Add(btnThoat); ResumeLayout(false);
        }
        private System.Windows.Forms.Button Button(string name, string text, bool enabled) { var b = new System.Windows.Forms.Button(); b.Name = name; b.Text = text; b.Enabled = enabled; b.Dock = System.Windows.Forms.DockStyle.Fill; b.Margin = new System.Windows.Forms.Padding(8); b.Font = new System.Drawing.Font("Segoe UI", 12F); b.BackColor = System.Drawing.Color.Gainsboro; b.FlatStyle = System.Windows.Forms.FlatStyle.Flat; return b; }
    }
}
