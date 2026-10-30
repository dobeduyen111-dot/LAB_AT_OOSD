using System;

namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.KiemTraPhong.</summary>
    public sealed class KiemTraPhong
    {
        public int MaKT { get; set; }
        public int MaVP { get; set; }
        public int? MaCTThue { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public string TinhTrang { get; set; }
        public bool TuYSuaDoi { get; set; }
        public string LyDoPhat { get; set; }
        public decimal SoTienPhat { get; set; }
    }
}
