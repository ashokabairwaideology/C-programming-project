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

public partial class MaintenanceManager_edit_vender : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["venid"].ToString();

            con.Open();
            string myquery = null;
            myquery = "select *from venderdetails where vid='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox6.Text = dt.Rows[0]["vid"].ToString();
            TextBox1.Text = dt.Rows[0]["vendername"].ToString();
            TextBox2.Text = dt.Rows[0]["Address"].ToString();
            TextBox3.Text = dt.Rows[0]["PhoneNo"].ToString();
            TextBox4.Text = dt.Rows[0]["Email"].ToString();
            TextBox5.Text = dt.Rows[0]["Remarks"].ToString();
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["venid"].ToString();
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "update venderdetails set venderid='" + TextBox6.Text + "',vendername='"+TextBox1.Text+"',Address='" + TextBox2.Text + "',PhoneNo='" + TextBox3.Text + "',Email='" + TextBox4.Text + "',Remarks='" + TextBox5.Text +"' where vid='"+id+"'";

        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Redirect("~/MaintenanceManager/View Vender Details.aspx");


    }
}
