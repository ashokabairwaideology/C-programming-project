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

public partial class MovementManager_EditCityDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["cityId"].ToString();

            con.Open();
            string myquery = null;
            myquery = "select *from AddCitys where cityId='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox1.Text = dt.Rows[0]["cityname"].ToString();
            TextBox2.Text = dt.Rows[0]["code"].ToString();
            

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["cityId"].ToString();
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "update AddCitys set cityname='" + TextBox1.Text + "',code='" + TextBox2.Text + "'where cityId='" + id + "'";

        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Redirect("~/MovementManager/ViewCityDetails.aspx");
    }
}
