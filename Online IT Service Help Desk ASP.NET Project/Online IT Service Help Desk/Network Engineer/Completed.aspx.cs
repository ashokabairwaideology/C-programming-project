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

public partial class Network_Engineer_Completed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string reqid = Request.QueryString["reqid"];
            string sql = "update Raised_request set  Status='Completed',End_date=getdate() where Request_id='" + reqid + "'";
            DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
            Response.Redirect("~/Network Engineer/View_Requests.aspx");
        }

    }
}
