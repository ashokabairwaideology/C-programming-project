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

public partial class MaintenanceManager_Editvehicledetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["vechid"].ToString();

            con.Open();
            string myquery = null;
            myquery = "select *from vehicledetails where RegNo='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox9.Text = dt.Rows[0]["vehNo"].ToString();
            TextBox1.Text = dt.Rows[0]["vehName"].ToString();
            RadioButtonList1.Text = dt.Rows[0]["vehType"].ToString();
            TextBox5.Text = dt.Rows[0]["RegNo"].ToString();
            TextBox10.Text = dt.Rows[0]["Rate_per_km"].ToString();
            TextBox11.Text = dt.Rows[0]["Capacity"].ToString();
            TextBox12.Text = dt.Rows[0]["RouteId"].ToString();
            TextBox13.Text = dt.Rows[0]["Status"].ToString();
            TextBox14.Text = dt.Rows[0]["Daily_rent"].ToString();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["vechid"].ToString();
            con = new SqlConnection();
            con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
            con.Open();
            string myquery = null;
            myquery = "update vehicledetails set vehNo='" + TextBox9.Text + "',vehName='" + TextBox1.Text + "',vehType='" + RadioButtonList1.Text + "',Rate_per_km='" + TextBox10.Text + "',Capacity='" + TextBox11.Text + "',RouteId='" + TextBox12.Text + "',Status='" + TextBox13.Text + "',Daily_rent='" + TextBox14.Text + "' where RegNo='" + id + "'";

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery;
            cmd.ExecuteNonQuery();
            Response.Redirect("~/MaintenanceManager/ViewVehicledetails.aspx");



    }
}

