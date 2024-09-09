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

public partial class User_ViewProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string name = Session["UserName"].ToString();
        string sql1 = "select * from Registration where UserName='" + name + "'";

        SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        lbl_Fname.Text = dt.Rows[0]["FirstName"].ToString();
        lbl_Lname.Text = dt.Rows[0]["LastName"].ToString();
        lbl_Uname.Text = dt.Rows[0]["UserName"].ToString();
        lbl_pwd.Text = dt.Rows[0]["Password"].ToString();
        lbl_cpwd.Text = dt.Rows[0]["ConPassword"].ToString();
        lbl_email.Text = dt.Rows[0]["EmailID"].ToString();
        lbl_altemail.Text = dt.Rows[0]["AltEmailId"].ToString();
        lbl_gender.Text = dt.Rows[0]["Gender"].ToString();
        lbl_marsts.Text = dt.Rows[0]["martstatus"].ToString();
        lbl_dob.Text = dt.Rows[0]["DOB"].ToString();
        lbl_phno.Text = dt.Rows[0]["PhoneNO"].ToString();
        lbl_hintq.Text = dt.Rows[0]["HintQ"].ToString();
        lbl_hinta.Text = dt.Rows[0]["HintA"].ToString();
        lbl_city.Text = dt.Rows[0]["City"].ToString();
        lbl_state.Text = dt.Rows[0]["State"].ToString();




    }
}
