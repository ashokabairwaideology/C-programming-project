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
using System.Data;
using System.Data.SqlClient;

public partial class admin_View_employees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql="select emp_id,first_name,email_id,position,status from emp_info";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

        gv_view.DataSource = ds;
        gv_view.DataBind();


    }
}
