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

public partial class Forget_Password : System.Web.UI.Page
{
    SqlConnection con;
    //SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

        lbl_psw.Visible = false;
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_email = TextBox1.Text;
        lbl_psw.Visible = true;
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string myquery = "select * from ManagerCreation where EmailID='" + loc_email + "'";

        SqlDataAdapter da = new SqlDataAdapter(myquery,con);
        DataTable dt = new DataTable();
        da.Fill(dt);

        lbl_psw.Text = dt.Rows[0]["Password"].ToString();

    }
}
