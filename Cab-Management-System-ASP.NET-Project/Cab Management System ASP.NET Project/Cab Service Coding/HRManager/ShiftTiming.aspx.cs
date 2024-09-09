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


public partial class HRManager_ShiftTiming : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string loc_SID = TextBox5.Text;
        string loc_SN = TextBox1.Text;
        string loc_ST = TextBox2.Text;
        string loc_DISP = TextBox3.Text;
        string loc_TNOB = TextBox4.Text;


        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;

        myquery = "insert into ShiftTimeing values('"+loc_SID+"','" + loc_SN + "','" + loc_ST + "','" + loc_DISP + "','" + loc_TNOB + "')";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Write("Record Inserted...");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/HRManager/ShiftTiming.aspx");
    }
}
