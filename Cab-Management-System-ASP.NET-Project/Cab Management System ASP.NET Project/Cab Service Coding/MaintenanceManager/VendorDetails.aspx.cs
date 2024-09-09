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

public partial class MaintenanceManager_VendorDetails : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        string loc_vendname = TextBox1.Text;
        string loc_vendadd = TextBox2.Text;
        string loc_ph = TextBox3.Text;
        string loc_email = TextBox4.Text;
        string loc_remark = TextBox5.Text;
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "insert into venderdetails values(' ','" + loc_vendname + "','" + loc_vendadd + "','" + loc_ph + "','" + loc_email + "','" + loc_remark + "')" +"SELECT @@IDENTITY";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        int loc_vid = Convert.ToInt32(cmd.ExecuteScalar());
        
        string venid = loc_vendname[0].ToString() + loc_vid;


        string update = "update venderdetails set venderId='" + venid + "' where vid=" + loc_vid + "";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = update;
        cmd.ExecuteScalar();
        Response.Write("Record Inserted...");
    }
}
