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

public partial class Team_member_Request_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string empid = Session["Emp_Id"].ToString();

            txt_id.Text = empid;

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string empid = txt_id.Text;
        string subj = txt_sbjct.Text;
        string descp = txt_dscrptn.Text;
        string status = "Request";

        string sql = "insert into Req_admin values('" + empid + "','" + subj + "','" + descp + "','" + status + "')";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
        lbl_rqst.Text = "Request Has been send....";
    }
}
