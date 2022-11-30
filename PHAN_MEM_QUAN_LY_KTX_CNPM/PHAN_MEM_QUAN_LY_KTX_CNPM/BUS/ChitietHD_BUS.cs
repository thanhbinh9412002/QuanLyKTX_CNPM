using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class ChitietHD_BUS
    {
        private ChitietHoaDon_DAO ChitietHoaDonDAO;

        public ChitietHD_BUS()
        {
            ChitietHoaDonDAO = new ChitietHoaDon_DAO();
        }
        public DataTable GetAllInformation(string mahd)
        {
            return ChitietHoaDonDAO.GetAllInformation(mahd);
        }
        public void AddDetailInvoice(string mahd, int sodien, int sonuoc, float giadien, float gianuoc)
        {
            ChitietHoaDonDAO.AddDetailInvoice(mahd, sodien, sonuoc, giadien, gianuoc);
        }
    }
}
