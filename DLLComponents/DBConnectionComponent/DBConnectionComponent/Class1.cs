using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DBConnectionComponent
{
    public class DBConnection
    {
        
        public static SqlConnection GetConnection() { 
        SqlConnection conn =new SqlConnection("Data Source=SECXPLRD\\SQLEXPRESS;Initial Catalog=real_estate_mgmt;User ID=sa;Password=secxplrd");
            conn.Open();
            return conn;
        }
    }
}
