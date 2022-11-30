using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHAN_MEM_QUAN_LY_KTX_CNPM.Provider;
using System.Data;
using System.Data.SqlClient;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.DAO
{
    public class Phong_DAO
    {
        private DataProvider cnn = null;
        public Phong_DAO()
        {
            cnn = new DataProvider();
        }
        public DataTable GetAllInformation()
        {
            //SqlParameter[] sqlParameters = new SqlParameter[0]; 
            return cnn.executeLoadData("SELECT * FROM func_DanhSachPhong()");
        }
    }
}
