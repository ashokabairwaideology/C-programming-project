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

public partial class User_change_password : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd;
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string oldpwd = TextBox1.Text;
        string newpwd = TextBox2.Text;
        string cnewpwd = TextBox3.Text;
        con.Open();
        string myquery = "update  Registration set Password='" + newpwd + "', ConPassword='" + cnewpwd + "' where Password='" + oldpwd + "'";

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Label6.Text = "your password is changed successfully";
      //  Response.Write("password is updates");
        
    }
}
