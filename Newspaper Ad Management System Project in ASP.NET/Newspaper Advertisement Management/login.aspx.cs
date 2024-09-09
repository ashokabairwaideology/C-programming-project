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


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        pnl_login.Visible = true;
    }
          
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string pos = DropDownList1.Text;
        string username = txtuname.Text;
        string password = txtpwd.Text;
        string sql = "select *from EmployDetails where Username='" + username + "' and Password='" + password + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        if (ds.Tables[0].Rows.Count == 1)
        {
            Session["Username"] = txtuname.Text;
            if (ds.Tables[0].Rows[0]["Role"].ToString() == "Admin")
            {
                Response.Redirect("~/Admin/Home.aspx");

            }
            else if (ds.Tables[0].Rows[0]["Role"].ToString() == "Employee")
            {
                Response.Redirect("~/Employees/Home.aspx");
            }
        }
        else
        {

        }

    }
}
