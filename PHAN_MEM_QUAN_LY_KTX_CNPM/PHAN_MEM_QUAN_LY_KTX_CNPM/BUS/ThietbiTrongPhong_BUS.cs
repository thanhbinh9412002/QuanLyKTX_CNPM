using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class ThietbiTrongPhong_BUS
    {
        private ThietbiTrongPhong_DAO TBi_PhongDAO;

        public ThietbiTrongPhong_BUS()
        {
            TBi_PhongDAO = new ThietbiTrongPhong_DAO();
        }
        public DataTable GetAllInformation(string maphong)
        {
            return TBi_PhongDAO.GetAllInformation(maphong);
        }
        public string MaTB_Ten(string tenthietbi)
        {
            return TBi_PhongDAO.MaTB_Ten(tenthietbi);
        }
        public DataTable GetTenTB()
        {
            return TBi_PhongDAO.GetTenTB();
        }

        public void ThemTbiPhong(string matb, string maphong, int soluonghong, int soluongtot, int soluongtoida)
        {
            TBi_PhongDAO.ThemTbiPhong(matb, maphong, soluonghong, soluongtot, soluongtoida);
        }
        public void SuaTbiPhong(string matb, string maphong, int soluonghong, int soluongtot, int soluongtoida)
        {
            TBi_PhongDAO.SuaTbiPhong(matb, maphong, soluonghong, soluongtot, soluongtoida);
        }
        public DataTable Timkiem(string maphong, string tentbi)
        {
            return TBi_PhongDAO.Timkiem(maphong, tentbi);
        }

        public DataTable TenTbi_Phong(string maphong)
        {
            return TBi_PhongDAO.TenTbi_Phong(maphong);
        }
    }
}
