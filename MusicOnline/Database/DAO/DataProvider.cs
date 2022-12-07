using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicOnline.Database.DAO
{
    public class DataProvider
    {
        private string StringConnection = "Data Source=HIIMKINNNNN\\SQLEXPRESS;Initial Catalog=MovieOnline;Integrated Security=True";

        // SELECT
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(StringConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        // UPDATA / DELETE / INSERT
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(StringConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            data = command.ExecuteNonQuery();
            connection.Close();
            return data;
        }


        // COUNT
        public object ExecuteScalar(string query)
        {
            object data = 0;
            SqlConnection connection = new SqlConnection(StringConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            data = command.ExecuteScalar();
            connection.Close();
            return data;
        }
    }
}
