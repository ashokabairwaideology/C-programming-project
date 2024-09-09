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

public partial class register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa; password=sqlserver");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        con.Open();
        string s = "insert into register values('" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtPhoneno.Text + "','" + txtEmailid.Text + "')";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        Label5.Visible = true; 
        con.Close();

    }
}
