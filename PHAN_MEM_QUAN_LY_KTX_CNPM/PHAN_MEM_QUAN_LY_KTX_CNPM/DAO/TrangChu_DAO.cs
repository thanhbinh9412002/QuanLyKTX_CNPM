using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class TrangChu_DAO
    {
        private DataProvider cnn = null;
        public TrangChu_DAO()
        {
            cnn = new DataProvider();
        }
        public string TraVeMaPhong(string username)
        {
            string spName = "[dbo].[func_LayMaPhong]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@cmnd" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { username };
            string count = cnn.ExecuteStoredProcedureString(spName, pNames, pValues);
            return count;
        }
        public string TraVeMaSinhVien(string username)
        {
            string spName = "[dbo].[func_LayMaSinhVien]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@cmnd" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { username };
            string count = cnn.ExecuteStoredProcedureString(spName, pNames, pValues);
            return count;
        }
    }
}
