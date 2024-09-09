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

public partial class MovementManager_CityDetails : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string loc_city = TextBox1.Text;
        string loc_code = TextBox2.Text;
        string myquery = null;

        myquery = "insert into AddCitys values('" + loc_city + "','" + loc_code + "')";
         cmd = new SqlCommand();
         cmd.Connection = con;
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = myquery;
         cmd.ExecuteNonQuery();
         Response.Write("Record Inserted...");
         con.Close();
    }
}
