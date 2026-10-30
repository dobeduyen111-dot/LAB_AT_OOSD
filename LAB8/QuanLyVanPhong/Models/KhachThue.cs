namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.KhachThue.</summary>
    public sealed class KhachThue
    {
        public int MaKH { get; set; }
        public string TenDonVi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }
}
