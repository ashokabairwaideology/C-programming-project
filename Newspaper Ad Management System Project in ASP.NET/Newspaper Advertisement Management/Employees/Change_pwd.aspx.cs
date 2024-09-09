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

public partial class Employees_Change_pwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Session["Username"].ToString();
        string oldpwd = Txt_oldpwd.Text;
        string newpwd = Txt_newpwd.Text;
        string Cnfrmpwd = Txt_Cnfrmpwd.Text;

        string sql = "update EmployDetails set Password='" + newpwd + "' where Username='"+name+"' and Password='"+oldpwd+"'  ";

        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);

        Txt_oldpwd.Text = " ";
        Txt_newpwd.Text = " ";
        Txt_Cnfrmpwd.Text = " ";

        lbl_changepwd.Visible = true;
        lbl_changepwd.Text = "change your password Sucessfully.......";
    }
}
