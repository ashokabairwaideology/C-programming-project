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

public partial class Network_Manager_Change_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void chng_pswrd_Click1(object sender, EventArgs e)
    {
        string empid = Session["emp_id"].ToString();
        string oldpswrd = old_pswrd.Text;
        string newpswrd = new_pswrd.Text;
        string cnfrmpswrd = confirm_pswrd.Text;

        string sql1 = "select * from Emp_info where Password='" + oldpswrd + "' and Emp_id='" + empid + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql1);

        if (ds.Tables[0].Rows.Count == 1)
        {
            string sql = "update Emp_info set Password='" + newpswrd + "' where Emp_id='" + empid + "'";
            DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
            Lbl_pswrd.Visible = true;
            Lbl_pswrd.Text = "Your password updated Sucessfully......";

        }
        else
        {
            Lbl_pswrd.Visible = true;
            Lbl_pswrd.Text = "Your password Dousnot mayched with Our database......";

        }
    }
}