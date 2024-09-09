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

public partial class MaintenanceManager_UpdateProfile : System.Web.UI.Page
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
            TextBox2.Text = dt.Rows[0]["ManageName"].ToString();
            TextBox3.Text = dt.Rows[0]["Qualification"].ToString();
            TextBox4.Text = dt.Rows[0]["DOB"].ToString();
            RadioButtonList1.Text = dt.Rows[0]["Gender"].ToString();
            TextBox5.Text = dt.Rows[0]["Ph"].ToString();
            TextBox1.Text = dt.Rows[0]["EmailID"].ToString();
            TextBox6.Text = dt.Rows[0]["Age"].ToString();
            TextBox7.Text = dt.Rows[0]["Address"].ToString();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string EmailID = Session["EmailId"].ToString();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "update ManagerCreation set ManageName='" + TextBox2.Text +"',Qualification='" + TextBox3.Text +"',DOB='" + TextBox4.Text +"',Gender='" + RadioButtonList1.Text +"',Ph='" + TextBox5.Text +"',Age='" + TextBox6.Text +"',Address='" + TextBox7.Text + "' where EmailID='" + EmailID + "'";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
   
    }
}
