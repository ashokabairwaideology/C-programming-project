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

public partial class forget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial catalog=BB;Integrated security=true");
        string id = txt_email.Text;
        string Query = "select * from Registration where EmailID='" + id + "'";
        SqlDataAdapter adpt = new SqlDataAdapter(Query, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count != 0)
        {
            Response.Redirect("~/frgtpswd2.aspx?EmailID=" + id);
        }
        else
        {
            Response.Write("invalid Email id");
        }

    }
}
