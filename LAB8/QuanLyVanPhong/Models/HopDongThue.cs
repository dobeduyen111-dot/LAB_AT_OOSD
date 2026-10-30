using System;

namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.HopDongThue.</summary>
    public sealed class HopDongThue
    {
        public int MaHD { get; set; }
        public string SoHD { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayKy { get; set; }
        public DateTime NgayBatDau { get; set; }
        public int SoThang { get; set; }
        public string NoiDung { get; set; }
        public string TrangThai { get; set; }
    }
}
