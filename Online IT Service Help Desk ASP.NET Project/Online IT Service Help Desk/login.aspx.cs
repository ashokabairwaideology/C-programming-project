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


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = username.Text;
        string pwd = password.Text;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\it_servis_desk.mdf;Integrated Security=True;User Instance=True");

        string sql = "select *from emp_info where emp_id='" + id + "' and password='" + pwd + "'";

        SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            Session["emp_id"] = id;
            Session["Name"] = dt.Rows[0]["first_name"].ToString() + dt.Rows[0]["lasrt_name"].ToString();
           

            if (dt.Rows[0]["Position"].ToString() == "Admin")
            {
                Response.Redirect("~/admin/Home.aspx");
            }
            if (dt.Rows[0]["Position"].ToString() == "Project Manager")
            {
                Response.Redirect("~/PROJECT MANAGER/home.aspx");
            }
            if (dt.Rows[0]["Position"].ToString() == "Network Manager")
            {
                Response.Redirect("~/Network MANAGER/home.aspx");
            }
            if (dt.Rows[0]["Position"].ToString() == "Network Engineer")
            {
                Response.Redirect("~/Network Engineer/home.aspx");
            }
            if (dt.Rows[0]["Position"].ToString() == "Team Member")
            {
                Response.Redirect("~/Team_Member/home.aspx");
            }
        }
        else
        {
            lbl_invalid.Visible = true;
            lbl_invalid.Text = "INVALID USERAME OR PASSWORD";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
