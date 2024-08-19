using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_dental
{
    internal class DbConecction
    {

        public void SendStringRequest(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            SqlCommand cmd = Con.CreateCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataSet ShowTableData(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            SqlConnection Con = MyConnection.GetCon();
            SqlCommand cmd = Con.CreateCommand();
            cmd.Connection = Con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
