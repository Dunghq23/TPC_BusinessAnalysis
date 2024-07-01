using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;
using System.Windows.Forms;

namespace The_Pizza_Company.DAO
{
    class Modify
    {
        public Modify ()
        {

        }

        // SqlCommand: dùng để truy vấn các câu lệnh SQL
        SqlCommand sqlCommand;
        // SqlDataReader: dùng để đọc dữ liệu trong bảng
        SqlDataReader dataReader;
        public List<Account> Accounts (string query)
        {
            List<Account> accounts = new List<Account> ();
            using(SqlConnection sqlConnection = Connection.GetSqlConnection()) { 
                sqlConnection.Open ();
                sqlCommand = new SqlCommand (query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read()) 
                {
                    // GetString(0): Lấy giá trị cột thứ nhất (Nếu INT thì dùng GetInt)
                    accounts.Add (new Account (dataReader.GetString(5), dataReader.GetString(6)));

                }
                sqlConnection.Close();
            }
            return accounts;
        }

        public void Command (string query) // dùng để đăng ký tài khoản
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open ();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery (); // Thực thi câu truy vấn
                sqlConnection.Close();
            }
        }

        



    }
}
