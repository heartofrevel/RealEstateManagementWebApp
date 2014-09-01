using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DisplayUserComponent;

public partial class DisplayAllUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayUser d1 = new DisplayUser();
        GridView1.DataSource = d1.DisplayUsers();
        GridView1.DataBind();


    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}