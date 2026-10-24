using System.Data;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Services
{
    public sealed class DanhMucReadService
    {
        public DataTable LayNhanVien() { return Db.Query("SELECT MaNV, HoTen, MaPhongBan, TrangThai FROM dbo.NhanVien ORDER BY HoTen"); }
        public DataTable LayPhongBan() { return Db.Query("SELECT MaPhongBan, TenPhongBan FROM dbo.PhongBan ORDER BY TenPhongBan"); }
    }
}
