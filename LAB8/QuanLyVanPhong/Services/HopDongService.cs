using QuanLyVanPhong.Models;
using System;
using System.Data;
using System.Collections.Generic;
using QuanLyVanPhong.Repositories;

namespace QuanLyVanPhong.Services
{
    public sealed class HopDongService
    {
        private readonly HopDongRepository repository = new HopDongRepository();
        public DataTable LayKhachThue() { return repository.LayKhachThue(); }
        public DataTable LayPhongTrong(DateTime ngayBatDau,int soThang)
        {
            if(soThang<6)return new DataTable();
            return repository.LayPhongTrong(ngayBatDau,ngayBatDau.Date.AddMonths(soThang).AddDays(-1));
        }
        public DataTable LayHopDong() {return repository.LayHopDong();}
        public DataTable LayChiTiet(int maHD) {return repository.LayChiTiet(maHD);}
        public int LapHopDong(string soHD,int maKH,DateTime ngayKy,DateTime ngayBD,int soThang,
            IList<PhongThueChon> phong,string noiDung)
        {
            if(string.IsNullOrWhiteSpace(soHD))throw new ArgumentException("Chưa nhập số hợp đồng.");
            if(maKH<=0)throw new ArgumentException("Chưa chọn khách thuê.");
            if(soThang<6)throw new ArgumentException("Thời gian thuê tối thiểu 6 tháng.");
            if(phong==null || phong.Count==0)throw new ArgumentException("Cần chọn ít nhất một văn phòng.");
            var idSet=new HashSet<int>();
            var table=new DataTable();
            table.Columns.Add("MaVP",typeof(int));
            table.Columns.Add("DonGiaThang",typeof(decimal));
            foreach(var p in phong)
            {
                if(!idSet.Add(p.MaVP))throw new ArgumentException("Không chọn trùng phòng.");
                if(p.DonGiaThang<=0)throw new ArgumentException("Đơn giá phòng phải lớn hơn 0.");
                table.Rows.Add(p.MaVP,p.DonGiaThang);
            }
            return repository.LapHopDong(soHD.Trim(),maKH,ngayKy,ngayBD,soThang,table,noiDung);
        }
        public KetQuaXuLy CapNhatNoiDung(int maHD,string noiDung)
        {
            int rows=repository.CapNhatNoiDung(maHD,noiDung);
            return rows>0?KetQuaXuLy.Ok("Đã cập nhật ghi chú hợp đồng chưa thu tiền."):
                KetQuaXuLy.Fail("Không thể sửa hợp đồng đã thu tiền hoặc đang có hiệu lực.");
        }
        public void ThuTruoc6Thang(int maHD,DateTime ngayThu,string soChungTu)
        {
            repository.ThuTruoc6Thang(maHD,ngayThu,soChungTu);
        }
    }
}
