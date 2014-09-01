using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DBConnectionComponent;

namespace UserComponent
{
    public abstract class User
    {
        //Data Members
        public string first_name;
        public string name;
        public string last_name;
        public string gender;
        public string dob;
        public string address;
        public string city;
        public string pin;
        public string phone;
        public string email;
        public string username;
        public string password;
        public string usertype;
        public string age;
        internal SqlConnection conn;

        //Constructor
         public User(string ab)
        {
            usertype = ab;
        }

        //Get Set Properties

        public string First_Name {
            get {
                return first_name;
            }
            set {
                first_name = value;
            }
        }

      
        public string Last_Name
        {
            get
            {
                return last_name;

            }
            set
            {
                last_name = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public string DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }
         //Abstract Function
        public abstract bool SaveData();

    }
}
