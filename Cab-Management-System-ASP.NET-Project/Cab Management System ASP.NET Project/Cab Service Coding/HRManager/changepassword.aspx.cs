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


public partial class HRManager_changepassword : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["EmailID"].ToString();
        string opwd = TextBox1.Text;
        string npwd = TextBox2.Text;
        
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();


        string MyQuery = "select * from ManagerCreation where EmailID='" + id + "'and Password='" + opwd + "'";

        SqlDataAdapter adpt = new SqlDataAdapter(MyQuery , con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            if (dt.Rows[0]["Password"].ToString() == opwd)
            {


                string sql = "update ManagerCreation set Password='" + npwd + "' where EmailID='" + id + "'";

                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            else
            {
                invalid.Visible = true;
                invalid.Text = "invalid password";
            }



        }
        con.Close();
    }
}
