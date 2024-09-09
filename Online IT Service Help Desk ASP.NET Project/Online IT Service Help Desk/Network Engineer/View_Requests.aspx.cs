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

public partial class Network_Engineer_View_Requests : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string cmpltd = Session["Emp_Id"].ToString();
            string sql = "select Request_id,Emp_Id,Type,Description from Raised_request where Status='Assigned' and Assign_to='" + cmpltd + "'";
            DataSet ds = new DataSet();


            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
            gv_approve.DataSource = ds;
            gv_approve.DataBind();

        }
    }
}
