using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Cần khai báo thư viện Data

namespace The_Pizza_Company.DAO
{
    internal class Connection
    {
        private static string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=THEPIZZACOMPANY;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionSTR);
        }
    }
}
