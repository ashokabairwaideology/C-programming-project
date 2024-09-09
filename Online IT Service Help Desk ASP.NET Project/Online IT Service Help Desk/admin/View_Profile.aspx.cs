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

public partial class admin_View_Profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string id = Session["emp_id"].ToString();

        string sql = "select * from emp_info where emp_id='" + id + "'";
        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

        EID.Text = Session["emp_id"].ToString();
        FNAME.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
        LNAME.Text = ds.Tables[0].Rows[0]["lasrt_name"].ToString();
        EMAIL.Text = ds.Tables[0].Rows[0]["email_id"].ToString();
        MOBILE.Text = ds.Tables[0].Rows[0]["phone_no"].ToString();
        CITY.Text = ds.Tables[0].Rows[0]["city"].ToString();
        STATE.Text = ds.Tables[0].Rows[0]["state"].ToString();
        ZIP.Text = ds.Tables[0].Rows[0]["zip"].ToString();
        DOB.Text = ds.Tables[0].Rows[0]["dob"].ToString();
        DOJ.Text = ds.Tables[0].Rows[0]["doj"].ToString();
        POSITION.Text = ds.Tables[0].Rows[0]["position"].ToString();
        ADDRESS.Text = ds.Tables[0].Rows[0]["address"].ToString();



    }
}
    
