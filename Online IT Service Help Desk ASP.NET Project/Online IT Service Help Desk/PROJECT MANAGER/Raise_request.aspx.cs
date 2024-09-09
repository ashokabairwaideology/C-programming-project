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

public partial class PROJECT_MANAGER_Raise_request : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string eid = Session["emp_id"].ToString();
        txt_empid.Text = eid;
    }
    protected void snd_rqst_Click(object sender, EventArgs e)
    {
        string empid = Session["emp_id"].ToString();
        string request_for = Dr_requestfor.Text;
        string request_description = txt_rqstdscrptn.Text;
        string sql = "insert into Raised_request values('" + empid + "','" + request_for + "','" + request_description + "','Approved by PM','')";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
        lb_rqst.Visible = true;
        lb_rqst.Text = "request sent......";
    }
}
