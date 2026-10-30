namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.DichVuSuDung.</summary>
    public sealed class DichVuSuDung
    {
        public int MaSD { get; set; }
        public int MaCTThue { get; set; }
        public int? MaKhoan { get; set; }
        public string TenDichVu { get; set; }
        public string DonViTinh { get; set; }
        public byte Thang { get; set; }
        public short Nam { get; set; }
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get { return SoLuong * DonGia; } }
    }
}
