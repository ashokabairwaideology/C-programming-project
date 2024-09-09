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

public partial class Network_Manager_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_Request where Status='Approved by PM'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        lbl_PNDNG.Text = ds.Tables[0].Rows.Count.ToString();


        string sql3 = "select * from Raised_Request where Status='Assigned'";
        DataSet ds3 = new DataSet();
        ds3 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql3);
        lbl_ASSGN.Text = ds3.Tables[0].Rows.Count.ToString();

        string sql2 = "select * from Raised_Request where Status='Completed'";
        DataSet ds2 = new DataSet();
        ds2 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql2);
        lbl_CMPTD.Text = ds2.Tables[0].Rows.Count.ToString();



    }
    protected void lbl_PNDNG_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Approved by PM'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Approved by Project Manager ...";

    }
    protected void lbl_ASSGN_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Assigned'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Assigned ...";
    }
    protected void lbl_CMPTD_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Completed'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests completed ...";
    }
}
