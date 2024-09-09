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


public partial class MaintenanceManager_ViewVehicledetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
            con.Open();

            string myquery = null;

            myquery = "select *from vehicledetails ";

            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery;

            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}

