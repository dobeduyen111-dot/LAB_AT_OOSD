using System;

namespace QuanLyVanPhong.Models
{
    /// <summary>Model nghiệp vụ ánh xạ với bảng dbo.KhoanThanhToan.</summary>
    public sealed class KhoanThanhToan
    {
        public int MaKhoan { get; set; }
        public int MaCTThue { get; set; }
        public string LoaiKhoan { get; set; }
        public int? KySo { get; set; }
        public byte Thang { get; set; }
        public short Nam { get; set; }
        public DateTime NgayDenHan { get; set; }
        public decimal SoTienPhaiThu { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
