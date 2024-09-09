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
using System.Data;

public partial class Admin_My_profile : System.Web.UI.Page
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
    }
}
