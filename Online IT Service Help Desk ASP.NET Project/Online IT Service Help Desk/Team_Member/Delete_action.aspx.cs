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

public partial class Team_Member_Delete_action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["reqid"].ToString();
        string sql = "delete from Raised_request where Request_id='" + id + "'";
        //DataSet ds = new DataSet();
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
       // if (ds.Tables[0].Rows.Count == 0)
        //{
          //  Label.text = "They Are no Rejected Requests";
        //}
       // else
        //{
            Response.Redirect("~/Team_Member/Track_request.aspx");
           // lbl_dltd.Visible = true;
        //}
    }
}
