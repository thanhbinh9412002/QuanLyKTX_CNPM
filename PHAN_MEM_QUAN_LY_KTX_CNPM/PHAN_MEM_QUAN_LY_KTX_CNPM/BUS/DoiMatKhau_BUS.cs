using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class DoiMatKhau_BUS
    {
        private DoiMatKhau_DAO dmkDAO;
        public DoiMatKhau_BUS()
        {
            dmkDAO = new DoiMatKhau_DAO();
        }
        public int DoiMatKhau(string tentaikhoan, string newpass)
        {
            return dmkDAO.DoiMatKhau(tentaikhoan, newpass);
        }
    }
}
