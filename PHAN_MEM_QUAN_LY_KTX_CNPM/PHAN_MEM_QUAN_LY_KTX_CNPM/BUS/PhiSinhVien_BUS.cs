using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class PhiSinhVien_BUS
    {
        private PhiSinhVien_DAO PhiSinhVienDAO;

        public PhiSinhVien_BUS()
        {
            PhiSinhVienDAO = new PhiSinhVien_DAO();
        }
        public DataTable GetAllInformation(string maphong)
        {
            return PhiSinhVienDAO.GetAllInformation(maphong);
        }
        public DataTable GetAccountSV(string mssv)
        {
            return PhiSinhVienDAO.GetAccountSV(mssv);
        }
    }
}
