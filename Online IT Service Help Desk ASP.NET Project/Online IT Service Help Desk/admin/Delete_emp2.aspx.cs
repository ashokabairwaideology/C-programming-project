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

public partial class admin_Delete_emp2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string eid = Request.QueryString["empid"];
        string sql="update emp_info set status='Inactive' where emp_id='"+eid+"'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
    }
}
