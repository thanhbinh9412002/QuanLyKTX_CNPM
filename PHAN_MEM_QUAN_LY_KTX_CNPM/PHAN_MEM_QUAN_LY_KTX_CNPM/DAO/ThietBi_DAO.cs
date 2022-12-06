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
    public class ThietBi_DAO
    {
        private DataProvider cnn = null;
        public ThietBi_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation()
        {
            string spName = "[dbo].[proc_DanhSachTatCaTrangThietBi]";
            return cnn.ExecuteProcedureDatatableNoPara(spName);
        }

        public void ThemTBi(string matb, string tentbi, int soluong)
        {
            string sql = "proc_ThemThietBi";
            string[] pNames = { "@matb", "@tentb", "@tongsl" };
            object[] pvalues = { matb, tentbi, soluong };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void SuaTBi(string matb, string tentbi, int soluong)
        {
            string sql = "proc_SuaThietBi";
            string[] pNames = { "@matb", "@tentb", "@tongsl" };
            object[] pvalues = { matb, tentbi, soluong };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public DataTable Timkiem(string tentbi)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tentb", System.Data.SqlDbType.NVarChar);
            sqlParameters[0].Value = tentbi;
            return cnn.executeReader("SELECT * FROM func_TimkiemTBi(@tentb)", sqlParameters);
        }
    }
}
