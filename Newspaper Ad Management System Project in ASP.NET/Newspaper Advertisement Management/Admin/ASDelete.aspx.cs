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



public partial class Admin_ASDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            string id = Request.QueryString["id"].ToString();
            string sql = "delete from AdvertaisementDetails where Addcode='" + id + "'";
            DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);

            Response.Write("record deleted");
        }

        catch (Exception ex)
        {
            Response.Write("Handlor" + ex.Message.ToString());
        }
        Response.Redirect("~/Admin/View_Advt_details.aspx");

    }

}
