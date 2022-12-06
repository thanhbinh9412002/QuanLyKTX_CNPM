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
    public class ThietbiTrongPhong_DAO
    {
        private DataProvider cnn = null;
        public ThietbiTrongPhong_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation(string maphong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaPhong", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maphong;
            return cnn.executeReader("SELECT * FROM func_DanhSachThietBiPhong(@MaPhong)", sqlParameters);
        }

        public string MaTB_Ten(string tenthietbi)
        {
            string matb;
            string sql = "[dbo].[func_LayMaThietBiTheoTen]";
            string[] pNames = { "@TenThietBi" };
            object[] pvalues = { tenthietbi };
            matb = cnn.ExecuteStoredProcedureString(sql, pNames, pvalues);
            return matb;
        }
        public DataTable GetTenTB()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return cnn.executeReader("SELECT * FROM func_LayTenThietBi()", sqlParameters);
        }

        public void ThemTbiPhong(string matb, string maphong, int soluonghong, int soluongtot, int soluongtoida)
        {
            string sql = "proc_ThemThietBiTrongPhong";
            string[] pNames = { "@matb", "@maphong", "@soluonghong", "@soluongtot", "@soluongtoida" };
            object[] pvalues = { matb, maphong, soluonghong, soluongtot, soluongtoida };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public void SuaTbiPhong(string matb, string maphong, int soluonghong, int soluongtot, int soluongtoida)
        {
            string sql = "proc_SuaThietBiTrongPhong";
            string[] pNames = { "@matb", "@maphong", "@soluonghong", "@soluongtot", "@soluongtoida" };
            object[] pvalues = { matb, maphong, soluonghong, soluongtot, soluongtoida };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public DataTable Timkiem(string maphong, string tentbi)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tentb", System.Data.SqlDbType.NVarChar);
            sqlParameters[0].Value = tentbi;
            sqlParameters[1] = new SqlParameter("@MaPhong", System.Data.SqlDbType.Char);
            sqlParameters[1].Value = maphong;
            return cnn.executeReader("SELECT * FROM func_TimkiemTBiTheoTen(@tentb,@MaPhong)", sqlParameters);
        }

        public DataTable TenTbi_Phong(string maphong)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaPhong", System.Data.SqlDbType.Char);
            sqlParameters[0].Value = maphong;
            return cnn.executeReader("SELECT * FROM func_TenTbiTrongPhong(@MaPhong)", sqlParameters);
        }
    }
}
