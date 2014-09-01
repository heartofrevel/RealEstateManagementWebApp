using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoginComponent;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Login1 l1 = new Login1();
        l1.username = txtUsername.Text;
        l1.password = txtPassword.Text;

        if (l1.LoginUser() == true)
        {
            Session["Username"] = l1.username;
            Response.Redirect("Default.aspx");

        }
        else
            lblError.Text = "Invalid Username/Password";
        
    }
}