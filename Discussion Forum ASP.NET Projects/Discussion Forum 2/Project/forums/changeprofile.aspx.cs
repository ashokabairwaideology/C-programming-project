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

public partial class changeprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Page.IsPostBack)
        {
            User u = (User)Session["user"];
            txtFullname.Text = u.FullName;
            txtOccup.Text = u.Occupation;
        }


    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        User u = (User)Session["user"];
        string msg = UserDAL.ChangeProfile(u.Id, txtFullname.Text, txtOccup.Text);
        if (msg == null)   // success
        {
            // change object in memory
            u.Occupation = txtOccup.Text;
            u.FullName = txtFullname.Text;
            lblMsg.Text = "Changed Profile Successfully!";
        }
        else
             lblMsg.Text = "Error -->" + msg;
         try
         {
             string filename = "images/" + u.Id + ".jpg";
             FileUpload1.SaveAs(Request.MapPath(filename));
         }
         catch (Exception ex)
         {
         }
    }
}
