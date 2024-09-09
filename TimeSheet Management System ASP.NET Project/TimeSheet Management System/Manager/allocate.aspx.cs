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

public partial class Manager_allocate : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            string sql = "select * from empinsert where position='EMPLOYEE' and status='Active'" ;
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);
            
                    ddl_ass.DataTextField = "empid";
                    ddl_ass.DataValueField = "empid";
                    ddl_ass.DataSource = ds;
                    ddl_ass.DataBind();
                
            }

            string id = Session["firstname"].ToString();
            string sql1 = "select * from createproj where assineto='" + id + "'";
            DataSet ds1 = new DataSet();
           
            ds1 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql1);
            ddl_pname.DataTextField = "projname";
            ddl_pname.DataValueField = "projid";
            ddl_pname.DataSource = ds1;
            ddl_pname.DataBind();
                
    }
            
                
    
    protected void btn_click_Click(object sender, EventArgs e)
    {
        con.Open();

        string empid = Session["firstname"].ToString();
        string proid = ddl_pname.Text;
        string pname = ddl_pname.SelectedItem.ToString();
        //string aa = ddl_pname.SelectedValue.ToString();
       // string abc=ddl_pnam
        string empname = ddl_ass.Text;
        string status = txt_stus.Text;

        string sql3 = "insert into assgto values('" + empid + "','" + proid + "','" + pname + "','" + empname + "','" + status + "')";

        DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql3);

        
        string sql4 = "update empinsert set status='inactive' where empid='" + empname + "'";

        SqlCommand cmd1 = new SqlCommand(sql4, con);
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = sql4;
        cmd1.ExecuteNonQuery();
        con.Close();
    }

}

       // string sql4 = "select Max(allocateid) from assgto";

        //object obj = DAL.SqlHelper.ExecuteScalar(clsConnection.Connection, CommandType.Text, sql4);



       // string sql5 = "select projname from createproj where assineto='" + empid + "'";

        //DataSet ds = new DataSet();
        //ds = DAL.SqlHelper.ExecuteScalar(clsConnection.Connection, CommandType.Text, sql5);

        /* con.Open();
         string empid = Session["firstname"].ToString();    

         string sql3 = "insert into assgto values('"+empid+"','','" + ddl_pname.Text + "','" + ddl_ass.Text + "','"+txt_stus.Text+"')";
         cmd3 = new SqlCommand(sql3, con);
         cmd3.ExecuteNonQuery();

         string query = "select * from createproj where assineto='" + empid + "'";
       
         //DataSet ds = new DataSet();
        // ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, query);

         SqlDataAdapter d1=new SqlDataAdapter(query, con);
          DataSet ds = new DataSet();
         d1.Fill(ds);
        
        
         
         DataTable dt = new DataTable();
         d1.Fill(dt);

         string pid = dr2[1].ToString();

       


         cmd6 = new SqlCommand("update assgto set prijectid='" + pid + "' where allocatedby='" + empid + "'", con);
         cmd6.ExecuteNonQuery();

         con.Close();*/


/*string name = Session["firstname"].ToString();
string id;
cmd2 = new SqlCommand("select * from empinsert where firstname='" + name + "'", con);
dr2 = cmd2.ExecuteReader();
while (dr2.Read())
{
    id = dr2[0].ToString();
}
cmd1 = new SqlCommand("select * from createproj where assineto ='"+id+"'", con);
dr1= cmd1.ExecuteReader();
while (dr1.Read())
{
    ddl_pname.Items.Add(dr1[2].ToString());
}
dr.Close();
dr1.Close();
con.Close();*/




//string pid = dr2[1].ToString();
/*  con.Open();

           cmd = new SqlCommand("select * from empinsert where position='EMPLOYEE'", con);
           dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               ddl_ass.Items.Add(dr[1].ToString());
           }
           dr.Close();

           string empid = Session["firstname"].ToString();
            

           string sql2 = "select * from createproj where assineto='" + empid + "'";
           cmd2 = new SqlCommand(sql2, con);
           dr1 = cmd2.ExecuteReader();
           while (dr1.Read())
           {
               ddl_pname.Items.Add(dr1[2].ToString());
                
           }
           dr1.Close();
           con.Close();*/