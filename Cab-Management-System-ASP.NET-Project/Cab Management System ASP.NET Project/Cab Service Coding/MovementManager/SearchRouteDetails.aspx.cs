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

public partial class MovementManager_SearchRouteDetails : System.Web.UI.Page
{
    SqlConnection con;
  
    
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if(!IsPostBack)
        {

            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";


            string myquery = null;
            myquery = "select * from RouteDetails ";
            SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            DropDownList1.DataTextField = "routeid";
            DropDownList1.DataValueField = "routeid";
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
        myquery = "select * from RouteDetails where routeid='" + id + "' ";
        SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        gv_surchrutdetails.DataSource = dt;
        gv_surchrutdetails.DataBind();
        gv_surchrutdetails.Visible = true;
      

    }
}
