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
public partial class Admin_viewans : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string myquery = "select ans_id,answer from tbl_answer where Status='Abused' ";

        SqlDataAdapter adpt = new SqlDataAdapter(myquery, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();

    }
}
