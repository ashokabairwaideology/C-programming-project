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

public partial class MaintenanceManager_VehicleAllocation : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlCommand cmd1;
    SqlDataReader dr;


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";


            string myquery = null;
            myquery = "select * from venderdetails ";
            SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            DropDownList1.DataTextField = "venderName";
            DropDownList1.DataValueField = "venderId";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();




            string myquery1 = null;
            myquery1 = "select * from RouteDetails ";
            SqlDataAdapter adpt1 = new SqlDataAdapter(myquery1, con.ConnectionString);
            DataTable dt1 = new DataTable();
            adpt1.Fill(dt1);

            DropDownList2.DataTextField = "routeid";
            DropDownList2.DataValueField = "routeid";
            DropDownList2.DataSource = dt1;
            DropDownList2.DataBind();


        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string loc_venid = DropDownList1.Text;
        string loc_rutid = DropDownList2.SelectedItem.Text;
        string loc_vehid = DropDownList7.SelectedItem.Text;
        string loc_amount= lbl_total.Text;

        string myquery = null;
        myquery = "insert into Vehicleallocation values('" + loc_venid + "','" + loc_rutid + "','" + loc_vehid + "','" + loc_amount + "','pending')";      
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;

        cmd.ExecuteNonQuery();
        Response.Write("record inserted");

        string myquery1 = null;
        myquery1 = "update vehicledetails set Status='active' where RegNo='" + loc_vehid + "'";
        cmd1 = new SqlCommand();
        cmd1.Connection = con;
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = myquery1;

        cmd1.ExecuteNonQuery();


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string id = DropDownList1.SelectedValue.ToString();

        string myquery = "select * from venderdetails where venderId='" + id + "'";

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            TextBox1.Text = dr[2].ToString();
            TextBox2.Text = dr[3].ToString();
            TextBox3.Text = dr[4].ToString();
            TextBox4.Text = dr[5].ToString();
            TextBox5.Text = dr[6].ToString();


        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
        con.Open();

        string myquery2 = null;
        string rout_id = DropDownList2.SelectedItem.ToString();
        myquery2 = "select * from vehicledetails where RouteId='" + rout_id + "' and Status='inactive'";
        SqlDataAdapter adpt2 = new SqlDataAdapter(myquery2, con.ConnectionString);
        DataTable dt2 = new DataTable();
        adpt2.Fill(dt2);

        DropDownList7.DataTextField = "RegNo";
        DropDownList7.DataValueField = "RegNo";
        DropDownList7.DataSource = dt2;
        DropDownList7.DataBind();




        string id = DropDownList2.Text;

        string myquery = "select * from RouteDetails where routeid='" + id + "'";

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            TextBox13.Text = dr[2].ToString();
            TextBox14.Text = dr[3].ToString();
            TextBox6.Text = dr[4].ToString();
            TextBox17.Text = dr["Distance"].ToString();



        }
        con.Close();
    }
    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string RegNo = DropDownList7.Text;

        string myquery = "select * from vehicledetails where RegNo='" + RegNo + "'";

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            TextBox10.Text = dr[2].ToString();
            TextBox15.Text = dr[3].ToString();
            TextBox11.Text = dr[4].ToString();
            TextBox18.Text = dr["Daily_rent"].ToString();
            TextBox12.Text = dr[5].ToString();
            TextBox7.Text = dr[6].ToString();
            TextBox16.Text = dr[7].ToString();
           



        }
        con.Close();
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        double distance = Convert.ToDouble(TextBox17.Text);
        double Rate_km = Convert.ToDouble(TextBox12.Text);
        double days = Convert.ToDouble(TextBox19.Text);
        double Dailyrent =Convert.ToDouble( TextBox18.Text);

        lbl_CarRent.Text = (days * Dailyrent).ToString();
        lbl_DisAmount.Text =( distance * Rate_km).ToString();
        lbl_total.Text = ((days * Dailyrent) + (distance * Rate_km)).ToString();



    }
    protected void TextBox18_TextChanged(object sender, EventArgs e)
    {

    }
}
