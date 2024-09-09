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

public partial class Admine_billng : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd, cmd1;
    SqlDataReader dr,dr1,dr2,dr3,dr4;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Open();
            string id = Session["firstname"].ToString();
            cmd = new SqlCommand("select * from createproj", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[2].ToString());
            }
            dr.Close();

            con.Close();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();
        cmd1 = new SqlCommand("select * from assgto where projectname='"+DropDownList1.Text+"'", con);
      
        dr1 = cmd1.ExecuteReader();
        while (dr1.Read())
        {
            DropDownList2.Items.Add(dr1[4].ToString());
        }
        dr1.Close();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        
        GridView1.Visible = true;
         string sql2 = "select * from createproj where projname='"+DropDownList1.Text+"'";
        SqlDataAdapter da = new SqlDataAdapter(sql2, con);
        DataTable dt1 = new DataTable();
        da.Fill(dt1);       
        int money = int.Parse(dt1.Rows[0]["payforemp"].ToString());

        string sql8 = "select * from billing where empid='" + DropDownList2.Text + "' and pname='"+DropDownList1.Text+"'";
        SqlDataAdapter da1 = new SqlDataAdapter(sql8, con);
        DataTable dt9 = new DataTable();
        da1.Fill(dt9);
        if (dt9.Rows.Count == 0)
        {
            SqlDataAdapter dat = new SqlDataAdapter("select * from timesheet where empid='" + DropDownList2.Text + "' and status='Modified'", con);
            DataTable dt3 = new DataTable();
            dat.Fill(dt3);
            string pids = dt3.Rows[0]["projectid"].ToString();

            SqlCommand cmd6 = new SqlCommand("select sum(totaltime) from timesheet  where empid='" + DropDownList2.Text + "' and status='Modified'", con);
            int tothrs = int.Parse(cmd6.ExecuteScalar().ToString());

            int sal = tothrs * money;
            SqlCommand cmd8 = new SqlCommand("insert into billing values('" + DropDownList2.Text + "','" + DropDownList1.Text + "','" + pids + "'," + tothrs + ","+money+"," + sal + ")", con);
            cmd8.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("select * from billing where pname='" + DropDownList1.Text + "' and empid='" + DropDownList2.Text + "' ", con);
            dr2 = cmd2.ExecuteReader();
            GridView1.DataSource = dr2;
            GridView1.DataBind();
            dr2.Close();
        }
        else
        {
            SqlCommand cmd6 = new SqlCommand("select sum(totaltime) from timesheet  where empid='" + DropDownList2.Text + "' and status='Modified'", con);
            int tothrs1 = int.Parse(cmd6.ExecuteScalar().ToString());
            int sal1 = tothrs1 * money;
            SqlCommand cmd8 = new SqlCommand("update billing set tothrs="+tothrs1+" ,sal="+sal1+" where empid='"+ DropDownList2.Text +"'", con);
            cmd8.ExecuteNonQuery();

            SqlCommand cmd10 = new SqlCommand("select * from billing where pname='" + DropDownList1.Text + "' and empid='" + DropDownList2.Text + "' ", con);
            dr2 = cmd10.ExecuteReader();
            GridView1.DataSource = dr2;
            GridView1.DataBind();
            dr2.Close();
        }
            con.Close();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        
        SqlDataAdapter adt = new SqlDataAdapter("select * from createproj where projname='"+DropDownList1.Text+"'", con);
        DataTable dt = new DataTable();
        adt.Fill(dt);
        TextBox2.Text = dt.Rows[0]["payformangr"].ToString();
        TextBox3.Text = dt.Rows[0]["estimtdcost"].ToString();
        int emp=int.Parse(dt.Rows[0]["payforemp"].ToString());
        string id = dt.Rows[0]["projid"].ToString();
        
        SqlCommand cmd2 = new SqlCommand("select sum(totaltime) from timesheet  where projectid='" + id + "' and status='Modified'", con);
        int tottime = int.Parse(cmd2.ExecuteScalar().ToString());
        
        int empmoney=tottime*emp;   
        TextBox1.Text=empmoney.ToString();
        
        int est = int.Parse(TextBox3.Text.ToString());
        int man = int.Parse(TextBox2.Text.ToString());
        int prof=est-(man+empmoney);

        TextBox4.Text=prof.ToString();
           
           
     
        con.Close();

    }
}
