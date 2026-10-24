using System;
using System.Data;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Services
{
    public sealed class HopDongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"SELECT hd.SoHopDong, hd.MaNV, nv.HoTen, hd.LoaiHopDong, hd.NgayKy,
                hd.NgayBatDau, hd.NgayKetThuc, CASE WHEN hd.NgayKetThuc IS NULL THEN N'Đang hiệu lực' ELSE N'Có thời hạn' END AS TrangThai
                FROM dbo.HopDongLaoDong hd JOIN dbo.NhanVien nv ON nv.MaNV=hd.MaNV ORDER BY hd.SoHopDong DESC");
        }

        public KetQuaXuLy Luu(int maNv, string loai, DateTime ngayKy, DateTime ngayBatDau, DateTime? ngayKetThuc, string noiDung)
        {
            if (maNv <= 0 || (loai != "DaiHan" && loai != "NganHan") || string.IsNullOrWhiteSpace(noiDung) || (ngayKetThuc.HasValue && ngayKetThuc.Value.Date < ngayBatDau.Date)) return KetQuaXuLy.Fail("Thông tin hợp đồng không hợp lệ.");
            try
            {
                var endTrial = Db.Scalar("SELECT KetThucThuViec FROM dbo.QuyetDinhTuyenDung WHERE MaNV=@nv", Db.P("@nv", maNv));
                if (endTrial == null || endTrial == DBNull.Value || Convert.ToDateTime(endTrial).Date > ngayKy.Date) return KetQuaXuLy.Fail("Nhân viên chưa hoàn tất thử việc.");
                var id = Convert.ToInt32(Db.Scalar(@"INSERT dbo.HopDongLaoDong(MaNV,LoaiHopDong,NgayKy,NgayBatDau,NgayKetThuc,NoiDung)
                    OUTPUT INSERTED.SoHopDong VALUES(@nv,@loai,@ky,@bd,@kt,@nd)", Db.P("@nv", maNv), Db.P("@loai", loai), Db.P("@ky", ngayKy.Date), Db.P("@bd", ngayBatDau.Date), Db.P("@kt", (object)ngayKetThuc ?? DBNull.Value), Db.P("@nd", noiDung.Trim())));
                return KetQuaXuLy.Ok("Đã lưu hợp đồng.", id);
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Không thể lưu hợp đồng: " + ex.Message); }
        }
    }
}
