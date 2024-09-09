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

public partial class Admine_empid : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlDataReader dr;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string frname = Request.QueryString["fname"];
        llb_fname.Text = frname;
        SqlCommand cmd = new SqlCommand("select * from Empinsert where firstname='" + llb_fname.Text + "'", con);
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            llb_id.Text = dr[1].ToString();
        }
    }
}
