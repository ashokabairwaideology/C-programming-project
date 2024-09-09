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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string gender;
        if (rbtnamale.Checked)
            gender = "male";
        else
            gender = "female";



        string cnstr = ConfigurationSettings.AppSettings["dbconnection"];

        SqlConnection cn = new SqlConnection(cnstr);

        string str = "insert into newregistration values('" + txtname.Text + "','" + txtsurname.Text + "','" + txtpwd.Text + "','" + txtconpwd.Text + "','" + txtdob.Text + "','" + gender + "','" + txtmailid.Text + "','" + txtaltemailid.Text + "','" + txtotherdett.Text + "') ";
        SqlCommand cmd = new SqlCommand(str, cn);
        cn.Open();
        cmd.ExecuteNonQuery();

        Session["newregistration"] = txtmailid.Text;

        Response.Write("<script>alert('inserted')</script>");
        

        cn.Close();


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("userlogin.aspx");
    }
}
