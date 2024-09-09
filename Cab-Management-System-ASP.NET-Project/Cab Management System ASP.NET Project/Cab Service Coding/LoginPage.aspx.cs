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

public partial class Admin_LoginPage : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_email = txt_uname.Text;
        string loc_password = txt_pwd.Text;



        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string myquery = null;
        myquery = "select * from ManagerCreation where EmailID='" + loc_email + "' and Password='" + loc_password + "'";
        SqlDataAdapter adpt = new SqlDataAdapter(myquery, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            Session["EmailId"] = dt.Rows[0]["EmailID"].ToString();
            string Designation = dt.Rows[0]["Designation"].ToString();

            if (Designation == "finance Manager")
            {

                Response.Redirect("~/FinancialManager/Home.aspx");
            }

            if (Designation == "HRManager")
            {

                Response.Redirect("~/HRManager/home.aspx");
            }
            if (Designation == "Maintance Manager")
            {

                Response.Redirect("~/MaintenanceManager/Home.aspx");
            }
            if (Designation == "Movement Manager")
            {

                Response.Redirect("~/MovementManager/Home.aspx");
            }
            if (Designation == "Admin")
            {

                Response.Redirect("~/Admin/Home.aspx");
            }

        }

    }


}

