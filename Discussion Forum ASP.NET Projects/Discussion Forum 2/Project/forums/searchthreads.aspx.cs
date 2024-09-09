using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class searchthreads : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string cond = " 1 = 1 ";
        if (txtText.Text.Length > 0)
            cond += " and text like '%" + txtText.Text + "%'";
        if (txtFromDate.Text.Length > 0)
            cond += " and dp >='" + txtFromDate.Text + "'";
        if (txtToDate.Text.Length > 0)
            cond += " and dp <='" + txtToDate.Text + "'";

        DataSet ds = ThreadDAL.Search(cond);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
       

    }
}
