using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DBConnectionComponent;
using System.Data.SqlClient;

namespace CitiesComponents
{
    public class Cities
    {
        public List<string> cities = new List<string>();

       
        internal SqlConnection conn;

        public List<string> GetCities() {

            conn = DBConnection.GetConnection();
            SqlCommand comm = new SqlCommand("SELECT city_name FROM cities", conn);
            SqlDataReader rdr = comm.ExecuteReader();

            while (rdr.Read() == true)
            {
                cities.Add(rdr.GetString(0));
            }
            return cities;
        
        }

    }
}
