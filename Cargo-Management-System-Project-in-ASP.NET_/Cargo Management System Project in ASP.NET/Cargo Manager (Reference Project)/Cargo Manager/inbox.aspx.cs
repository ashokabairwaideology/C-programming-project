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

public partial class inbox : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cargoConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
       
        SqlDataAdapter da = new SqlDataAdapter("select * from conformationmail", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "conformationmail");
        GridView1.DataSource = ds;
        GridView1.DataBind();
       
    }

   
}
