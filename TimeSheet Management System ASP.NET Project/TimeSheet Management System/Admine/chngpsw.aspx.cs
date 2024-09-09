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

public partial class Admine_chngpsw : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        string id = Session["firstname"].ToString();
        if (txt_newpsw.Text == txt_conpass.Text)
        {
            cmd = new SqlCommand("update empinsert set paswd='" + txt_newpsw.Text + "' where empid='" + id + "'", con);
            Response.Write("Successfully Changed");
            cmd.ExecuteNonQuery();
        }
        else
        {
            Response.Write("Plz Enter Valied Password");
        }
        con.Close();

    }
}
