using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class ThietBi_BUS
    {
        private ThietBi_DAO TBiDAO;
        public ThietBi_BUS()
        {
            TBiDAO = new ThietBi_DAO();
        }
        public DataTable GetAllInformation()
        {
            return TBiDAO.GetAllInformation();
        }
        public void ThemTBi(string matb, string tentbi, int soluong)
        {
            TBiDAO.ThemTBi(matb, tentbi, soluong);
        }
        public void SuaTBi(string matb, string tentbi, int soluong)
        {
            TBiDAO.SuaTBi(matb, tentbi, soluong);
        }
        public DataTable Timkiem(string tentbi)
        {
            return TBiDAO.Timkiem(tentbi);
        }
    }
}
