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

public partial class Team_member_Track_request : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Approved by PM'or Status='Approved by NM' or Status='Completed' and Emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

        gv_track.DataSource = ds;
        gv_track.DataBind();

      /*  string sqL1 = "select * from Raised_request where Emp_id='" + id + "' and status='"+Rejected by PM+"'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql2);

        gv_rjctd.DataSource = ds;
        gv_rjctd.DataBind();*/
    }
    protected void lnk_rjctdrqsts_Click(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();


string sql2 = "select * from Raised_request where Status='Rejected by NM' or Status='Rejected by PM' and Emp_id='" + id + "' ";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql2);
        if (ds.Tables[0].Rows.Count == 0)
        {
            lbl_dltd.Visible = true;
        }
        else
        {
            gv_rjctd.DataSource = ds;
            gv_rjctd.DataBind();
            gv_rjctd.Visible = true;
        }
    }
}
