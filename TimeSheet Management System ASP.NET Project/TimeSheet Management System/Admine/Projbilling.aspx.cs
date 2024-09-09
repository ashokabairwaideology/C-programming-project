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

public partial class Admine_Projbilling : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd, cmd1;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
       /* DataSet ds=new DataSet();
        con.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from billing where projid='"++"'", con);
        
        SqlDataAdapter da2 = new SqlDataAdapter("select * from billing where projid='"++"'", con);

        da1.Fill(ds, "bill");
        da2.Fill(ds,"bill");
        //cmd = new SqlCommand("select * from billing", con);
        //dr = cmd.ExecuteReader();
        //GridView1.DataSource = dr;
        //GridView1.DataBind();
        con.Close();
        */
    }
}
