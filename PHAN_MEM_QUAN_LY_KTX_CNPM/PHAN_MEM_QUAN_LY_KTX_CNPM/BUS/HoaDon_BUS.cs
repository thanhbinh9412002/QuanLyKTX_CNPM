using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class HoaDon_BUS
    {
        private HoaDon_DAO HoaDonDAO;

        public HoaDon_BUS()
        {
            HoaDonDAO = new HoaDon_DAO();
        }
        public DataTable GetAllInformation(string maphong)
        {
            return HoaDonDAO.GetAllInformation(maphong);
        }
        public void AddHD(string mahd, string maphong, DateTime ngaylap, int trangthai, float tongtien)
        {
            HoaDonDAO.AddHD(mahd, maphong, ngaylap, trangthai, tongtien);
        }
        public void UpdateInvoice(string mahd, string maphong, DateTime ngaylap, int trangthai, float tongtien)
        {
            HoaDonDAO.UpdateInvoice(mahd, maphong, ngaylap, trangthai, tongtien);
        }
    }
}
