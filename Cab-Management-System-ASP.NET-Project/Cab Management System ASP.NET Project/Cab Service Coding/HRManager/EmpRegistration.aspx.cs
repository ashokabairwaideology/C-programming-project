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



public partial class HRManager_EmpRegistration : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string loc_name = TextBox1.Text;
        string loc_pass = TextBox12.Text;
        string loc_canadd = TextBox2.Text;
        string loc_quali = TextBox3.Text;
        string loc_dob = TextBox4.Text;
       
        string loc_gen = RadioButtonList1.Text;
        string loc_phno = TextBox6.Text;
        string loc_desig = DropDownList1.Text;
        string loc_dep = DropDownList2.Text;
        string loc_doj = TextBox7.Text;
        string loc_sta = TextBox8.Text;
        string loc_age = TextBox9.Text;
        string loc_timesp = TextBox10.Text;
        string loc_imgpat = FileUpload2.FileName;
        string loc_exp = TextBox13.Text;
        string loc_licno = TextBox14.Text;
        string loc_acc = TextBox15.Text;

        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "insert into EmployeDetails values(' ','" + loc_name + "','" + loc_pass + "','" + loc_canadd + "','" + loc_quali + "','" + loc_dob + "','" + loc_gen + "','" + loc_phno + "','" + loc_desig + "','" + loc_dep + "','" + loc_doj + "','" + loc_sta + "','" + loc_age + "','" + loc_timesp + "','" + loc_imgpat + "','" + loc_exp + "','" + loc_licno + "','" + loc_acc + "');" + " SELECT @@IDENTITY";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        int Eid = Convert.ToInt32(cmd.ExecuteScalar());
        string empid = loc_name[0].ToString()+Eid;

        string update = "update EmployeDetails set EmpId='" + empid + "' where EId='" + Eid + "'";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = update;
        cmd.ExecuteScalar();
        Response.Write("Record updated...");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/HRManager/EmpRegistration.aspx");

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
        if (DropDownList1.SelectedItem.ToString() == "Driver")
            Panel1.Visible = true;
        }
    }

