using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_visual.DAL
{
    internal class CLS_DAL
    {
        SqlConnection con = new SqlConnection();
        public CLS_DAL()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FCI\Level 3\2nd Term\visual project1-3-1\visual project1-3\visual project1\visual project1\Project_visual\DBLIBM.mdf;Integrated Security=True");
        }
        // Method to open sqlcon
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        // Method to close sqlcon
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        // Function to read data
        public DataTable read(String store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Excute To Insert , Edit , Delete
        public void Excute(String store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
