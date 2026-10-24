using System;
using System.Data;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Services
{
    public sealed class KhenThuongService
    {
        public DataTable LayDanhSach()
        {
            return Db.Query(@"SELECT q.SoQDKT, q.MaNV, nv.HoTen, q.MaPhongBan, pb.TenPhongBan,
                q.NgayKy, q.NoiDung, q.SoTienThuong, q.TrangThaiKy,
                CASE WHEN pc.SoPhieuChi IS NULL THEN N'Chưa chi' ELSE N'Đã chi' END AS TrangThaiChi
                FROM dbo.QuyetDinhKhenThuong q LEFT JOIN dbo.NhanVien nv ON nv.MaNV=q.MaNV
                LEFT JOIN dbo.PhongBan pb ON pb.MaPhongBan=q.MaPhongBan
                LEFT JOIN dbo.PhieuChiKhenThuong pc ON pc.SoQDKT=q.SoQDKT ORDER BY q.SoQDKT DESC");
        }

        public KetQuaXuLy LapQuyetDinh(int? maNv, int? maPhongBan, DateTime ngayQuyetDinh, string noiDung, decimal soTien)
        {
            if (maNv.HasValue == maPhongBan.HasValue) return KetQuaXuLy.Fail("Chỉ chọn một đối tượng: cá nhân hoặc phòng ban.");
            if (string.IsNullOrWhiteSpace(noiDung) || soTien < 0) return KetQuaXuLy.Fail("Nội dung hoặc số tiền không hợp lệ.");
            try
            {
                var id = Convert.ToInt32(Db.Scalar(@"INSERT dbo.QuyetDinhKhenThuong(MaNV,MaPhongBan,NgayKy,NoiDung,SoTienThuong,TrangThaiKy)
                    OUTPUT INSERTED.SoQDKT VALUES(@nv,@pb,NULL,@nd,@t,'ChoKy')", Db.P("@nv", (object)maNv ?? DBNull.Value), Db.P("@pb", (object)maPhongBan ?? DBNull.Value), Db.P("@nd", noiDung.Trim()), Db.P("@t", soTien)));
                return KetQuaXuLy.Ok("Đã lập quyết định chờ ký.", id);
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Không thể lập quyết định: " + ex.Message); }
        }

        public KetQuaXuLy XacNhanKy(int soQd)
        {
            try { return Db.Execute("UPDATE dbo.QuyetDinhKhenThuong SET TrangThaiKy='DaKy', NgayKy=CONVERT(date,GETDATE()) WHERE SoQDKT=@id AND TrangThaiKy='ChoKy'", Db.P("@id", soQd)) == 1 ? KetQuaXuLy.Ok("Đã xác nhận ký.") : KetQuaXuLy.Fail("Không tìm thấy quyết định chờ ký."); }
            catch (Exception ex) { return KetQuaXuLy.Fail("Không thể xác nhận ký: " + ex.Message); }
        }

        public KetQuaXuLy LapPhieuChi(int soQd, DateTime ngayChi, decimal soTien)
        {
            if (soTien <= 0) return KetQuaXuLy.Fail("Số tiền chi phải lớn hơn 0.");
            try
            {
                var row = Db.Query("SELECT TrangThaiKy, NgayKy, SoTienThuong FROM dbo.QuyetDinhKhenThuong WHERE SoQDKT=@id", Db.P("@id", soQd));
                if (row.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy quyết định.");
                if (Convert.ToString(row.Rows[0]["TrangThaiKy"]) != "DaKy") return KetQuaXuLy.Fail("Chỉ được chi cho quyết định đã ký.");
                if (soTien > Convert.ToDecimal(row.Rows[0]["SoTienThuong"])) return KetQuaXuLy.Fail("Số tiền chi vượt số tiền quyết định.");
                if (ngayChi.Date < Convert.ToDateTime(row.Rows[0]["NgayKy"]).Date) return KetQuaXuLy.Fail("Ngày chi không trước ngày ký.");
                Db.Execute("INSERT dbo.PhieuChiKhenThuong(SoQDKT,NgayChi,SoTien) VALUES(@id,@ngay,@tien)", Db.P("@id", soQd), Db.P("@ngay", ngayChi.Date), Db.P("@tien", soTien));
                return KetQuaXuLy.Ok("Đã lập phiếu chi khen thưởng.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Không thể lập phiếu chi: " + ex.Message); }
        }
    }
}
