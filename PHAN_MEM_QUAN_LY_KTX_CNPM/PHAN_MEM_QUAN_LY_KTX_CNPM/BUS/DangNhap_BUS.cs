using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class DangNhap_BUS
    {
        private DangNhap_DAO dnDAO;
        public DangNhap_BUS()
        {
            dnDAO = new DangNhap_DAO();
        }

        public int Check_Tai_Khoan(string username, string password, string role)
        {
            return dnDAO.Check_Tai_Khoan(username, password, role);
        }
    }
}
