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
using System.Data.SqlClient;

public partial class Admine_Approve_action : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd,cmd1;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string id = Request.QueryString["relid"].ToString();
        string sql1 = "update timesheet set status='Modified'where timesheetid='" + id + "' ";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql1);
        
       

        Response.Redirect("~/Admine/Approve.aspx");
    }
}

/* string sql2 = "select * from createproj";
 SqlDataAdapter da = new SqlDataAdapter(sql2, con);
 DataTable dt1 = new DataTable();
 da.Fill(dt1);
 string money = dt1.Rows[0]["payforemp"].ToString();

 string sql3 = "select * from timesheet where empid='" + id + "'";
 SqlDataAdapter da1 = new SqlDataAdapter(sql3, con);
 DataTable dt = new DataTable();
 da1.Fill(dt);
 string eid = id;
 string pid = dt.Rows[0]["projectid"].ToString();
 string tot = dt.Rows[0]["totaltime"].ToString();

 string sql4 = "select * from assgto where allocateto='" + id + "'";
 SqlDataAdapter da2 = new SqlDataAdapter(sql4, con);
 DataTable dt2 = new DataTable();
 da2.Fill(dt2);
 string pname = dt2.Rows[0]["projectname"].ToString();

 cmd = new SqlCommand("insert into billing values('"+pid+"','"+pname+"','"+eid+"','"+tot+"','','Active')", con);
 cmd.ExecuteScalar();

 int mon = int.Parse(money.ToString());
 int hrs = int.Parse(tot.ToString());
 int payment=(mon*hrs);

 cmd1 = new SqlCommand("update billing set payment='" + payment + "' where empid='" + eid + "'", con);
 cmd1.ExecuteNonQuery();*/