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

public partial class Admin_ViewProfile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string name = Session["UserName"].ToString();
        string sql1 = "select * from Registration where UserName='" + name + "'";

        SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        lbl_name.Text = dt.Rows[0]["FirstName"].ToString();
        lbl_uname.Text = dt.Rows[0]["UserName"].ToString();
        lbl_emailid.Text = dt.Rows[0]["EmailID"].ToString();
        lbl_dob.Text = dt.Rows[0]["DOB"].ToString();
        lbl_ph.Text = dt.Rows[0]["PhoneNo"].ToString();

    }
    
}
