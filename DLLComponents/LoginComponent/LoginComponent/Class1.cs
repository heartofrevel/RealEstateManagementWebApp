using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DBConnectionComponent;
using StringManipComponent;

namespace LoginComponent
{
    public class Login1
    {
        public string username;
        public string password;
       
        
        internal SqlConnection conn;

        //=========Get - Set Attributes =======//

        public string Username {
            get {
                return username;
            }
            set {
                username = value;
            }
        }

        public string Password {
            get {
                return password;
            }
            set {
                password = value;
            }
        }

        //Login Function//
        public bool LoginUser(){
            conn = DBConnection.GetConnection();
            SqlCommand comm = new SqlCommand("SELECT name FROM users WHERE username='" + username + "' and password='" + password + "'", conn);
            SqlDataReader rdr = comm.ExecuteReader();

            if (rdr.Read() == true)
            {
                StringManip s1 = new StringManip();
                string ab = rdr.GetString(0);
                username = s1.StrSplit(ab);
                return true;
            }
            else
                return false;

        
        }

    }
}
