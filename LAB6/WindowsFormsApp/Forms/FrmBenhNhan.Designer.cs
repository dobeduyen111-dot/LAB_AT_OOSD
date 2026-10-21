namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmBenhNhan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaBenhNhan, txtHoTen, txtDiaChi, txtDienThoai, txtMaHoSo, txtTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.NumericUpDown nudNamDongPhi, nudSoTien;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container(); var f = new System.Drawing.Font("Arial", 10F); var h = new System.Drawing.Font("Arial", 16F); var t = new System.Drawing.Font("Arial", 14F);
            Controls.Add(L("QUẢN LÝ HỒ SƠ BỆNH ÁN", 10, 8, 400, 28, h));
            Controls.Add(B("Đăng ký", 12, 48, 150, 38, NavBenhNhan_Click)); Controls.Add(B("Khám bệnh", 320, 48, 150, 38, NavKhamBenh_Click)); Controls.Add(B("Lập toa thuốc", 600, 48, 175, 38, NavLapToa_Click));
            Controls.Add(L("ĐĂNG KÝ BỆNH NHÂN VÀ CẤP HỒ SƠ", 10, 98, 700, 34, t)); Controls.Add(L("THÔNG TIN BỆNH NHÂN", 10, 142, 700, 24, f));
            txtMaBenhNhan = T("txtMaBenhNhan", "BN001", 350, 174, 280); txtHoTen = T("txtHoTen", "Nguyễn Văn A", 350, 210, 280); dtpNgaySinh = new System.Windows.Forms.DateTimePicker { Name="dtpNgaySinh", Location=new System.Drawing.Point(350,246), Size=new System.Drawing.Size(280,28), Format=System.Windows.Forms.DateTimePickerFormat.Short, Font=f, Value=new System.DateTime(2000,1,1) }; txtDiaChi=T("txtDiaChi", "TP. Hồ Chí Minh",350,282,280); txtDienThoai=T("txtDienThoai","0900000000",350,318,280);
            string[] labels={"Mã bệnh nhân","Họ tên","Ngày sinh","Địa chỉ","Điện thoại","Ảnh 3x4"}; for(int i=0;i<labels.Length;i++) Controls.Add(L(labels[i],12,174+i*36,200,28,f)); Controls.AddRange(new System.Windows.Forms.Control[]{txtMaBenhNhan,txtHoTen,dtpNgaySinh,txtDiaChi,txtDienThoai});
            picAnh=new System.Windows.Forms.PictureBox{Name="picAnh",Location=new System.Drawing.Point(350,354),Size=new System.Drawing.Size(90,115),BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle,SizeMode=System.Windows.Forms.PictureBoxSizeMode.Zoom}; Controls.Add(picAnh); Controls.Add(B("Chọn ảnh",455,390,120,34,btnChonAnh_Click));
            Controls.Add(L("PHÍ QUẢN LÝ",10,484,700,24,f)); Controls.Add(L("Năm đóng phí",12,516,200,28,f)); Controls.Add(L("Số tiền",12,552,200,28,f)); nudNamDongPhi=N(2026,350,516,150); nudSoTien=N(500000,350,552,180); Controls.AddRange(new System.Windows.Forms.Control[]{nudNamDongPhi,nudSoTien}); Controls.Add(B("Đăng ký bệnh nhân",12,592,250,40,btnDangKy_Click)); Controls.Add(B("Ghi phí và cấp hồ sơ",350,592,280,40,btnGhiPhi_Click));
            Controls.Add(L("KẾT QUẢ CẤP HỒ SƠ",10,646,700,24,f)); Controls.Add(L("Mã hồ sơ",12,678,200,28,f)); Controls.Add(L("Trạng thái",12,714,200,28,f)); txtMaHoSo=T("txtMaHoSo","HS001",350,678,280); txtTrangThai=T("txtTrangThai","Hoạt động",350,714,280); Controls.AddRange(new System.Windows.Forms.Control[]{txtMaHoSo,txtTrangThai}); Controls.Add(L("DANH SÁCH BỆNH NHÂN",10,758,700,26,t));
            dgvBenhNhan=new System.Windows.Forms.DataGridView{Name="dgvBenhNhan",Location=new System.Drawing.Point(12,792),Size=new System.Drawing.Size(720,130),ReadOnly=true,AllowUserToAddRows=false,AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill,RowHeadersVisible=false}; foreach(var c in new[]{new[]{"MaBN","Mã BN"},new[]{"HoTen","Họ tên"},new[]{"MaHS","Mã hồ sơ"},new[]{"TrangThai","Trạng thái"}}) dgvBenhNhan.Columns.Add(c[0],c[1]); dgvBenhNhan.Rows.Add("BN001","Nguyễn Văn A","HS001","Hoạt động"); dgvBenhNhan.Rows.Add("BN002","Trần Thị B","HS002","Hoạt động"); Controls.Add(dgvBenhNhan);
            AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font; ClientSize=new System.Drawing.Size(820,950); MinimumSize=new System.Drawing.Size(820,700); StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen; Text="Đăng ký bệnh nhân"; BackColor=System.Drawing.Color.White; Font=f; AutoScroll=true;
        }
        private System.Windows.Forms.Label L(string s,int x,int y,int w,int h,System.Drawing.Font f){return new System.Windows.Forms.Label{Text=s,Location=new System.Drawing.Point(x,y),Size=new System.Drawing.Size(w,h),Font=f,BackColor=System.Drawing.Color.White};}
        private System.Windows.Forms.TextBox T(string n,string s,int x,int y,int w){return new System.Windows.Forms.TextBox{Name=n,Text=s,Location=new System.Drawing.Point(x,y),Size=new System.Drawing.Size(w,28),Font=new System.Drawing.Font("Arial",10F),BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle};}
        private System.Windows.Forms.NumericUpDown N(decimal v,int x,int y,int w){return new System.Windows.Forms.NumericUpDown{Location=new System.Drawing.Point(x,y),Size=new System.Drawing.Size(w,28),Minimum=0,Maximum=1000000000,Value=v,ThousandsSeparator=true,Font=new System.Drawing.Font("Arial",10F)};}
        private System.Windows.Forms.Button B(string s,int x,int y,int w,int h,System.EventHandler e){var b=new System.Windows.Forms.Button{Text=s,Location=new System.Drawing.Point(x,y),Size=new System.Drawing.Size(w,h),Font=new System.Drawing.Font("Arial",10F),FlatStyle=System.Windows.Forms.FlatStyle.Flat,BackColor=System.Drawing.Color.White};b.Click+=e;return b;}
    }
}
