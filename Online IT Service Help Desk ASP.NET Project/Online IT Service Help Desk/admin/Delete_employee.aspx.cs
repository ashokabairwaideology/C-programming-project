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

public partial class admin_Delete_employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string eid = Request.QueryString["empid"];

            if (eid != null)
            {
                string sql = "select * from emp_info where emp_id='" + eid + "' and status ='Active' and position !='Admin'";
                DataSet ds = new DataSet();
                ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
                if(ds.Tables[0].Rows.Count !=0)
                {

                gv_delet.DataSource = ds;
                gv_delet.DataBind();
                gv_delet.Visible = true;
                }
           
            else
            {
                lbl_delet.Visible = true;
                lbl_delet.Text = "No id Match With Database";
 
            }
            }
        }

    }
    protected void DL_EMP_Click(object sender, EventArgs e)
    {
    
    }
protected void  dl_srch_Click(object sender, EventArgs e)
{
    string id=dl_emp.Text;
    Response.Redirect("~/admin/Delete_employee.aspx?empid=" + id);

}
}
