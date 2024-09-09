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


public partial class passwordrecovery : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select password from register where username='" + txtUsername.Text + "' and phoneno='" + txtPhoneno.Text + "'",con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            lblPassword.Text = Convert.ToString(dr["password"]);
        }

        

    }
}
