using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clinica_dental
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaar_\OneDrive\Documents\DentalDb.mdf;Integrated Security=True;Connect Timeout=30";
            return Con;
        }
    }
}
