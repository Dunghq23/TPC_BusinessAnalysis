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
    class ExQuery

    {
        public ExQuery() { }
        #region Thêm, sửa, xóa dữ liệu
        public DataTable ExcuteQuery(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                table.Clear();
                adapter.Fill(table);
                sqlConnection.Close();
            }
            return table;
        }



        public void insertData(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand(query, sqlConnection);
                insertCMD.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void editData(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand editCMD = new SqlCommand(query, sqlConnection);
                editCMD.ExecuteNonQuery();
                editCMD.CommandType = CommandType.Text;
                sqlConnection.Close();
            }
        }
        public void deleteData(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand deleteCMD = new SqlCommand(query, sqlConnection);
                deleteCMD.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        #endregion
    }
}
