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

public partial class Admin_edit_Advt_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();

            string sql = "select * from AdvertaisementDetails where Addcode='" + id + "'";
            DataSet ds = new DataSet();

            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
            txtpgno.Text = ds.Tables[0].Rows[0]["Pageno"].ToString();
            txtlocation.Text = ds.Tables[0].Rows[0]["Pagelocaton"].ToString();
            txtbwcost.Text = ds.Tables[0].Rows[0]["Costscblkwhite"].ToString();
            txtccost.Text = ds.Tables[0].Rows[0]["Costsccolor"].ToString();
            txtdesc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
            txtaddid.Text = Request.QueryString["id"].ToString();
        }
     

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"].ToString();

        string pgno=txtpgno.Text ;
        string loc=txtlocation.Text;
        string bwc=txtbwcost.Text ;
        string ccost=txtccost.Text;
        string desc=txtdesc.Text;

        string sql = "update AdvertaisementDetails set Pageno='" + pgno + "',Pagelocaton='" + loc + "',Costscblkwhite='" + bwc + "',Costsccolor='" + ccost + "',Description='" + desc+"' where Addcode='"+id+"'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/View_Advt_details.aspx");
    }
}
