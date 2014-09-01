using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DBConnectionComponent;

namespace DisplayUserComponent
{
    public class DisplayUser
    {
        internal SqlConnection conn;

        public DataSet DisplayUsers() {
            conn = DBConnection.GetConnection();
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT first_name,middle_name,last_name,gender,dob,address FROM users", conn);
            da.Fill(ds);
            return ds;
        
        }
    }
}
