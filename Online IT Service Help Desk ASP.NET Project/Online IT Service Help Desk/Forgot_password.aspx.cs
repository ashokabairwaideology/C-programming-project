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

public partial class Forgot_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_smt_Click(object sender, EventArgs e)
    {
        string mail =txt_email.Text;
        string pswrd = "select * from Emp_info where email_id='" + mail + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, pswrd);

         if (ds.Tables[0].Rows.Count == 1)
        {
            string shw = "your User id:" + ds.Tables[0].Rows[0]["emp_Id"].ToString() + ",password:" + ds.Tables[0].Rows[0]["Password"].ToString();
            Mailing.SendMail(mail, "your Login Details", shw);
            lbl_psswrd.Visible = true;
            lbl_psswrd.Text = "Login Details sent To your E-Mail Id Pls Check Ur Mail......";
        }

         else
         {
             lbl_psswrd.Text = ConfigurationManager.AppSettings["Invalid E-Mail id"].ToString();
             lbl_psswrd.Visible = true;
         }
    }
}
