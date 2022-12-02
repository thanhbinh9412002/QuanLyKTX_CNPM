using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class DangNhap_DAO
    {
        private DataProvider cnn = null;
        public DangNhap_DAO()
        {
            cnn = new DataProvider();
        }
        public int Check_Tai_Khoan(string username, string password, string role)
        {
            string spName = "[dbo].[func_KiemTraDangNhap]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@TenTK", "@MK", "@Vaitro" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { username, password, role };
            int count = cnn.ExecuteStoredProcedure(spName, pNames, pValues);
            return count;
        }
    }
}
