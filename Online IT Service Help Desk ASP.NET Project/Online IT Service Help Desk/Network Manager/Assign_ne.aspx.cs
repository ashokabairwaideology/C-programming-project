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

public partial class Network_Manager_Assign_ne : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string reqid = Request.QueryString["reqid"].ToString(); ;
            string sql = "select * from Raised_request where Request_id='" + reqid + "'";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

            assign_reqid.Text = ds.Tables[0].Rows[0]["Request_id"].ToString();
            assign_empid.Text = ds.Tables[0].Rows[0]["Emp_Id"].ToString();
            assign_type.Text = ds.Tables[0].Rows[0]["Type"].ToString();
            assign_description.Text = ds.Tables[0].Rows[0]["Description"].ToString();

            string sql2 = "select * from Emp_info where Position='Network Engineer'";
            DataSet ds2 = new DataSet();
            ds2 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql2);
            
            ddl_ne.DataTextField = "first_name";
            ddl_ne.DataValueField = "emp_id";
            ddl_ne.DataSource = ds2;
            ddl_ne.DataBind();
        }
       
    }
    protected void Assign_ne_Click(object sender, EventArgs e)
    {
        string assn = Request.QueryString["reqid"];
        string empid = ddl_ne.Text;
        string sql3 = "update Raised_request set  Assign_to='" + empid + "',Status='Assigned' where Request_id='" + assn + "'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql3);
        assign_lbl.Visible = true;
        assign_lbl.Text = "Work has been Assigned......";
        
    }
}
