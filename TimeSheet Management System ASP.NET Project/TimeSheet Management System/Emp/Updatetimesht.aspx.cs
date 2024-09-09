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

public partial class Emp_Updatetimesht : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd, cmd1;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
         {
             con.Open();
            
             string e_id = Session["firstname"].ToString();
            string tid = Request.QueryString["updateid"].ToString();
                 string sql = "select * from timesheet where timesheetid='" + tid + "'";
                 SqlDataAdapter da = new SqlDataAdapter(sql, con);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
             if (dt.Rows.Count == 1)
             {
                 string em_id = Session["firstname"].ToString();

                                          
                 cmd = new SqlCommand("select * from timesheet where timesheetid='" + tid + "'", con);
                 dr = cmd.ExecuteReader();
             while (dr.Read())
             {
                 TextBox1.Text=dr[2].ToString();
                 txt_date.Text=dr[3].ToString();
                 txt_anareq.Text=dr[4].ToString();
                 txt2_anal.Text = dr[5].ToString();
                 txt1_desg.Text = dr[6].ToString();
                 txt2_design.Text = dr[7].ToString();
                 txt1_devlp.Text = dr[8].ToString();
                 txt_2devlop.Text = dr[9].ToString();
                 txt_task.Text = dr[10].ToString();
                 txt_bug.Text = dr[11].ToString();
                 txt1_testng.Text = dr[12].ToString();
                 txt2_tesng.Text = dr[13].ToString();
                 txt3_tesng.Text = dr[14].ToString();
                 txt4_tesng.Text = dr[15].ToString();
                txt_sttus.Text = dr[17].ToString();

             }
             }

            
             }
             con.Close();
             }
            
        
       
    
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        string eid = Session["firstname"].ToString();


        string pid = TextBox1.Text;
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
            cmd1 = new SqlCommand("update timesheet set date='" + txt_date.Text + "',anareq='" + txt_anareq.Text + "',prepdesign='" + txt2_anal.Text + "',highlevel='" + txt1_desg.Text + "',lowlevel='" + txt2_design.Text + "',writngcode='" + txt1_devlp.Text + "',prepatech='" + txt_2devlop.Text + "',perftask='" + txt_task.Text + "',bug='" + txt_bug.Text + "',unittsng='" + txt1_testng.Text + "',systesng='" + txt2_tesng.Text + "',integtesng='" + txt3_tesng.Text + "',preptestcase='" + txt4_tesng.Text + "',totaltime='',status='" + txt_sttus.Text + "' where empid='" + eid + "'", con);
            cmd1.ExecuteNonQuery();
            Response.Write("updated");
        }
        else
        {
                Response.Write("Working Time Should Be Less Than 9hr Per Day");
        }
        con.Close();
    
    }    
    
        
}    
    
    

