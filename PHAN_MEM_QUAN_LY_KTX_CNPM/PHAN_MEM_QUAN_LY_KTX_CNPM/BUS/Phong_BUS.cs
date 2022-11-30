using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class Phong_BUS
    {
        private Phong_DAO PhongDAO;
        public Phong_BUS()
        {
            PhongDAO = new Phong_DAO();
        }
        public DataTable GetAllInformation()
        {
            return PhongDAO.GetAllInformation();
        }
    }
}
