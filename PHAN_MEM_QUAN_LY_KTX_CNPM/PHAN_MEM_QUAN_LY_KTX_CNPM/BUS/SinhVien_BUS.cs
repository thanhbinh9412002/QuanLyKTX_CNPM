using PHAN_MEM_QUAN_LY_KTX_CNPM.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.BUS
{
    public class SinhVien_BUS
    {
        private SinhVien_DAO SinhvienDAO = new SinhVien_DAO();
        public SinhVien_BUS()
        { }
        public DataTable Danhsachsinhvien()
        {
            return SinhvienDAO.Xuatdanhsachsinhvien();
        }
        public void Themsinhvien(string mssv, string hoten, string sdt, string gioitinh, int namhoc, string tongiao, string quoctich, string cccd, string maphong, int soky)
        {
            SinhvienDAO.Themsinhvien(mssv, hoten, sdt, gioitinh, namhoc, tongiao, quoctich, cccd, maphong, soky);
        }
        public void Suasinhvien(string mssv, string hoten, string sdt, string gioitinh, int namhoc, string tongiao, string quoctich, string cccd, string maphong, int soky)
        {
            SinhvienDAO.Suasinhvien(mssv, hoten, sdt, gioitinh, namhoc, tongiao, quoctich, cccd, maphong, soky);
        }
        public void Xoasinhvien(string mssv)
        {
            SinhvienDAO.Xoasinhvien(mssv);
        }
        public DataTable thongtincanhan(string mssv)
        {
            return SinhvienDAO.tablethongtin(mssv);
        }

    }
}
