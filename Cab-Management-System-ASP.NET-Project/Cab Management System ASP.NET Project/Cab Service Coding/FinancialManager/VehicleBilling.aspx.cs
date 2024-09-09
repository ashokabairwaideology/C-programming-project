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

public partial class FinancialManager_VehicleBilling : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
        con.Open();
        string myquery = "select * from vehicledetails ";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        dr = cmd.ExecuteReader();
        int i = 0;
        while (dr.Read())
        {
            DropDownList1.Items.Insert(i, dr["vehno"].ToString());
            i++;
        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
}
