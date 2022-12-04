using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.DAO
{
    internal class SinhVien_DAO
    {
        DataProvider cnn = new DataProvider();
        public SinhVien_DAO()
        {

        }
        public DataTable Xuatdanhsachsinhvien()
        {
            return cnn.executeLoadData("SELECT * FROM view_DanhsachSinhvien");
        }
        public void Suasinhvien(string mssv, string hoten, string sdt, string gioitinh, int namhoc, string tongiao, string quoctich, string cccd, string maphong, int soky)
        {
            string sql = "proc_Suasinhvien";
            string[] pNames = { "@MaSinhVien", "@hoten", "@SoDienThoai", "@gioitinh", "@namhoc", "@tongiao", "@quoctich", "@CMND_CCCD", "@maphong", "@soky" };
            object[] pvalues = { mssv, hoten, sdt, gioitinh, namhoc, tongiao, quoctich, cccd, maphong, soky };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }

        public void Themsinhvien(string mssv, string hoten, string sdt, string gioitinh, int namhoc, string tongiao, string quoctich, string cccd, string maphong, int soky)
        {
            string sql = "proc_Themsinhvien";
            string[] pNames = { "@MaSinhVien", "@hoten", "@SoDienThoai", "@gioitinh", "@namhoc", "@tongiao", "@quoctich", "@CMND_CCCD", "@maphong", "@soky" };
            object[] pvalues = { mssv, hoten, sdt, gioitinh, namhoc, tongiao, quoctich, cccd, maphong, soky };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public void Xoasinhvien(string mssv)
        {
            string sql = "proc_xoasinhvien";
            string[] pNames = { "@MaSinhVien" };
            object[] pvalues = { mssv };
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
        public DataTable tablethongtin(string mssv)
        {
            return cnn.executeLoadData("SELECT * FROM SinhVien where MaSinhVien = '" + mssv + "'");
        }
    }
}
