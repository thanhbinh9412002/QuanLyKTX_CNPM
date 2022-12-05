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
            /*string sql = "func_HoaDonPhong(@MaPhong)";
            string[] pNames = { "@MaPhong" };
            object[] pvalues = {maphong};
            return cnn.ExecuteProcedureDatatable(sql, pNames, pvalues);*/
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

        public int laySoDien (string mahd)
        {
            int newProdID = 0;
            string sql = "[dbo].[func_LaySoDien]";
            string[] pNames = { "@MAHD"};
            object[] pvalues = { mahd };
            newProdID = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return newProdID;
        }

        public int laySoNuoc(string mahd)
        {
            int newProdID = 0;
            string sql = "[dbo].[func_LaySoNuoc]";
            string[] pNames = { "@MAHD" };
            object[] pvalues = { mahd };
            newProdID = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return newProdID;
        }

        public double layGiaDien(string mahd)
        {
            double newProdID = 0;
            string sql = "[dbo].[func_LayGiaDien]";
            string[] pNames = { "@MAHD" };
            object[] pvalues = { mahd };
            newProdID = cnn.ExecuteStoredProcedure_float(sql, pNames, pvalues);
            return newProdID;
        }

        public double layGiaNuoc(string mahd)
        {
            double newProdID = 0;
            string sql = "[dbo].[func_LayGiaNuoc]";
            string[] pNames = { "@MAHD" };
            object[] pvalues = { mahd };
            newProdID = cnn.ExecuteStoredProcedure_float(sql, pNames, pvalues);
            return newProdID;
        }

        public int CheckTaoHD(string maphong)
        {
            int newProdID = 0;
            string sql = "[dbo].[func_KiemtraTaoHD]";
            string[] pNames = { "@MaPhong" };
            object[] pvalues = { maphong };
            newProdID = cnn.ExecuteStoredProcedure(sql, pNames, pvalues);
            return newProdID;
        }
    }
}
