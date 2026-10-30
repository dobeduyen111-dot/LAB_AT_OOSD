namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.VanPhong.</summary>
    public sealed class VanPhong
    {
        public int MaVP { get; set; }
        public int Tang { get; set; }
        public string SoPhong { get; set; }
        public string Huong { get; set; }
        public decimal DienTich { get; set; }
        public decimal DonGiaNiemYet { get; set; }
    }
}
