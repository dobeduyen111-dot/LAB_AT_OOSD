using System.Data;
using QuanLyVanPhong.Data;

namespace QuanLyVanPhong.Repositories
{
    public sealed class KhachThueRepository
    {
        public DataTable LayKhachThue()
        {
            return DbConnection.Query("SELECT MaKH,TenDonVi,NguoiDaiDien,DiaChi,DienThoai FROM dbo.KhachThue ORDER BY TenDonVi");
        }

        public int LuuKhachThue(int? ma, string tenDonVi, string daiDien, string diaChi, string sdt)
        {
            if (ma.HasValue)
                return DbConnection.Execute(@"UPDATE dbo.KhachThue SET TenDonVi=@Ten, NguoiDaiDien=@DaiDien, DiaChi=@DiaChi, DienThoai=@SDT WHERE MaKH=@Ma",
                    DbConnection.P("@Ten",tenDonVi),DbConnection.P("@DaiDien",daiDien),DbConnection.P("@DiaChi",diaChi),DbConnection.P("@SDT",sdt),DbConnection.P("@Ma",ma.Value));
            return DbConnection.Execute(@"INSERT dbo.KhachThue(TenDonVi,NguoiDaiDien,DiaChi,DienThoai) VALUES(@Ten,@DaiDien,@DiaChi,@SDT)",
                DbConnection.P("@Ten",tenDonVi),DbConnection.P("@DaiDien",daiDien),DbConnection.P("@DiaChi",diaChi),DbConnection.P("@SDT",sdt));
        }
        public int XoaKhachThue(int ma)
        {
            return DbConnection.Execute("DELETE dbo.KhachThue WHERE MaKH=@Ma",DbConnection.P("@Ma",ma));
        }
    }
}
