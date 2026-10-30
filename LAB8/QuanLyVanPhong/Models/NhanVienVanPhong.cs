namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.NhanVienVanPhong.</summary>
    public sealed class NhanVienVanPhong
    {
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public int MaVP { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string Anh { get; set; }
        public string MaTheXe { get; set; }
        public string BienSoXe { get; set; }
        public string LoaiXe { get; set; }
    }
}
