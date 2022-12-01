using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.DAO
{
    public class ThongBao_DAO
    {
        private DataProvider cnn = null;
        public ThongBao_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetInformation()
        {
            return cnn.executeLoadData("SELECT * FROM func_DanhsachThongBao() order by NgayDang");
        }
        public void GuiThongBao(string tieude, string noidung, DateTime ngaydang)
        {
            string sql = "proc_GuiThongBao";
            string[] pNames = { "@tieude", "@noidung", "@ngaydang" };
            object[] pvalues = { tieude, noidung, ngaydang};
            cnn.ExecuteStoredProcedure_Update(sql, pNames, pvalues);
        }
    }
}
