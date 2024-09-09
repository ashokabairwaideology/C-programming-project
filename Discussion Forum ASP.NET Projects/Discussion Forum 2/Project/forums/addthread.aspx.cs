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

public partial class addthread : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        User u = (User)Session["user"];
        string msg = ThreadDAL.AddNewThread(u.Id, ddlSubjects.SelectedItem.Value, txtText.Text);
        if (msg == null)
            lblMsg.Text = "Thread has been added sucessfully!";
        else
            lblMsg.Text = "Sorry! Error -->" + msg;
    }
}
