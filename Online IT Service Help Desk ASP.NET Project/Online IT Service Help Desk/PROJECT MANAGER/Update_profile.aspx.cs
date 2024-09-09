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

public partial class PROJECT_MANAGER_Update_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Session["emp_id"].ToString();

            string sql = "select * from emp_info where emp_id='" + id + "'";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

            TextBox1.Text = Session["emp_id"].ToString();
            E_FNAME.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
            E_LNAME.Text = ds.Tables[0].Rows[0]["lasrt_name"].ToString();
            EMAIL.Text = ds.Tables[0].Rows[0]["email_id"].ToString();
            MOBILE.Text = ds.Tables[0].Rows[0]["phone_no"].ToString();
            CITY.Text = ds.Tables[0].Rows[0]["city"].ToString();
            STATE.Text = ds.Tables[0].Rows[0]["state"].ToString();
            ZIP.Text = ds.Tables[0].Rows[0]["zip"].ToString();
            DOB.Text = ds.Tables[0].Rows[0]["dob"].ToString();
            ADDRS.Text = ds.Tables[0].Rows[0]["address"].ToString();

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string eid = TextBox1.Text;
        string EFname = E_FNAME.Text;
        string ELname = E_LNAME.Text;
        string email = EMAIL.Text;
        string addres = ADDRS.Text;
        string mobile = MOBILE.Text;
        string city = CITY.Text;
        string state = STATE.Text;
        string zip = ZIP.Text;
        string dob = DOB.Text;

        string sql1 = "update emp_info set first_name='" + EFname + "',lasrt_name='" + ELname + "',phone_no='" + mobile + "',email_id='" + email + "',city='" + city + "',state='" + state + "',zip='" + zip + "',dob='" + dob + "',address='" + addres + "'where emp_id='" + eid + "'";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql1);

        lbl_updte.Visible = true;
        lbl_updte.Text = "Your profile updated Sucessfully......";

    }
}
