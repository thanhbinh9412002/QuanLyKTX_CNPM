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
        public void AddRoom(string MaPhong, int GiaPhong, int SVHienTai, int SVToiDa, string tinhtrang)
        {
            PhongDAO.AddRoom(MaPhong, GiaPhong, SVHienTai, SVToiDa, tinhtrang);
        }
        public void UpdateRoom(string MaPhong, int GiaPhong, int SVHienTai, int SVToiDa, string tinhtrang)
        {
            PhongDAO.UpdateRoom(MaPhong, GiaPhong, SVHienTai, SVToiDa, tinhtrang);
        }
        public void DeleteRoom(string MaPhong)
        {
            PhongDAO.DeleteRoom(MaPhong);
        }
        public DataTable PhongDay()
        {
            return PhongDAO.PhongDay();
        }
        public DataTable PhongConCho()
        {
            return PhongDAO.PhongConCho();
        }
    }
}
