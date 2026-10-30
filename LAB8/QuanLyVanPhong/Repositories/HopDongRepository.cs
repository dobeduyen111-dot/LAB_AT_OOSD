using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVanPhong.Data;

namespace QuanLyVanPhong.Repositories
{
    /// <summary>Gom truy vấn và lời gọi stored procedure của chức năng hợp đồng.</summary>
    public sealed class HopDongRepository
    {
        public DataTable LayKhachThue()
        {
            return DbConnection.Query("SELECT MaKH,TenDonVi FROM dbo.KhachThue ORDER BY TenDonVi");
        }
        public DataTable LayPhongTrong(DateTime batDau, DateTime ketThuc)
        {
            return DbConnection.Query(@"SELECT vp.MaVP,vp.Tang,vp.SoPhong,
                CONCAT(N'Tầng ',vp.Tang,N' - Phòng ',vp.SoPhong) AS TenPhong,
                vp.DienTich,vp.DonGiaNiemYet
                FROM dbo.VanPhong vp
                WHERE NOT EXISTS(
                    SELECT 1 FROM dbo.ChiTietThue ct
                    JOIN dbo.HopDongThue hd ON hd.MaHD=ct.MaHD
                    WHERE ct.MaVP=vp.MaVP AND hd.TrangThai NOT IN ('Huy','KetThuc')
                      AND hd.NgayBatDau<=@KetThuc AND ct.NgayKetThucHieuLuc>=@BatDau)
                ORDER BY vp.Tang,vp.SoPhong",
                DbConnection.P("@BatDau",batDau.Date),DbConnection.P("@KetThuc",ketThuc.Date));
        }
        public DataTable LayHopDong()
        {
            return DbConnection.Query(@"SELECT h.MaHD,h.SoHD,h.MaKH,k.TenDonVi,h.NgayKy,h.NgayBatDau,h.SoThang,h.TrangThai,h.NoiDung,
                 (SELECT COUNT(*) FROM dbo.ChiTietThue ct WHERE ct.MaHD=h.MaHD) AS SoPhong,
                 (SELECT ISNULL(SUM(ct.DonGiaThang),0) FROM dbo.ChiTietThue ct WHERE ct.MaHD=h.MaHD) AS TongTienThang
                FROM dbo.HopDongThue h JOIN dbo.KhachThue k ON k.MaKH=h.MaKH
                ORDER BY h.MaHD DESC");
        }
        public DataTable LayChiTiet(int maHD)
        {
            return DbConnection.Query(@"SELECT ct.MaVP,vp.Tang,vp.SoPhong,ct.DonGiaThang,ct.NgayKetThucHieuLuc
                FROM dbo.ChiTietThue ct JOIN dbo.VanPhong vp ON vp.MaVP=ct.MaVP
                WHERE ct.MaHD=@MaHD ORDER BY vp.Tang,vp.SoPhong",DbConnection.P("@MaHD",maHD));
        }
        public int LapHopDong(string soHD,int maKH,DateTime ngayKy,DateTime ngayBD,int soThang,
            DataTable danhSach,string noiDung)
        {
            var bangThamSo = new SqlParameter("@DanhSach",SqlDbType.Structured)
                {TypeName="dbo.TVP_PhongThue", Value=danhSach};
            var result = DbConnection.StoredProcedureScalar("dbo.sp_LapHopDong",
                DbConnection.P("@SoHD",soHD),DbConnection.P("@MaKH",maKH),DbConnection.P("@NgayKy",ngayKy.Date),
                DbConnection.P("@NgayBatDau",ngayBD.Date),DbConnection.P("@SoThang",soThang),bangThamSo,
                DbConnection.P("@NoiDung",string.IsNullOrWhiteSpace(noiDung)?(object)DBNull.Value:noiDung));
            if (result==null || result==DBNull.Value) throw new InvalidOperationException("Thủ tục chưa trả về mã hợp đồng.");
            return Convert.ToInt32(result);
        }
        public int CapNhatNoiDung(int maHD,string noiDung)
        {
            return DbConnection.Execute(@"UPDATE dbo.HopDongThue SET NoiDung=@NoiDung
              WHERE MaHD=@MaHD AND TrangThai='ChoThanhToan'
              AND NOT EXISTS(SELECT 1 FROM dbo.ChiTietThue ct
                 JOIN dbo.KhoanThanhToan k ON k.MaCTThue=ct.MaCTThue
                 JOIN dbo.LanThanhToan t ON t.MaKhoan=k.MaKhoan WHERE ct.MaHD=@MaHD)",
                 DbConnection.P("@NoiDung",string.IsNullOrWhiteSpace(noiDung)?(object)DBNull.Value:noiDung),DbConnection.P("@MaHD",maHD));
        }
        public void ThuTruoc6Thang(int maHD,DateTime ngayThu,string soChungTu)
        {
            DbConnection.StoredProcedure("dbo.sp_ThuTruoc6Thang",DbConnection.P("@MaHD",maHD),
                DbConnection.P("@NgayThu",ngayThu.Date),DbConnection.P("@SoChungTu",soChungTu));
        }
    }
}
