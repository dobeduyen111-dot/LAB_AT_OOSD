using System;

namespace WindowsFormsApp1
{
    public sealed class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }
        public int? Id { get; private set; }
        private KetQuaXuLy(bool ok, string message, int? id) { ThanhCong = ok; ThongBao = message; Id = id; }
        public static KetQuaXuLy Ok(string message, int? id = null) { return new KetQuaXuLy(true, message, id); }
        public static KetQuaXuLy Fail(string message) { return new KetQuaXuLy(false, message, null); }
    }

    public sealed class NhanVienItem
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public override string ToString() { return MaNV + " - " + HoTen; }
    }

    public sealed class PhongBanItem
    {
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public override string ToString() { return MaPhongBan + " - " + TenPhongBan; }
    }
}
