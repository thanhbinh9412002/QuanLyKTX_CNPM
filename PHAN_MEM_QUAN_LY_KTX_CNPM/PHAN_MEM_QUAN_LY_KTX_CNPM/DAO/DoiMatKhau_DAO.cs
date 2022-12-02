using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class DoiMatKhau_DAO
    {
        private DataProvider cnn = null;
        public DoiMatKhau_DAO()
        {
            cnn = new DataProvider();
        }
        public int DoiMatKhau(string tentaikhoan, string newpass)
        {
            string spName = "[dbo].[proc_DoiMatKhau]";
            string[] pNames = { "@tentk", "@mk" };
            object[] pValues = { tentaikhoan, newpass };
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
    }
}
