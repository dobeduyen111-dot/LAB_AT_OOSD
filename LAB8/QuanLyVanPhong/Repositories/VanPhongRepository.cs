using System.Data;
using QuanLyVanPhong.Data;

namespace QuanLyVanPhong.Repositories
{
    public sealed class VanPhongRepository
    {
        public DataTable LayVanPhong()
        {
            return DbConnection.Query("SELECT MaVP,Tang,SoPhong,Huong,DienTich,DonGiaNiemYet FROM dbo.VanPhong ORDER BY Tang,SoPhong");
        }

        public int LuuVanPhong(int? ma, int tang, string soPhong, string huong, decimal dienTich, decimal donGia)
        {
            if (ma.HasValue)
                return DbConnection.Execute(@"UPDATE dbo.VanPhong SET Tang=@Tang, SoPhong=@SoPhong, Huong=@Huong, DienTich=@DienTich, DonGiaNiemYet=@Gia WHERE MaVP=@MaVP",
                    DbConnection.P("@Tang",tang),DbConnection.P("@SoPhong",soPhong),DbConnection.P("@Huong",huong),DbConnection.P("@DienTich",dienTich),DbConnection.P("@Gia",donGia),DbConnection.P("@MaVP",ma.Value));
            return DbConnection.Execute(@"INSERT dbo.VanPhong(Tang,SoPhong,Huong,DienTich,DonGiaNiemYet) VALUES(@Tang,@SoPhong,@Huong,@DienTich,@Gia)",
                DbConnection.P("@Tang",tang),DbConnection.P("@SoPhong",soPhong),DbConnection.P("@Huong",huong),DbConnection.P("@DienTich",dienTich),DbConnection.P("@Gia",donGia));
        }
        public int XoaVanPhong(int ma)
        {
            return DbConnection.Execute("DELETE dbo.VanPhong WHERE MaVP=@Ma",DbConnection.P("@Ma",ma));
        }
    }
}
