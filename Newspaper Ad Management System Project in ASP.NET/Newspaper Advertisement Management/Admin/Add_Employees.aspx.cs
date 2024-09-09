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

public partial class Admin_Add_Employees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = txt_name.Text;
        string contact = txt_contactno.Text;
        string mid = txt_mail.Text;
        string country = txt_country.Text;
        string state = txt_state.Text;
        string city = txt_city.Text;
        string adderss = txt_address.Text;
        string username = txt_uname.Text;
        string pwd = txt_password.Text;

        string sql = "insert into EmployDetails values('" + name + "','" + contact + "','" + mid + "','" + country + "','" + state + "','" + city + "','" + adderss + "','" + username + "','" + pwd + "','Employee')";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text,sql);
        txt_name.Text="";
        txt_contactno.Text = "";
        txt_mail.Text = "";
        txt_country.Text = "";
        txt_state.Text = "";
        txt_city.Text = "";
        txt_address.Text = "";
        txt_uname.Text = "";
        txt_password.Text = "";

        lbl_addemp.Visible = true;
        lbl_addemp.Text = "Employee Added Sucessfully.......";
        
    }
}
