using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class ChiTietPhong_BUS
    {
        private ChiTietPhong_DAO ChiTietPhongDAO;
        public ChiTietPhong_BUS()
        {
            ChiTietPhongDAO = new ChiTietPhong_DAO();
        }
        public DataTable GetAllInformation(string maphong)
        {
            return ChiTietPhongDAO.GetAllInformation(maphong);
        }
        public DataTable GetComboBox()
        {
            return ChiTietPhongDAO.GetComboBox();
        }
    }
}
