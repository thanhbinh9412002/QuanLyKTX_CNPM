using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class TrangChu_BUS
    {
        private TrangChu_DAO tcDAO;
        public TrangChu_BUS()
        {
            tcDAO = new TrangChu_DAO();
        }

        public string TraVeMaPhong(string username)
        {
            return tcDAO.TraVeMaPhong(username);
        }
        public string TraVeMaSinhVien(string username)
        {
            return tcDAO.TraVeMaSinhVien(username);
        }
        public int LaySoLuongYeuCauSuaChua()
        {
            return tcDAO.LaySoLuongYeuCauSuaChua();
        }
        public int LaySoLuongYeuCauTraPhong()
        {
            return tcDAO.LaySoLuongYeuCauTraPhong();
        }
        public int LaySoLuongYeuCauGiaHan()
        {
            return tcDAO.LaySoLuongYeuCauGiaHan();
        }
    }
}
