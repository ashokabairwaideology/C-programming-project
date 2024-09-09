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

public partial class admin_Modify_employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["empid"].ToString();

        string sql = "select * from emp_info where emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

        TextBox12.Text = Request.QueryString["empid"].ToString();
        TextBox3.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
        TextBox13.Text = ds.Tables[0].Rows[0]["lasrt_name"].ToString();
        TextBox14.Text = ds.Tables[0].Rows[0]["email_id"].ToString();
        TextBox11.Text = ds.Tables[0].Rows[0]["password"].ToString();
        TextBox9.Text = ds.Tables[0].Rows[0]["address"].ToString();
        TextBox5.Text = ds.Tables[0].Rows[0]["phone_no"].ToString();
        TextBox15.Text = ds.Tables[0].Rows[0]["city"].ToString();
        TextBox16.Text = ds.Tables[0].Rows[0]["state"].ToString();
        TextBox17.Text = ds.Tables[0].Rows[0]["zip"].ToString();
        TextBox18.Text = ds.Tables[0].Rows[0]["doj"].ToString();
        TextBox4.Text = ds.Tables[0].Rows[0]["position"].ToString();
        TextBox2.Text = ds.Tables[0].Rows[0]["dob"].ToString();
        TextBox19.Text = ds.Tables[0].Rows[0]["status"].ToString();
        TextBox7.Text = ds.Tables[0].Rows[0]["Previous_company"].ToString();
        TextBox20.Text = ds.Tables[0].Rows[0]["unique_id"].ToString();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string eid = TextBox12.Text;
        string fname = TextBox3.Text;
        string lname = TextBox13.Text;
        string email = TextBox14.Text;
        string pswrd = TextBox11.Text;
        string addrs = TextBox9.Text;
        string phn = TextBox5.Text;
        string city = TextBox15.Text;
        string state = TextBox16.Text;
        string zip = TextBox17.Text;
        string dob = TextBox18.Text;
        string doj = TextBox4.Text;
        string postn = TextBox2.Text;
        string status = TextBox19.Text;
        string prvcmpny = TextBox7.Text;
        string unqid = TextBox20.Text;
        string sql1 = "update emp_info set first_name='" + fname + "',lasrt_name='" + lname + "',phone_no='" + phn + "',email_id='" + email + "',password='" + pswrd + "',address='" + addrs + "',city='" + city + "',state='" + state + "',zip='" + zip + "',dob='" + dob + "',doj='" + doj + "',position='" + postn + "',status='" + status + "',Previous_company='" + prvcmpny + "',unique_id='" +unqid + "',where emp_id='" + eid + "'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql1);

        lbl_updte.Visible = true;
        lbl_updte.Text = "Your profile updated Sucessfully......";
    }
}
