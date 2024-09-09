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

public partial class Emp_entertimesheet : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd,cmd1;
    SqlDataReader dr;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Session["firstname"].ToString();
            con.Open();
            
            string sql = "select * from assgto where allocateto='" + id + "'";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
            
            ddl_pname.DataTextField = "projectname";
            ddl_pname.DataValueField = "projectid";

            ddl_pname.DataSource = ds;
            ddl_pname.DataBind();
            
                con.Close();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        //string id = Session["firstname"].ToString();
        //string sql = "select * from assgto where allocateto='" + id + "'";
        //DataSet ds = new DataSet();
        //ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
        //ddl_pname.DataTextField = "projectname";
        //ddl_pname.DataValueField = "projectid";
        
        //ddl_pname.DataSource = ds;
        //ddl_pname.DataBind();
         string eid = Session["firstname"].ToString();
        string sql="select * from timesheet where empid='"+eid+"' and date='"+txt_date.Text+"'";
        SqlDataAdapter dqt=new SqlDataAdapter(sql,con);
        DataTable dt = new DataTable();
        dqt.Fill(dt);
        if (dt.Rows.Count == 0)
        {

            string pid = ddl_pname.Text;
            string date = txt_date.Text;
            string anareq = txt_anareq.Text;
            string anal2 = txt2_anal.Text;
            string desng1 = txt1_desg.Text;
            string desng2 = txt2_design.Text;
            string devlp1 = txt1_devlp.Text;
            string devlp2 = txt_2devlop.Text;
            string task = txt_task.Text;
            string bug = txt_bug.Text;
            string test1 = txt1_testng.Text;
            string test2 = txt2_tesng.Text;
            string test3 = txt3_tesng.Text;
            string test4 = txt4_tesng.Text;
            string status = txt_sttus.Text;




            int total = int.Parse(anareq.ToString()) +
            int.Parse(anal2.ToString()) +
            int.Parse(desng1.ToString()) +
            int.Parse(desng2.ToString()) +
            int.Parse(devlp1.ToString()) +
            int.Parse(devlp2.ToString()) +
            int.Parse(task.ToString()) +
            int.Parse(bug.ToString()) +
            int.Parse(test1.ToString()) +
            int.Parse(test2.ToString()) +
            int.Parse(test3.ToString()) +
            int.Parse(test4.ToString());

            if (total <= 9)
            {
                cmd1 = new SqlCommand("insert into timesheet values('" + eid + "','" + pid + "','" + date + "','" + anareq + "','" + anal2 + "','" + desng1 + "','" + desng2 + "','" + devlp1 + "','" + devlp2 + "','" + task + "','" + bug + "','" + test1 + "','" + test2 + "','" + test3 + "','" + test4 + "'," + total + ",'Enterd')", con);
                cmd1.ExecuteNonQuery();
               // cmd = new SqlCommand("update timesheet set totaltime=" + total + " where empid='" + eid + "'", con);
                //cmd.ExecuteNonQuery();
                Response.Write("Inserted");
            }
            else
            {
                Response.Write("Working Time Should Be Less Than 9hr Per Day");
            }
        }
        else
        {
            Response.Write("Sorry Already Yor Are Entered Today Timesheet");
        }
        con.Close();
    
    }
}


// SqlCommand cmd2=new SqlCommand("select * from timesheet where empid='"+eid+"'",con);
/*    SqlDataAdapter da = new SqlDataAdapter("select * from timesheet where empid='" + eid + "'",con);
    DataTable dt = new DataTable();
    string ranal1 = dt.Rows[0]["anareq"].ToString();
    string ranal2 = dt.Rows[0]["prepdesign"].ToString();
    string high = dt.Rows[0]["highlevel"].ToString();
    string low= dt.Rows[0]["lowlevel"].ToString();
    string Code = dt.Rows[0]["writngcode"].ToString();
    string tech = dt.Rows[0]["prepatech"].ToString();
    string rtask = dt.Rows[0]["perftask"].ToString();
    string rbug = dt.Rows[0]["bug"].ToString();
    string rtest1 = dt.Rows[0]["unittsng"].ToString();
    string rtest2 = dt.Rows[0]["systesng"].ToString();
    string rtest3 = dt.Rows[0]["integtesng"].ToString();
    string rtest4 = dt.Rows[0]["preptestcase"].ToString();
    string rtot = dt.Rows[0]["totaltime"].ToString();

   int r1=int.Parse(ranal1.ToString());
   int r2=int.Parse(ranal2.ToString());
   int r3=int.Parse(high.ToString());
   int r4=int.Parse(low.ToString());
   int r5=int.Parse(Code.ToString());
   int r6=int.Parse(tech.ToString());
   int r7=int.Parse(rtask.ToString());
   int r8=int.Parse(rbug.ToString());
   int r9 = int.Parse(rtest1.ToString());
   int r10 = int.Parse(rtest2.ToString());
   int r11= int.Parse(rtest3.ToString());
   int r12= int.Parse(rtest4.ToString());
   //int r13= int.Parse(rtot.ToString());


        
   string pid = ddl_pname.Text;
   string date = txt_date.Text;
   string anareq = txt_anareq.Text;
   string anal2 = txt2_anal.Text;
   string desng1 = txt1_desg.Text;
   string desng2 = txt2_design.Text;
   string devlp1 = txt1_devlp.Text;
   string devlp2 = txt_2devlop.Text;
   string task = txt_task.Text;
   string bug = txt_bug.Text;
   string test1 = txt1_testng.Text;
   string test2 = txt2_tesng.Text;
   string test3 = txt3_tesng.Text;
   string test4 = txt4_tesng.Text;
   string status = txt_sttus.Text;




   int e1=int.Parse(anareq.ToString());
   int e2=int.Parse(anal2.ToString());
   int e3= int.Parse(desng1.ToString());
   int e4= int.Parse(desng2.ToString());
   int e5= int.Parse(devlp1.ToString());
   int e6= int.Parse(devlp2.ToString());
   int e7= int.Parse(task.ToString());
   int e8= int.Parse(bug.ToString());
   int e9= int.Parse(test1.ToString());
   int e10= int.Parse(test2.ToString());
   int e11= int.Parse(test3.ToString());
   int e12=int.Parse(test4.ToString());


   int t1=r1+e1;
   int t2=r2+e2;
   int t3=r3+e3;
   int t4=r4+e4;
   int t5=r5+e5;
   int t6=r6+e6;
   int t7=r7+e7;
   int t8=r8+e8;
   int t9=r9+e9;
   int t10=r10+e10;
   int t11=r11+e11;
   int t12=r12+e12;
  // int t13=r13+
       */



//string total = test4 + txt_anareq;
//int tot = int.Parse(total.ToString());
