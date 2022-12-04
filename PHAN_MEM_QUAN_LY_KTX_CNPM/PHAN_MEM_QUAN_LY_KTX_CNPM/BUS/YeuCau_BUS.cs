using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class YeuCau_BUS
    {
        private YeuCau_DAO ycDAO;
        public YeuCau_BUS()
        {
            ycDAO = new YeuCau_DAO();
        }
        public int ThemGiaHan(string masinhvien, int soky, string trangthai)
        {
            return ycDAO.ThemGiaHan(masinhvien, soky, trangthai);
        }
        public int ThemTraPhong(string maphong, string masinhvien, DateTime ngaytra, string trangthai)
        {
            return ycDAO.ThemTraPhong(maphong, masinhvien, ngaytra, trangthai);
        }
        public int ThemSuaChua(string tenthietbi, int soluong, string chitiet, string trangthai)
        {
            return ycDAO.ThemSuaChua(tenthietbi, soluong, chitiet, trangthai);
        }
        public int CapNhatTrangThaiGiaHan(int id, string trangthai)
        {
            return ycDAO.CapNhatTrangThaiGiaHan(id, trangthai);
        }
        public int CapNhatTrangThaiTraPhong(int id, string trangthai)
        {
            return ycDAO.CapNhatTrangThaiTraPhong(id, trangthai);
        }
        public int CapNhatTrangThaiSuaChua(int id, string trangthai)
        {
            return ycDAO.CapNhatTrangThaiSuaChua(id, trangthai);
        }
        public int XoaYeuCauSuaChua(int id)
        {
            return ycDAO.XoaYeuCauSuaChua(id);
        }
        public int XoaYeuCauGiaHan(int id)
        {
            return ycDAO.XoaYeuCauGiaHan(id);
        }
        public int XoaYeuCauTraPhong(int id)
        {
            return ycDAO.XoaYeuCauTraPhong(id);
        }
        public DataTable DanhSachYeuCauTraPhong()
        {
            return ycDAO.DanhSachYeuCauTraPhong();
        }
        public DataTable DanhSachYeuCauGiaHan()
        {
            return ycDAO.DanhSachYeuCauGiaHan();
        }
        public DataTable DanhSachYeuCauSuaChua()
        {
            return ycDAO.DanhSachYeuCauSuaChua();
        }
        public DataTable DanhSachTenThietBi()
        {
            return ycDAO.DanhSachTenThietBi();
        }
    }
}
