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

public partial class Admin_Updateprofile : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack )
        {

        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string name = Session["UserName"].ToString();
        string sql1 = "select *from Registration where UserName='" + name + "'";

        SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        txt_fname .Text = dt.Rows[0]["FirstName"].ToString();
        txt_lname .Text  = dt.Rows[0]["LastName"].ToString();
        txt_alt .Text = dt.Rows[0]["AltEmailId"].ToString();
        txt_ph .Text = dt.Rows[0]["PhoneNo"].ToString();
    } 

    }
     protected void Button2_Click(object sender, EventArgs e)
    {
        //string loc_email = TextBox1.Text;
        string loc_fname = txt_fname.Text;
        string loc_uname = txt_lname.Text;
        string loc_alt = txt_alt.Text;
        string loc_ph = txt_ph.Text;

        FileUpload1.SaveAs(Server.MapPath("~/Photos") + "//" + FileUpload1.FileName);
        string patrh = ("~/Photos") + "//" + FileUpload1.FileName;



        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();
        string name = Session["UserName"].ToString();
        string myquery = "update Registration set FirstName='" + loc_fname + "',UserName='" + loc_uname + "',AltEmailId='" + loc_alt + "',PhoneNo='" + loc_ph + "',imgpath='" + patrh + "' where UserName='" + name + "'";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("MODIFIED");

        
    }
}
