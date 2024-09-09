using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text == "venu" && txtPassword.Text == "hasini")
        {
            Response.Redirect("adminmodule.aspx");
        }
        else
        {
            SqlCommand cmd = new SqlCommand("select * from register where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("usermodule.aspx");
            }
            
        }
            

    }
}
