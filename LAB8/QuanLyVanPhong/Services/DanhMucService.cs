using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVanPhong.Repositories;

namespace QuanLyVanPhong.Services
{
    public sealed class DanhMucService
    {
        private readonly VanPhongRepository vanPhongRepository = new VanPhongRepository();
        private readonly KhachThueRepository khachThueRepository = new KhachThueRepository();
        public DataTable LayVanPhong() { return vanPhongRepository.LayVanPhong(); }
        public DataTable LayKhachThue() { return khachThueRepository.LayKhachThue(); }
        public KetQuaXuLy LuuVanPhong(int? ma,int tang,string soPhong,string huong,decimal dienTich,decimal donGia)
        {
            if(tang<0 || string.IsNullOrWhiteSpace(soPhong) || dienTich<=0 || donGia<=0)
                return KetQuaXuLy.Fail("Tầng, số phòng, diện tích và đơn giá không hợp lệ.");
            try
            {
                int rows=vanPhongRepository.LuuVanPhong(ma,tang,soPhong.Trim(),(huong??"").Trim(),dienTich,donGia);
                return rows>0?KetQuaXuLy.Ok("Đã lưu thông tin văn phòng."):
                    KetQuaXuLy.Fail("Không tìm thấy văn phòng để cập nhật.");
            }
            catch(SqlException ex) {return KetQuaXuLy.Fail("Không thể lưu văn phòng: "+ex.Message);}
        }
        public KetQuaXuLy XoaVanPhong(int ma)
        {
            try
            {
                return vanPhongRepository.XoaVanPhong(ma)>0?KetQuaXuLy.Ok("Đã xóa văn phòng."):
                    KetQuaXuLy.Fail("Không tìm thấy văn phòng.");
            }
            catch(SqlException ex) {return KetQuaXuLy.Fail("Văn phòng đang được sử dụng hoặc có lỗi: "+ex.Message);}
        }
        public KetQuaXuLy LuuKhachThue(int? ma,string donVi,string daiDien,string diaChi,string sdt)
        {
            if(string.IsNullOrWhiteSpace(donVi) || string.IsNullOrWhiteSpace(daiDien))
                return KetQuaXuLy.Fail("Cần nhập tên đơn vị và người đại diện.");
            try
            {
                int rows=khachThueRepository.LuuKhachThue(ma,donVi.Trim(),daiDien.Trim(),(diaChi??"").Trim(),(sdt??"").Trim());
                return rows>0?KetQuaXuLy.Ok("Đã lưu khách thuê."):
                    KetQuaXuLy.Fail("Không tìm thấy khách thuê để cập nhật.");
            }
            catch(SqlException ex) {return KetQuaXuLy.Fail("Không thể lưu khách thuê: "+ex.Message);}
        }
        public KetQuaXuLy XoaKhachThue(int ma)
        {
            try
            {
                return khachThueRepository.XoaKhachThue(ma)>0?KetQuaXuLy.Ok("Đã xóa khách thuê."):
                    KetQuaXuLy.Fail("Không tìm thấy khách thuê.");
            }
            catch(SqlException ex) {return KetQuaXuLy.Fail("Khách đã có hợp đồng hoặc có lỗi: "+ex.Message);}
        }
    }
}
