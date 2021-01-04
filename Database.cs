using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalTermAssignment
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connString = "Server=DESKTOP-01TA4PH\\SQLEXPRESS;integrated security = True;Database = OOP2Assignment.";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public DataSet getData(String query)
        {
            SqlConnection conn = ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String message)
        {
            SqlConnection conn = ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" '" + message + "' ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn = ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
