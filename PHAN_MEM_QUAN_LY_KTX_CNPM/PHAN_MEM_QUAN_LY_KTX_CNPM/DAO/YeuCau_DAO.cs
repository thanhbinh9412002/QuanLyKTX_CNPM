using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM
{
    internal class YeuCau_DAO
    {
        private DataProvider cnn = null;
        public YeuCau_DAO()
        {
            cnn = new DataProvider();
        }
        public int ThemGiaHan(string masinhvien, int soky, string trangthai)
        {
            string spName = "[dbo].[ThemYeuCauGiaHan]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@masinhvien","@soky", "@trangthai" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { masinhvien, soky, trangthai};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int ThemTraPhong(string maphong, string masinhvien, DateTime ngaytra, string trangthai)
        {
            string spName = "[dbo].[ThemYeuCauTraPhong]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@maphong", "@masinhvien", "@ngaytra", "@trangthai" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { maphong ,masinhvien, ngaytra, trangthai };
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int ThemSuaChua(string tenthietbi, int soluong, string chitiet, string trangthai)
        {
            string spName = "[dbo].[ThemYeuCauSuaChua]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@tenthietbi", "@soluong", "@chitiet", "@trangthai" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = {tenthietbi, soluong, chitiet, trangthai};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int CapNhatTrangThaiGiaHan(int id, string trangthai)
        {
            string spName = "[dbo].[CapnhattrangThaiGiaHan]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@id", "@trangthai" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = {id, trangthai };
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int CapNhatTrangThaiTraPhong(int id, string trangthai)
        {
            string spName = "[dbo].[CapnhattrangThaiTraPhong]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@id", "@trangthai" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { id, trangthai };
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int CapNhatTrangThaiSuaChua(int id, string trangthai)
        {
            string spName = "[dbo].[CapnhattrangThaiSuaChua]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@id", "@trangthai" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { id, trangthai };
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int XoaYeuCauSuaChua(int id)
        {
            string spName = "[dbo].[proc_XoaYeuCauSuaChua]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@id" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { id};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int XoaYeuCauTraPhong(int id)
        {
            string spName = "[dbo].[proc_XoaYeuCauTraPhong]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@id" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { id};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public int XoaYeuCauGiaHan(int id)
        {
            string spName = "[dbo].[proc_XoaYeuCauGiaHan]"; // Tên hàm
            // Tên các tham số trong thủ tục
            string[] pNames = { "@id" };
            // Giá trị tương ứng muốn gán cho từng tham số trên
            object[] pValues = { id};
            int count = cnn.ExecuteStoredProcedure_Update(spName, pNames, pValues);
            return count;
        }
        public DataTable DanhSachYeuCauGiaHan()
        {
            string spName = "[dbo].[proc_DanhSachGiaHan]";
            return cnn.ExecuteProcedureDatatableNoPara(spName);
        }
        public DataTable DanhSachYeuCauTraPhong()
        {
            string spName = "[dbo].[proc_DanhSachTraPhong]";
            return cnn.ExecuteProcedureDatatableNoPara(spName);
        }
        public DataTable DanhSachYeuCauSuaChua()
        {
            string spName = "[dbo].[proc_DanhSachSuaChua]";
            return cnn.ExecuteProcedureDatatableNoPara(spName);
        }
        public DataTable DanhSachTenThietBi()
        {
            string spName = "[dbo].[proc_TenThietBi]";
            return cnn.ExecuteProcedureDatatableNoPara(spName);
        }
    }
}
