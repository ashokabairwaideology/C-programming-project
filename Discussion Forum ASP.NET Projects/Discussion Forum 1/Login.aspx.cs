using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


public partial class home : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
       // Session.Abandon();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_userid = txt_login.Text;
        string loc_pswd = txt_pswd.Text;

        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial catalog=BB;Integrated security=true");

        string sql1 = "select *from  Registration where UserName='" + loc_userid + "'and Password='" + loc_pswd + "' ";

        SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        if (dt.Rows.Count == 1)
        {
            Session["UserName"] = loc_userid;

            if (dt.Rows[0]["position"].ToString() == "Admin")
            {

                Response.Redirect("~/Admin/adminhome.aspx");
            }
            else if (dt.Rows[0]["position"].ToString() == "User")
            {
                Response.Redirect("~/User/userhome.aspx");
            }

        }
        else
        {
        }


            con.Close();

        }


    protected void LinkButton7_Click(object sender, EventArgs e)
    {

    }
}
