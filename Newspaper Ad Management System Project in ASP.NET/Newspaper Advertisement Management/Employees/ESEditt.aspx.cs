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

public partial class Employees_ESEditt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"].ToString();
            string sql = "select *from  AdvertaisementDetails where Addcode='" + id + "'";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

            txt_pno.Text = ds.Tables[0].Rows[0]["Pageno"].ToString();
            txt_ploc.Text = ds.Tables[0].Rows[0]["Pagelocaton"].ToString();
            txt_bw.Text = ds.Tables[0].Rows[0]["Costscblkwhite"].ToString();
            txt_colour.Text = ds.Tables[0].Rows[0]["Costsccolor"].ToString();
            txt_desc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

        string id = Request.QueryString["id"].ToString();
        string pageno = txt_pno.Text;
        string pagelocation = txt_ploc.Text;
        string sc_BW = txt_bw.Text;
        string SC_colour = txt_colour.Text;
        string Description = txt_desc.Text;

        string sql = "update AdvertaisementDetails set Pageno='" + pageno + "',Pagelocaton='" + pagelocation + "',Costscblkwhite='" + sc_BW + "',Costsccolor='" + SC_colour + "',Description='" + Description + "'where Addcode='" + id + "'";

        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);

        Response.Write("record updated");

    }
    catch (Exception ex)
        {
            Response.Write("Handlor" + ex.Message.ToString());
        }
        Response.Redirect("~/Employees/Advertisement_Details.aspx");

   
    }
}
