using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    internal class ThongBao_BUS
    {
        private ThongBao_DAO TbDAO;
        public ThongBao_BUS()
        {
            TbDAO = new ThongBao_DAO();
        }
        public DataTable GetAllInformation()
        {
            return TbDAO.GetInformation();
        }
        public void GuiThongBao(string tieude, string noidung, DateTime ngaydang)
        {
            TbDAO.GuiThongBao(tieude, noidung, ngaydang);   
        }
    }
}
