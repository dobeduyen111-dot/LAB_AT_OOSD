using System.Data;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class DanhMucService
    {
        public DataTable LayBang(string tenBang)
        {
            return Db.Query("SELECT * FROM " + tenBang);
        }
    }
}
