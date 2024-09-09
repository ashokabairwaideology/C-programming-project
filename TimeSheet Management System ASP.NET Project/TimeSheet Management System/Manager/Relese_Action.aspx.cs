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

public partial class Manager_Relese_Action : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd, cmd1;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["relid"].ToString();
        string sql = "update assgto set status='Inactive'where allocateid='"+id+"' ";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);

        string sql1 = "update empinsert set status='Active'where empid='" + id + "' ";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql1);

        SqlCommand cmd4 = new SqlCommand("update billing set status='Released' where empid='" +id+ "'", con);
        
        Response.Redirect("~/Manager/relese.aspx");

    }
}
