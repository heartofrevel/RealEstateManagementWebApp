using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SellerComponent;
using ExceptionComponent;

using StringManipComponent;

public partial class seller : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void btRegister_Click(object sender, EventArgs e)
    {
        Seller u1 = new Seller();
        u1.first_name = txtFirstName.Text;
        
        u1.last_name = txtLastName.Text;
        u1.gender = rbGender.SelectedValue;
        u1.dob = txtDOB.Text;
        u1.address = txtStreetAddress.Text;
        u1.city = txtCity.Text;
        u1.pin = txtPin.Text;
        u1.phone = txtMobile.Text;
        u1.email = txtEmail.Text;
        u1.username = txtUsername.Text;
        u1.password = txtPassword.Text;
        u1.age = txtAge.Text;



        if (u1.SaveData() == true)
        {
            Response.Redirect("registrationDone.aspx");
        }
        else
            lblSqlError.Text = u1.error;
        
    }




   
}