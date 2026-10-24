using System;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Services
{
    public sealed class BaoHiemService
    {
        public KetQuaXuLy LuuHoSo(int maNv, string bhyt, string bhxh, decimal mucBhyt, decimal mucBhxh)
        {
            if (maNv <= 0 || string.IsNullOrWhiteSpace(bhyt) || string.IsNullOrWhiteSpace(bhxh) || mucBhyt < 0 || mucBhxh < 0) return KetQuaXuLy.Fail("Thông tin bảo hiểm không hợp lệ.");
            try
            {
                var type = Convert.ToString(Db.Scalar(@"SELECT TOP 1 LoaiHopDong FROM dbo.HopDongLaoDong WHERE MaNV=@nv ORDER BY NgayKy DESC, SoHopDong DESC", Db.P("@nv", maNv)));
                if (type != "DaiHan") return KetQuaXuLy.Fail("Chỉ hợp đồng dài hạn mới lập hồ sơ bảo hiểm.");
                Db.Execute(@"IF EXISTS(SELECT 1 FROM dbo.HoSoBaoHiem WHERE MaNV=@nv)
                    UPDATE dbo.HoSoBaoHiem SET MaSoBHYT=@yt, MaSoBHXH=@xh, MucDongBHYT=@myt, MucDongBHXH=@mxh WHERE MaNV=@nv
                    ELSE INSERT dbo.HoSoBaoHiem(MaNV,MaSoBHYT,MaSoBHXH,MucDongBHYT,MucDongBHXH) VALUES(@nv,@yt,@xh,@myt,@mxh)",
                    Db.P("@nv", maNv), Db.P("@yt", bhyt.Trim()), Db.P("@xh", bhxh.Trim()), Db.P("@myt", mucBhyt), Db.P("@mxh", mucBhxh));
                return KetQuaXuLy.Ok("Đã lưu hồ sơ BHYT/BHXH.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail("Không thể lưu hồ sơ bảo hiểm: " + ex.Message); }
        }
    }
}
