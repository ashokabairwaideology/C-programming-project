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

public partial class Status : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cargoConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnStatus_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from statusreport where customerid=" + txtCustomerid.Text   + " and customername='" + txtCustomername.Text   + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "statusreport");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();

    }
}
