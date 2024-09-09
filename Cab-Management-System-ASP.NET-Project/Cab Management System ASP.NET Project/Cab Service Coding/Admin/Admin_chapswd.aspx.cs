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

public partial class Admin_Admin_chapswd : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["EmailID"].ToString();
        string oldpwd = TextBox1.Text;
        string pwd = TextBox2.Text;

        con = new SqlConnection();

        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();

        string query = "select * from ManagerCreation where EmailID='" + id + "' and Password='" + oldpwd + "';";

        SqlDataAdapter adpt = new SqlDataAdapter(query, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            if (dt.Rows[0]["Password"].ToString() == oldpwd)
            {

                con = new SqlConnection();
                con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
                con.Open();
                string sql = "update ManagerCreation set Password='" + pwd + "'  where  EmailID='" + id + "'";

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
            Response.Write("Record Updated");



        }
        con.Close();

    }

}
