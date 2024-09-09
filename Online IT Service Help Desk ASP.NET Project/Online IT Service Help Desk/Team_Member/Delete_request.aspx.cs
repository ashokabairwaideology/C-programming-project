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

public partial class Team_member_Delete_request : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Session["emp_id"].ToString();

        string sql = "select * from Raised_request where Status='Approved by PM'or Status='Approved by NM'or Status='Raised request' and Emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        
        gd_dltrqst.DataSource = ds;
        gd_dltrqst.DataBind();
        


    }
}
