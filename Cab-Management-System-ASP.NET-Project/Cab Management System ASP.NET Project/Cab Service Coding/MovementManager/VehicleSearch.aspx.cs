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

public partial class MovementManager_VehicleSearch : System.Web.UI.Page
{
    SqlConnection con;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";


            string myquery = null;
            myquery = "select * from vehicledetails ";
            SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            DropDownList1.DataTextField = "RegNo";
            DropDownList1.DataValueField = "RegNo";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = DropDownList1.Text;
        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";


        string myquery = null;
        myquery = "select * from vehicledetails where RegNo='" + id + "' ";
        SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
        GridView1.Visible = true;
    }
}
