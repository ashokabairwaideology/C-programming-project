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

public partial class all_fogotpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string msg = UserDAL.ForgotPassword(txtEmail.Text);
        if (msg == null)
            lblMsg.Text = "A mail has been sent with password. Please use password to login again!";
        else
            lblMsg.Text = "Error -->" + msg;
    }
}
