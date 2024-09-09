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

public partial class HRManager_EditEmpDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["EmId"].ToString();

            con.Open();
            string myquery = null;
            myquery = "select *from EmployeDetails where EId='" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            TextBox1.Text = dt.Rows[0]["EmpId"].ToString();

            TextBox12.Text = dt.Rows[0]["Password"].ToString();
            TextBox2.Text = dt.Rows[0]["CandidateAdd"].ToString();
            TextBox3.Text = dt.Rows[0]["Qualification"].ToString();
           
            TextBox4.Text = dt.Rows[0]["DOB"].ToString();
           
            RadioButtonList1.Text = dt.Rows[0]["Gender"].ToString();
            TextBox6.Text = dt.Rows[0]["phno"].ToString();
            
            DropDownList1.Text = dt.Rows[0]["Designation"].ToString();
            DropDownList2.Text = dt.Rows[0]["Departement"].ToString();
            TextBox7.Text = dt.Rows[0]["Dateofjoin"].ToString();
            TextBox8.Text = dt.Rows[0]["Status"].ToString();
            TextBox9.Text = dt.Rows[0]["Age"].ToString();
            TextBox10.Text = dt.Rows[0]["TimeSpan"].ToString();

            TextBox13.Text = dt.Rows[0]["Expereance"].ToString();
            TextBox14.Text = dt.Rows[0]["licenceno"].ToString();
            TextBox15.Text = dt.Rows[0]["Noofacc"].ToString();
           
        }
    

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string id = Request.QueryString["EmId"].ToString();
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        string myquery = null;
        myquery = "update EmployeDetails set EmpId='" + TextBox1.Text + "',Password='" + TextBox12.Text + "',CandidateAdd='" + TextBox2.Text + "',Qualification='" + TextBox3.Text + "',DOB='" + TextBox4.Text + "',Gender='" + RadioButtonList1.Text + "',phno='" + TextBox6.Text + "',Designation='" + DropDownList1.Text + "',Departement='" + DropDownList2.Text + "',Dateofjoin='" + TextBox7.Text + "',Status='" + TextBox8.Text + "',Age='" + TextBox9.Text + "',TimeSpan='" + TextBox10.Text + "',Imgpath='" + FileUpload2.FileName + "',Expereance='" + TextBox13.Text + "',licenceno='" + TextBox14.Text + "',Noofacc='" + TextBox15.Text + "' where EId='" + id + "'";
       
       
        
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        cmd.ExecuteNonQuery();
        Response.Redirect("~/HRManager/ViewEmpDetails.aspx");

    }
}
