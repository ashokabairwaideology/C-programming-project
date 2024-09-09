using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class statusreport : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cargoConnectionString"].ToString());
 
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into statusreport values(" + txtCustomerid.Text + ",'" + txtCustomername.Text  + "','" + ddlSource.SelectedItem + "','" + ddlDestination.SelectedItem + "','" + txtDestinationaddress.Text + "','" + ddlFlightno.SelectedItem + "','" + ddlCargono.SelectedItem + "','" + txtDeliveringdate.Text + "','" + ddlStatus.SelectedItem + "')", con);
        cmd.ExecuteNonQuery();
        Label10.Text = "submitted Successfully";
        con.Close();

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtDeliveringdate.Text = Calendar1.SelectedDate.ToShortDateString();
    }
}
