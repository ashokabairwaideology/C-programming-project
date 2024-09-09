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

public partial class User_UpdateProfile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
            con.Open();

            string name = Session["UserName"].ToString();
            string sql1 = "select *from Registration where UserName='" + name + "'";

            SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            TextBox1.Text = dt.Rows[0]["FirstName"].ToString();
            TextBox2.Text = dt.Rows[0]["LastName"].ToString();
            TextBox3.Text = dt.Rows[0]["EmailID"].ToString();
            TextBox4.Text = dt.Rows[0]["AltEmailId"].ToString();
            TextBox5.Text = dt.Rows[0]["martstatus"].ToString();
            TextBox6.Text = dt.Rows[0]["PhoneNo"].ToString();
            TextBox7.Text = dt.Rows[0]["City"].ToString();
            TextBox8.Text = dt.Rows[0]["State"].ToString();
            con.Close();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_fname = TextBox1.Text;
        string loc_lname = TextBox2.Text;
        string loc_email = TextBox3.Text;
        string loc_altemail = TextBox4.Text;
        string loc_martstu = TextBox5.Text;
        string loc_phno = TextBox6.Text;
        string loc_city = TextBox7.Text;
        string loc_state = TextBox8.Text;

        FileUpload1.SaveAs(Server.MapPath("~/Photos") + "//" + FileUpload1.FileName);
        string patrh = ("~/Photos") + "//" + FileUpload1.FileName;


        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string name = Session["UserName"].ToString();
        string sql1 = "update Registration set FirstName='" + loc_fname + "',LastName='" + loc_lname + "',EmailID='" + loc_email + "',AltEmailId='" + loc_altemail + "' ,martstatus='" + loc_martstu + "',PhoneNO='" + loc_phno + "', City='" + loc_city + "',State='" + loc_state + "',imgpath='" + patrh + "' where UserName='" + name + "' ";


        SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql1;


    }
}
