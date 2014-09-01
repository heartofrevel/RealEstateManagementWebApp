using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserComponent;
using DBConnectionComponent;
using System.Data.SqlClient;
using StringManipComponent;
using ExceptionComponent;

namespace BuyerComponent
{
    public class Buyer:User
    {
        
        internal SqlConnection conn;
        public string error;

        public string Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;
            }
        }

        
        //Constructor
         public Buyer():base("Buyer")
        {
            
        }

        //Override Savedata Method
         public override bool SaveData()
         {
             StringManip s1 = new StringManip();
             name = s1.StrConcat(first_name, last_name);
             CheckAge a1 = new CheckAge();
             try
             {
                 a1.Check(Convert.ToInt32(age));
                 conn = DBConnection.GetConnection();
                 SqlCommand comm = new SqlCommand("INSERT INTO users VALUES('" + name + "','" + gender + "','" + dob + "','" + address + "','" + city + "','" + pin + "','" + phone + "','" + email + "','" + usertype + "','" + username + "','" + password + "'," + Convert.ToInt32(age) + ")", conn);
                 int confirm = comm.ExecuteNonQuery();
                 if (confirm > 0)
                     return true;
                 else
                     return false;
             }
             catch (AgeException age1)
             {
                 error = age1.Errormsg;
                 return false;
             }
         }

    }
} 
