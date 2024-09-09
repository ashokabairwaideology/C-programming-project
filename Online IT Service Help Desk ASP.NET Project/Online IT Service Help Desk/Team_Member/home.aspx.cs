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

public partial class Team_member_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql1 = "select * from Raised_Request where Status='Approved by PM' and emp_id='" + id + "'";
        DataSet ds1 = new DataSet();
        ds1 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql1);
        lbl_PNM.Text = ds1.Tables[0].Rows.Count.ToString();

        string sql2 = "select * from Raised_Request where Status='Approved by NM' and emp_id='" + id + "'";
        DataSet ds2 = new DataSet();
        ds2 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql2);
        lbl_ANM.Text = ds2.Tables[0].Rows.Count.ToString();

        string sql3 = "select * from Raised_Request where Status='Rejected by PM' and emp_id='" + id + "'";
        DataSet ds3 = new DataSet();
        ds3 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql3);
        lbl_RPM.Text = ds3.Tables[0].Rows.Count.ToString();

        string sql4 = "select * from Raised_Request where Status='Rejected by NM' and emp_id='" + id + "'";
        DataSet ds4 = new DataSet();
        ds4 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql4);
        lbl_RNM.Text = ds4.Tables[0].Rows.Count.ToString();

        string sql5 = "select * from Raised_Request where emp_id='"+id+"'";
        DataSet ds5 = new DataSet();
        ds5 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql5);
        lbl_PSTD.Text = ds5.Tables[0].Rows.Count.ToString();

        string sql6 = "select * from Raised_Request where Status='Completed' and emp_id='" + id + "'";
        DataSet ds6 = new DataSet();
        ds6 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql6);
        lbl_CMPLTD.Text=ds6.Tables[0].Rows.Count.ToString();
        
        


    }
    protected void lbl_PSTD_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests posted ...";

    }
    protected void lbl_PNM_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Approved by PM' and emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Approved by Project Manager ...";

    }
    protected void lbl_ANM_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();
        string sql = "select * from Raised_request where Status='Approved by NM'and emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Approved by Network Manager ...";

    }
    protected void lbl_RPM_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();
        string sql = "select * from Raised_request where Status='Rejected by PM'and emp_id='" + id + "'"; 
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Rejected by Project Manager ...";

    }
    protected void lbl_RNM_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Rejected by  NM'and emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Rejected by Network Manager ...";

    }
    protected void lbl_CMPLTD_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Completed'and emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        GDV.DataSource = ds;
        GDV.DataBind();
        GDV.Visible = true;
        lbl_home.Visible = true;
        lbl_home.Text = "Number of Requests Completed ...";


    }
}
