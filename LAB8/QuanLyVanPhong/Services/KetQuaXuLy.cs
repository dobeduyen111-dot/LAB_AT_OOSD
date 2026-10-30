namespace QuanLyVanPhong.Services
{
    public sealed class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }
        public static KetQuaXuLy Ok(string message) { return new KetQuaXuLy { ThanhCong = true, ThongBao = message }; }
        public static KetQuaXuLy Fail(string message) { return new KetQuaXuLy { ThanhCong = false, ThongBao = message }; }
    }
}
