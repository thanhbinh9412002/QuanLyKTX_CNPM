using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.DAO
{
    public class ChiTietPhong_DAO
    {
        private DataProvider cnn = null;
        public ChiTietPhong_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation(string maphong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaPhong", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maphong;
            return cnn.executeReader("SELECT * FROM func_DanhSachSinhVienTheoPhong(@MaPhong)", sqlParameters);
        }
        public DataTable GetComboBox()
        {
            string sql = "pro_DanhSachPhong_MaPhong";
            return cnn.ExecuteProcedureDatatableNoPara(sql);
        }
    }
}
