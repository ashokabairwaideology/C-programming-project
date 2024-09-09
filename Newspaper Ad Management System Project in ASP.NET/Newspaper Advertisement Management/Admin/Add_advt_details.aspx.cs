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
using System.Data;

public partial class Admin_Add_advt_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string pageno = txtpgno.Text;
        string pagelocation = txtlocation.Text;
        string block_whitecost=txtbwcost.Text;
        string colorcost=txtccost.Text;
        string Description=txtdesc.Text;

        string sql = "insert into AdvertaisementDetails values('" + pageno + "','" + pagelocation + "','" + block_whitecost + "','" + colorcost + "','" + Description + "')";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);

        txtpgno.Text=" ";
        txtlocation.Text=" ";
        txtbwcost.Text=" ";
        txtccost.Text=" ";
        txtdesc.Text=" ";

        lbl_AddDetails.Visible = true;
        lbl_AddDetails.Text = "page data Added Sucessfully.......";
        

    }
}
