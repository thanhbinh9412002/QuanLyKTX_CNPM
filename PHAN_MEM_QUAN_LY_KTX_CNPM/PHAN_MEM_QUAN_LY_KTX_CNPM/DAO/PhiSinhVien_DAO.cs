using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;
using System.Data;
using System.Data.SqlClient;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.DAO
{
    public class PhiSinhVien_DAO
    {
        private DataProvider cnn = null;
        public PhiSinhVien_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation(string maphong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaPhong", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maphong;
            return cnn.executeReader("SELECT * FROM func_HoaDonChuaThanhToan(@MaPhong)", sqlParameters);
        }

        public DataTable GetAccountSV(string mssv)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSinhVien", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = mssv;
            return cnn.executeReader("SELECT * FROM func_LayTKSV(@MaSinhVien)", sqlParameters);
        }
    }
}
