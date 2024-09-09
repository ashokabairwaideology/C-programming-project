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

public partial class FinancialManager_VenderBilling : System.Web.UI.Page
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


            string myquery1 = "select * from Vehicleallocation ";
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery1;
            dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                DropDownList1.Items.Insert(i, dr["venid"].ToString());
                i++;
            }
            con.Close();
        }
    }

    protected void  DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
{

   
}
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string id = DropDownList1.Text;

        string myquery = "select * from Vehicleallocation where venid='" + id + "'";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {

            TextBox2.Text = dr[4].ToString();


        }

        con.Close();
    }
}
