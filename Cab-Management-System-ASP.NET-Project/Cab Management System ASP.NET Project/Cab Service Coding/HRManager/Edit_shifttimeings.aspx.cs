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

public partial class HRManager_Edit_shiftDetails : System.Web.UI.Page
{
    SqlConnection con,con1;
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {

        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";

        string Shiftid=Request.QueryString["Shiftid"].ToString();
        string myquery = null;
        myquery = "select * from ShiftTimeing where Sid='" + Shiftid + "' ";
         SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
            DataTable dt = new DataTable();
            adpt.Fill(dt);


            TextBox5.Text = dt.Rows[0]["ShiftId"].ToString();
            TextBox1.Text = dt.Rows[0]["ShiftName"].ToString();
        TextBox2.Text = dt.Rows[0]["StartingTime"].ToString();
        TextBox3.Text = dt.Rows[0]["DispatchTime"].ToString();
        TextBox4.Text = dt.Rows[0]["NoBatchs"].ToString();
    }




    
    protected void Button3_Click(object sender, EventArgs e)
    {  

        string id = Request.QueryString["Shiftid"].ToString();
        con1 = new SqlConnection();
        con1.ConnectionString = "data source=raj-pc\\sqlexpress;initial catalog=cool cabs;integrated security=true";
        con1.Open();
        string myquery = null;
        myquery = "update ShiftTimeing set ShiftId='" + TextBox5.Text + "',ShiftName='" + TextBox1.Text + "',StartingTime='" + TextBox2.Text + "',DispatchTime='" + TextBox3.Text + "',NoBatchs='" + TextBox4.Text + "'where Sid='" + id + "'";
       
        cmd=new SqlCommand() ;
        cmd.Connection = con1;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Redirect("~/HRManager/ViewShiftTimings.aspx");
    }
}
