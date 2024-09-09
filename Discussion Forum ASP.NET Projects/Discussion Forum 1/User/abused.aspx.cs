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

public partial class User_abused : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string Ans_id = Request.QueryString["ans_id"];
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string myquery = "update tbl_answer set Status='Abused' where ans_id='" + Ans_id + "' ";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();

        Response.Redirect("~/User/ViewAnswer.aspx");

    }
}
