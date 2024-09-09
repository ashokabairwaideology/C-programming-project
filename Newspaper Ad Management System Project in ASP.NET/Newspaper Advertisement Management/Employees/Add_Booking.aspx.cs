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

public partial class Employees_Add_Booking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string custname = txt_cname.Text;
        string contactno = txt_cno.Text;
        string address = txt_address.Text;
        string sql = "insert into CustomerDetails values('" + custname + "','" + contactno + "','" + address + "',getdate())";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
        Response.Write("customer profile added successfully");
        lbl_CPA.Visible = true;
        Button2.Visible = true;
        string sql1 = "select Max(Custid) from CustomerDetails";
        object obj = DAL.SqlHelper.ExecuteScalar(clsConnection.Connection, CommandType.Text, sql1);

        lblusid.Text = obj.ToString();

    }
    
    protected void Button2_Click1(object sender, EventArgs e)
    {
        string id = lblusid.Text;
        Response.Redirect("~/Employees/Book_Advt.aspx?usid='"+id+"'");


    }
}
