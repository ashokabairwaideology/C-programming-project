using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class customerdetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox10.Text = DateTime.Now.ToShortTimeString();
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Custmerdetails1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList2.SelectedItem + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "')",con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label14.Text = "submitted successfully";

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox11.Text = Calendar1.SelectedDate.ToShortDateString();
     
    }
}
