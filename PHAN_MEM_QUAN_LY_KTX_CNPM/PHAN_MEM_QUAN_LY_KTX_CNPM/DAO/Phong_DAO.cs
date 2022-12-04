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
    public class Phong_DAO
    {
        private DataProvider cnn = null;
        public Phong_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation()
        {
            //SqlParameter[] sqlParameters = new SqlParameter[0]; 
            return cnn.executeLoadData("SELECT * FROM func_DanhSachPhong()");
        }
        public void AddRoom(string MaPhong, int GiaPhong, int SVHienTai, int SVToiDa, string tinhtrang)
        {
            string sql = "proc_ThemPhong";
            string[] pNames = { "@MaPhong", "@GiaPhong", "@SoLuongSinhVienHienTai", "@SoLuongSinhVienToiDa", "@TinhTrang" };
            object[] pvalues = { MaPhong, GiaPhong, SVHienTai, SVToiDa, tinhtrang };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void UpdateRoom(string MaPhong, int GiaPhong, int SVHienTai, int SVToiDa, string tinhtrang)
        {
            string sql = "proc_SuaPhong";
            string[] pNames = { "@MaPhong", "@GiaPhong", "@SoLuongSinhVienHienTai", "@SoLuongSinhVienToiDa", "@TinhTrang" };
            object[] pvalues = { MaPhong, GiaPhong, SVHienTai, SVToiDa, tinhtrang };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void DeleteRoom(string MaPhong)
        {
            string sql = "proc_XoaPhong";
            string[] pNames = { "@MaPhong" };
            object[] pvalues = { MaPhong };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public DataTable PhongConCho()
        {
            string sql = "pro_DanhSachPhongConCho";
            return cnn.ExecuteProcedureDatatableNoPara(sql);
        }
        public DataTable PhongDay()
        {
            string sql = "pro_DanhSachPhongDay";
            return cnn.ExecuteProcedureDatatableNoPara(sql);
        }
    }
}
