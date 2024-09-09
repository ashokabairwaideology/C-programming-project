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


public partial class Employees_Myprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["Username"].ToString();

        string sql = "select * from EmployDetails where Username='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        txtempname.Text = ds.Tables[0].Rows[0]["Empname"].ToString();
        txtcontactname.Text = ds.Tables[0].Rows[0]["Empcontactno"].ToString();
        txtmailid.Text = ds.Tables[0].Rows[0]["Mailid"].ToString();
        txtcountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
        txtstate.Text = ds.Tables[0].Rows[0]["State"].ToString();
        txtcity.Text = ds.Tables[0].Rows[0]["City"].ToString();
        txtaddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
        txtempid.Text = Session["Username"].ToString();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
      
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        /*
         string empname = TextBox1.Text;
        string contactno = TextBox2.Text;
        string mailId = TextBox3.Text;
        string country = TextBox4.Text;
        string state = TextBox5.Text;
        string city = TextBox6.Text;
        string address = TextBox7.Text;
        string empId = TextBox8.Text;

        string sql = "Update EmployDetails set Empname='" + empname + "',Empcontactno='" + contactno + "',Mailid='" + mailId + "',Country='" + country + "',State='" + state + "',City='" + city + "',Address='" + address + "' where Empid='" + empId + "'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";

      lbl_myprofile.Visible = true;
      lbl_myprofile.Text = "My profile edit  Sucessfully.............";*/
    }
}
