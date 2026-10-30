using System;

namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.PhieuGiaHan.</summary>
    public sealed class PhieuGiaHan
    {
        public int MaGiaHan { get; set; }
        public int MaCTThue { get; set; }
        public DateTime NgayLap { get; set; }
        public int SoThangGiaHan { get; set; }
        public DateTime NgayKetThucCu { get; set; }
        public DateTime NgayKetThucMoi { get; set; }
    }
}
