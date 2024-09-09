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

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_register_Click(object sender, EventArgs e)
    {
        con.Open();

        string loc_fname = txt_firstname.Text;
        string loc_lname = txt_lastname.Text;
        string loc_uname = txt_username.Text;

        string loc_pwd = txt_pswd.Text;
        string loc_cpwd = txt_confrmpswd.Text;

        string loc_email = txt_Emailid.Text;
        string loc_cemail = txt_confmemail.Text;

        string loc_gender = rad_gender.Text;

        string loc_ms = rdo_ms.Text;

        string loc_dob = ddl_dd.Text + "/" + ddl_mm.Text + "/" + ddl_yr.Text;

        string loc_phno = txt_phno.Text;

        string loc_hintq = ddl_hintq.Text;
        string loc_hinta = txt_hinta.Text;

        string loc_city = ddl_city.Text;

        string loc_state = ddl_state.Text;

        

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;


        FileUpload1.SaveAs(Server.MapPath("~/Photos") + "//" + FileUpload1.FileName);
        string patrh = ("~/Photos") + "//" + FileUpload1.FileName;

        cmd.CommandText = "insert into  Registration values('" + loc_fname + "','" + loc_lname + "','" + loc_uname + "','" + loc_pwd + "','" + loc_cpwd + "','" + loc_email + "','" + loc_cemail + "','" + loc_gender + "','" + loc_ms + "','" + loc_dob + "',' " + loc_phno + "' ,'" + loc_hintq + "','" + loc_hinta + "','" + loc_city + "','" + loc_state + "','User','"+patrh+"')";
        cmd.ExecuteNonQuery();

        //Response.Write("Inserted");
        Response.Redirect("~/Login.aspx");
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        string check = txt_username.Text;
        string sql="select * from Registration where UserName='"+check+"'";
        SqlDataAdapter adpt=new SqlDataAdapter(sql,con);
        DataTable dt=new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            lbl_exist.Text = "Exist";
        }
        else
        {
            lbl_exist.Text = "Valid";
        }

       
    }
}
