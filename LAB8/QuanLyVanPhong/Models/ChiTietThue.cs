using System;

namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.ChiTietThue.</summary>
    public sealed class ChiTietThue
    {
        public int MaCTThue { get; set; }
        public int MaHD { get; set; }
        public int MaVP { get; set; }
        public decimal DonGiaThang { get; set; }
        public DateTime NgayKetThucHieuLuc { get; set; }
    }
}
