using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StoreProcedureWithADO
{
    internal class ProcedureClass
    {
        public void Insert()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand("spInsertStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 109;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "N'Nguyễn Trần Bảo Khánh'";
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = "khanhbaotrannguyeng@gmail.com";
                cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = "0385648740";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                WriteLine("Tiến trình thành công");
            }
            catch (Exception ex)
            {
                WriteLine("Đã có lỗi xảy ra!!" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 107;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "Tien Dung";
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = "nguyenbaokhanh@gmail.com";
                cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = "0385648740";

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                WriteLine("Update Success!");
            }
            catch(Exception ex)
            {
                WriteLine("Đã xảy ra lỗi!!! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = 106;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                WriteLine("Deleted success!");
            }
            catch(Exception ex)
            {
                WriteLine("Đã có lỗi xảy ra! " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
