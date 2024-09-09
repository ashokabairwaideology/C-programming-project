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

public partial class Employees_update_profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
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

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["Username"].ToString();

        string ename = txtempname.Text;
        string contno = txtcontactname.Text;
        string mailid = txtmailid.Text;
        string country = txtcountry.Text;
        string state = txtstate.Text;
        string city = txtcity.Text;
        string address = txtaddress.Text;

        string sql = "update EmployDetails set Empname='" + ename + "',Empcontactno='" + contno + "',Mailid='" + mailid + "',Country='" + country + "',State='" + state + "',City='" + city + "',Address='" + address + "' where Username='" + id + "'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
        lbl_myprofile.Visible = true;
        lbl_myprofile.Text = "Your Profile Updated Sucessfull...";

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Employees/update_profile.aspx");
    }
}
