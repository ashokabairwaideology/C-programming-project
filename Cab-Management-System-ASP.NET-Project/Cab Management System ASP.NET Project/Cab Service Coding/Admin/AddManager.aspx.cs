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


public partial class Admin_AddManager : System.Web.UI.Page
{


    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string loc_Mn = TextBox1.Text;
        string loc_pwd = TextBox11.Text;
        string loc_add = TextBox2.Text;
        string loc_qua = TextBox3.Text;
        string loc_dob = TextBox4.Text;
        string loc_gen = RadioButtonList1.Text;
        string loc_pno = TextBox5.Text;
        string loc_em = TextBox6.Text;
        string loc_desig = DropDownList1.Text;
        string loc_dep = DropDownList2.Text;
        string loc_doj = TextBox9.Text;
        string loc_age = TextBox10.Text;

        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "insert into ManagerCreation values('" + loc_Mn + "','" + loc_pwd + "','" + loc_add + "','" + loc_qua + "','" + loc_dob + "','" + loc_gen + "','" + loc_pno + "','" + loc_em + "','" + loc_desig + "','" + loc_dep + "','" + loc_doj + "','" + loc_age + "')";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Write("Record Inserted...");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/AddManager.aspx");
    }
}
