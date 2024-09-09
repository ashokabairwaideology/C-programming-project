using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class all_register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        bool done;

        done = UserDAL.Register(txtEmail.Text, txtPwd.Text, txtFullname.Text, txtOccup.Text);
        if (done)
            lblMsg.Text = "Registration is successful. Please login by clicking <a href=..\\login.aspx>here</a>";
        else
            lblMsg.Text = "Sorry! Registration Failed!";
    }
}
