using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Admin_AdminMasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = Session["UserName"].ToString();

        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;;Initial catalog=BB;Integrated security=true");
        string id = Session["UserName"].ToString();
        string sql = "select * from Registration where UserName='" + id + "' ";
        SqlDataAdapter adpt = new SqlDataAdapter(sql,con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);


        Image1.ImageUrl = dt.Rows[0]["imgpath"].ToString();

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
}
