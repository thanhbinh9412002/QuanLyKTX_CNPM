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
   
    public class HoaDon_DAO
    {
        private DataProvider cnn = null;
        public HoaDon_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation(string maphong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaPhong", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maphong;
            return cnn.executeReader("SELECT * FROM func_HoaDonPhong(@MaPhong)", sqlParameters);
        }

        public void AddHD(string mahd, string maphong, DateTime ngaylap, int trangthai, float tongtien)
        {
            string sql = "proc_ThemHoaDon";
            string[] pNames = { "@MAHD", "@MaPhong", "@NgayLapHD", "@TrangThai", "@TongTien" };
            object[] pvalues = { mahd, maphong, ngaylap, trangthai, tongtien };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public void UpdateInvoice(string mahd, string maphong, DateTime ngaylap, int trangthai, float tongtien)
        {
            string sql = "proc_SuaHoaDon";
            string[] pNames = { "@MAHD", "@MaPhong", "@ngaytao", "@TrangThai", "@TongTien" };
            object[] pvalues = { mahd, maphong, ngaylap, trangthai, tongtien };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
    }
}
