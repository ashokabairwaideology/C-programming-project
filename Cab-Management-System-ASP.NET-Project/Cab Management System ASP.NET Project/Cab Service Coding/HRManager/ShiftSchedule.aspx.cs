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

public partial class HRManager_ShiftSchedule : System.Web.UI.Page
{

    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
            con.Open();


            string myquery1 = "select * from EmployeDetails ";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery1;
            dr = cmd.ExecuteReader();
            
            DropDownList1.Items.Insert(0, "<--Select-->");
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr["EId"].ToString());
                

            }
            con.Close();
        }



        if (!IsPostBack)
        {
            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
            con.Open();

            string myquery2 = "select * from ShiftTimeing ";

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery2;
            dr = cmd.ExecuteReader();
            DropDownList3.Items.Insert(0, "<--Select-->");

            while (dr.Read())
            {
                DropDownList3.Items.Add(dr["ShiftId"].ToString());

            }
            con.Close();
        }
        if (!IsPostBack)
        {

            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
            con.Open();


            string myquery1 = "select * from RouteDetails ";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery1;
            dr = cmd.ExecuteReader();
            DropDownList4.Items.Insert(0, "<--Select-->");
            while (dr.Read())
            {
                DropDownList4.Items.Add(dr["RTID"].ToString());

            }
            con.Close();

        }
    }


    
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_EID = DropDownList1.Text;
        string loc_DEP = TextBox1.Text;
        
        string loc_ENAME = TextBox2.Text;
        string loc_SID = DropDownList3.Text;
        string loc_RID = DropDownList4.Text;
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "insert into  ShiftSchedule values('" + loc_EID + "','" + loc_DEP + "','" + loc_ENAME + "','" + loc_SID + "','" + loc_RID + "')";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Write("Record Inserted...");
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

            con = new SqlConnection();
            con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
            con.Open();

            string id = DropDownList1.Text;

            string myquery = "select * from EmployeDetails where EId='" + id + "'";

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery;
            dr = cmd.ExecuteReader();
        while (dr.Read ())
        {

            TextBox1.Text =dr[10].ToString();


        }

        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/HRManager/ShiftSchedule.aspx");
    }
}
