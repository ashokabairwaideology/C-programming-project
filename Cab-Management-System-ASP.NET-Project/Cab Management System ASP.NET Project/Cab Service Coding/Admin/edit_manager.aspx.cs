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


public partial class Admin_edit_manager : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();



    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["ManagerId"].ToString();

            con.Open();
            string myquery = null;
            myquery = "select *from ManagerCreation where ManagerId='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox1.Text = dt.Rows[0]["ManageName"].ToString();
            TextBox2.Text = dt.Rows[0]["Address"].ToString();
            TextBox3.Text = dt.Rows[0]["Qualification"].ToString();
            TextBox4.Text = dt.Rows[0]["DOB"].ToString();
            RadioButtonList1.Text = dt.Rows[0]["Gender"].ToString();
            TextBox5.Text = dt.Rows[0]["Ph"].ToString();
            TextBox6.Text = dt.Rows[0]["EmailID"].ToString();
            DropDownList1.Text = dt.Rows[0]["Designation"].ToString();
            DropDownList2.Text = dt.Rows[0]["Department"].ToString();
            TextBox9.Text = dt.Rows[0]["DOJ"].ToString();
            TextBox10.Text = dt.Rows[0]["Age"].ToString();
        }
    
    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        string id= Request.QueryString["ManagerId"].ToString();
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "update ManagerCreation set ManageName='" + TextBox1.Text + "',Address='" + TextBox2.Text + "',Qualification='" + TextBox3.Text + "',DOB='" + TextBox4.Text + "',Gender='" + RadioButtonList1.Text + "',Ph='" + TextBox5.Text + "',EmailID='" + TextBox6.Text + "',Designation='" + DropDownList1.Text + "',Department='" + DropDownList2.Text + "',DOJ='" + TextBox9.Text + "',Age='" + TextBox10.Text + "'where ManagerId='"+id+"'";

        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Redirect("~/Admin/view managers.aspx");

    }
}
