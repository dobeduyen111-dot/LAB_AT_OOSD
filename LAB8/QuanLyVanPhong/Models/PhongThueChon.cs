namespace QuanLyVanPhong.Models
{
    /// <summary>DTO dùng cho DataGridView lựa chọn phòng; không phải một bảng hoặc Class nghiệp vụ mới.</summary>
    public sealed class PhongThueChon
    {
        public int MaVP { get; set; }
        public int Tang { get; set; }
        public string SoPhong { get; set; }
        public decimal DonGiaThang { get; set; }
    }
}
