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
public partial class MovementManager_DriverShiftDetails : System.Web.UI.Page
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


            string myquery1 = "select * from DriverDetails ";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery1;
            dr = cmd.ExecuteReader();
            // int i = 0;
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr["DId"].ToString());
                //i++;
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
                    //int n = 0;
                    while (dr.Read())
                    {
                        DropDownList2.Items.Add( dr["ShiftId"].ToString());
                       // n++;
                    }
                    con.Close();
                }
        }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString= @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
            con.Open();

            string id = DropDownList1.Text;

            string myquery =null;
        myquery="select * from DriverDetails where DId='"+id+"'";

            cmd=new SqlCommand();
        cmd.Connection=con;
        cmd.CommandType=CommandType.Text ;
        cmd.CommandText=myquery ;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            TextBox1.Text = dr[2].ToString();


        }

        con.Close();
       


    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
        con.Open();
        string loc_date=TextBox2.Text;
        string loc_did=DropDownList1.Text;
         string loc_dname=TextBox1.Text;
            string loc_sid=DropDownList2.Text;
            string loc_fp=RadioButtonList1.Text ;


        string myquery = null;
        myquery = " insert into DriverDetails values('" + loc_did + "','" + loc_dname + "','" + loc_sid + "','" + loc_date + "','" + loc_fp + "')";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();

        Response.Write("record inserted");

        con.Close();

    }
}

