using System;
using System.Data;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Services
{
    public sealed class TuyenDungService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"SELECT q.SoQDTD, q.MaNV, nv.HoTen, q.MaPhongBan, pb.TenPhongBan,
                q.NgayKy, q.BatDauThuViec, q.KetThucThuViec, q.LuongThuViec, q.DieuKhoan
                FROM dbo.QuyetDinhTuyenDung q JOIN dbo.NhanVien nv ON nv.MaNV=q.MaNV
                JOIN dbo.PhongBan pb ON pb.MaPhongBan=q.MaPhongBan ORDER BY q.SoQDTD DESC");
        }

        public KetQuaXuLy Luu(int? soQd, int maNv, int maPhongBan, DateTime ngayKy, DateTime batDau, DateTime ketThuc, decimal luong, string dieuKhoan)
        {
            if (maNv <= 0 || maPhongBan <= 0 || ketThuc.Date < batDau.Date || luong < 0 || string.IsNullOrWhiteSpace(dieuKhoan)) return KetQuaXuLy.Fail("Thông tin quyết định thử việc không hợp lệ.");
            try
            {
                if (soQd.HasValue)
                    Db.Execute(@"UPDATE dbo.QuyetDinhTuyenDung SET MaNV=@nv, MaPhongBan=@pb, NgayKy=@ky,
                        BatDauThuViec=@bd, KetThucThuViec=@kt, LuongThuViec=@luong, DieuKhoan=@dk WHERE SoQDTD=@id",
                        Db.P("@id", soQd.Value), Db.P("@nv", maNv), Db.P("@pb", maPhongBan), Db.P("@ky", ngayKy.Date), Db.P("@bd", batDau.Date), Db.P("@kt", ketThuc.Date), Db.P("@luong", luong), Db.P("@dk", dieuKhoan.Trim()));
                else
                {
                    var exists = Convert.ToInt32(Db.Scalar("SELECT COUNT(1) FROM dbo.QuyetDinhTuyenDung WHERE MaNV=@nv", Db.P("@nv", maNv)));
                    if (exists > 0) return KetQuaXuLy.Fail("Nhân viên đã có quyết định thử việc.");
                    var id = Convert.ToInt32(Db.Scalar(@"INSERT dbo.QuyetDinhTuyenDung(MaNV,MaPhongBan,NgayKy,BatDauThuViec,KetThucThuViec,LuongThuViec,DieuKhoan)
                        OUTPUT INSERTED.SoQDTD VALUES(@nv,@pb,@ky,@bd,@kt,@luong,@dk)", Db.P("@nv", maNv), Db.P("@pb", maPhongBan), Db.P("@ky", ngayKy.Date), Db.P("@bd", batDau.Date), Db.P("@kt", ketThuc.Date), Db.P("@luong", luong), Db.P("@dk", dieuKhoan.Trim())));
                    return KetQuaXuLy.Ok("Đã lập quyết định tuyển dụng.", id);
                }
                return KetQuaXuLy.Ok("Đã cập nhật quyết định tuyển dụng.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Không thể lưu quyết định: " + ex.Message); }
        }
    }
}
