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


public partial class Admin_Delete : System.Web.UI.Page
{
    SqlConnection con=new SqlConnection( @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd= new SqlCommand();


    protected void Page_Load(object sender, EventArgs e)
    {
        
        string id= Request.QueryString["ManagerId"].ToString();
        
        con.Open();
        string myquery = null;
        myquery = " delete from ManagerCreation where ManagerId='" + id + "'";
        
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Redirect("~/Admin/view managers.aspx");



    }
}
