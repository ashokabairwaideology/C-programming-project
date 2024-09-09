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

public partial class MaintenanceManager_SparePartDetails : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_sprpartid = TextBox8.Text;
        string loc_sprpartname = TextBox1.Text;
        string loc_delname = TextBox2.Text;
        string loc_sptype = TextBox3.Text;
        string loc_quantity = TextBox4.Text;
        string loc_Dopur = TextBox5.Text;
        string loc_price = TextBox6.Text;
        string loc_amount = TextBox7.Text;

        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "insert into SparepartDetails values('" + loc_sprpartid + "','" + loc_sprpartname + "','" + loc_delname + "','" + loc_sptype + "','" + loc_quantity + "','" + loc_Dopur + "','" + loc_price + "','" + loc_amount + "')";

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Write("Record Inserted...");
    }
}
