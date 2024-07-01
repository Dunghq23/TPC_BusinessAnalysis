using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Pizza_Company.DAO 
{
    public class GetDATA
    {
        public GetDATA()
        {
        }

        public string getStringData(string query) {
            SqlConnection connect = Connection.GetSqlConnection();
            connect.Open();
            SqlCommand cmd = new SqlCommand(query, connect);
            

            string str = cmd.ExecuteScalar().ToString();

            connect.Close();

            return str;
        }


    }
}
