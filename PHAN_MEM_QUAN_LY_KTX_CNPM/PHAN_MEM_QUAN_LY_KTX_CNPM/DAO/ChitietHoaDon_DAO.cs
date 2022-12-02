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
    public class ChitietHoaDon_DAO
    {
        private DataProvider cnn = null;
        public ChitietHoaDon_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation(string mahd)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaHD", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = mahd;
            return cnn.executeReader("SELECT * FROM func_ChitietHD(@MaHD)", sqlParameters);
        }
        public void AddDetailInvoice(string mahd, int sodien , int sonuoc, float giadien, float gianuoc)
        {
            string sql = "proc_ThemChitietHoaDon";
            string[] pNames = { "@MAHD", "@SoDien", "@SoNuoc", "@GiaDien", "@GiaNuoc" };
            object[] pvalues = { mahd, sodien, sonuoc, giadien, gianuoc };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public void UpdateDetailInvoice(string mahd, int sodien, int sonuoc, double giadien, double gianuoc)
        {
            string sql = "proc_SuaChiTietHoaDon";
            string[] pNames = { "@MAHD", "@SoDien", "@SoNuoc", "@GiaDien", "@GiaNuoc" };
            object[] pvalues = { mahd, sodien, sonuoc, giadien, gianuoc };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
    }
}
