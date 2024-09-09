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

public partial class frgtpswd2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string eid = Request.QueryString["EmailID"].ToString();
            SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial catalog=BB;Integrated security=true");
            string Query = "select * from Registration where EmailID='" + eid + "'";
            SqlDataAdapter adpt = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            lbl_hintq.Text = dt.Rows[0]["HintQ"].ToString();


        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string eid = Request.QueryString["EmailID"].ToString();
        string ques = lbl_hintq.Text;
        string ans = TextBox1.Text;
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial catalog=BB;Integrated security=true");
        string Query = "select * from Registration where EmailID='" + eid + "'";
        SqlDataAdapter adpt = new SqlDataAdapter(Query,con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count != 0)
        {
            if (dt.Rows[0]["HintA"].ToString() == ans)
            {
               Label5.Text = dt.Rows[0]["Password"].ToString();
                lbl_msg.Visible = false;
                Label3.Visible = true;
            }
            else
            {
                TextBox1.Text = null;
                lbl_msg.Visible = true;
                lbl_msg.Text = "Invalid  Answer";
               

            }
        }
        else
        {
            Response.Redirect("~/Frgtpswd2.aspx");
        }

    }
}
