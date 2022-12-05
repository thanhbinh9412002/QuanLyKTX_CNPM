using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHAN_MEM_QUAN_LY_KTX_CNPM.Provider
{
   
    public class DataProvider
    {
        private SqlConnection connection;
        //public string connect = @"Data Source=THANHBINH\SQLEXPRESS;Initial Catalog=KTX;Integrated Security=True";
        public string connect = @"Data Source=LAPTOP-MB5F72F2\SQLEXPRESS;Initial Catalog=KTX;Integrated Security=True";
        //public string connect = @"Data Source=DESKTOP-JBR423G;Initial Catalog=KTX;Integrated Security=True";
        public DataProvider()
        {
            connection = new SqlConnection(connect);
        }

        private SqlConnection openConnection()
        {

            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }

        public DataTable ExecuteProcedureDatatable(string spName, string[] pNames, object[] pValues)
        {
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            DataTable dt = new DataTable();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dataReader);
            return dt;
        }

        public DataTable executeReader(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameter);
                DataTable dt = new DataTable();
                try
                {
                    SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    dt.Load(dataReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
        public DataTable executeLoadData(string query)      // trả về bảng dữ liệu
        {
            using (SqlCommand command = new SqlCommand(query, openConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        reader.Close();
                    }
                    return dt;
                }
            }
        }

        public int ExecuteStoredProcedure(string spName, string[] pNames, object[] pValues) //trả về 1 giá trị khi gọi procedure bên sql

        {
            int kq = 0;
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            SqlParameter n = new SqlParameter("@kq", SqlDbType.Int);
            n.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(n);
            cmd.ExecuteScalar();
            kq = (Int32)n.Value;
            connection.Close();
            return kq;
        }
        public double ExecuteStoredProcedure_float(string spName, string[] pNames, object[] pValues) //trả về 1 giá trị khi gọi procedure bên sql

        {
            double kq = 0;
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            SqlParameter n = new SqlParameter("@kq", SqlDbType.Float);
            n.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(n);
            cmd.ExecuteScalar();
            kq = (Double)n.Value;
            connection.Close();
            return kq;
        }
        public string ExecuteStoredProcedureString(string spName, string[] pNames, object[] pValues) //trả về 1 giá trị khi gọi procedure bên sql

        {
            string kq = "";
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            SqlParameter n = new SqlParameter("@kq", SqlDbType.VarChar);
            n.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(n);
            cmd.ExecuteScalar();
            kq = Convert.ToString(n.Value);
            connection.Close();
            return kq;
        }

        public int ExecuteStoredProcedure_Update(string spName, string[] pNames, object[] pValues) //thêm, xóa, sửa khi gọi procedure bên sql

        {
            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo tham số SqlParameter
            SqlParameter p;
            // Khởi tạo danh sách các tham số với giá trị tương ứng
            for (int i = 0; i < pNames.Length; i++)
            {
                p = new SqlParameter(pNames[i], pValues[i]);
                cmd.Parameters.Add(p);
            }
            return cmd.ExecuteNonQuery();
        }
        public DataTable ExecuteProcedureDatatableNoPara(string spName) //trả về 1 bảng khi gọi procedure bên sql
        {

            openConnection();
            // Khai báo và khởi tạo đối tượng Command với tham số tên thủ tục spName
            SqlCommand cmd = new SqlCommand(spName, connection);
            // Khai báo kiểu thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dataReader);
            return dt;

        }
    }
}
