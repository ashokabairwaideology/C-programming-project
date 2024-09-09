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

public partial class FinancialManager_viewprofile : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string EmailID = Session["EmailId"].ToString();
            string sql = "select * from ManagerCreation where EmailID='" + EmailID + "'";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";

            SqlDataAdapter adpt = new SqlDataAdapter(sql, con.ConnectionString);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            Label14.Text = dt.Rows[0]["ManageName"].ToString();
            Label15.Text = dt.Rows[0]["Qualification"].ToString();
            Label16.Text = dt.Rows[0]["DOB"].ToString();
            Label17.Text = dt.Rows[0]["Gender"].ToString();
            Label18.Text = dt.Rows[0]["Ph"].ToString();
            Label19.Text = dt.Rows[0]["EmailID"].ToString();
            Label20.Text = dt.Rows[0]["Age"].ToString();
            Label21.Text = dt.Rows[0]["Address"].ToString();


        }

    }
}

