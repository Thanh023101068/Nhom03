using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManHinhChinhQuanTri
{
    internal class Database
    {
        public static string ConnectionString = @"Data Source=ASUS15\SQLEXPRESS;Initial Catalog=QLPM;Integrated Security=True";

        public static DataTable GetDataTable(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
