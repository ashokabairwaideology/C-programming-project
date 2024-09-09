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

public partial class Admine_createproj : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd=new SqlCommand();
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string sql2 = "select * from empinsert where position='MANAGER' and status='Active'";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql2);


            dd_ass.DataTextField = "firstname";
            dd_ass.DataValueField = "empid";
            dd_ass.DataSource = ds;
            dd_ass.DataBind();
            /* dr = cmd3.ExecuteReader();
            while(dr.Read())
            {
                dd_ass.Items.Add(dr[2].ToString());
            }*/
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        string name = txt_prjname.Text;
        string statdate = txt_stddate.Text;
        string estdate = txt_estcost.Text;
        string cname = txt_cname.Text;
        string clotn = txt_cln.Text;
        string add = txt_add.Text;
        string poc = txt_poc.Text;
        string estcost = txt_estcost.Text;
        string type = rdb_typ.Text;
        string req = txt_resreq.Text;
        string man = txt_paymagr.Text;
        string emp = txt_payemp.Text;
        string tche = dd_tec.Text;
        string database = dd_database.Text;
        string assn = dd_ass.Text;


        if (FileUpload1.HasFile && FileUpload2.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Doc") + "/" + FileUpload1.FileName);
            string scopedoc = ("~/Doc") + "/" + FileUpload1.FileName;
            FileUpload2.SaveAs(Server.MapPath("~/Doc") + "/" + FileUpload2.FileName);
            string po = ("~/Doc") + "/" + FileUpload2.FileName;



            string sql = "insert into createproj values('','" + name + "','" + statdate + "','" + estdate + "','" + cname + "','" + clotn + "','" + add + "','" + poc + "','" + scopedoc + "','" + po + "','" +estcost +"','" + type + "','" + req + "','" + man + "','" + emp + "','" + tche + "','" + database + "','" + assn + "')" + " select @@identity";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int Eid = int.Parse(cmd.ExecuteScalar().ToString());
            string genid = name[0].ToString() + Eid;

            string sql2 = "update createproj set projid='" + genid + "' where uniqid=" + Eid + " ";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = sql2;
            cmd2.ExecuteNonQuery();

            string id = dd_ass.Text;
            string sql3 = "update empinsert set status='Inactive' where empid='" + id + "'";

            SqlCommand cmd1 = new SqlCommand(sql3, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = sql3;
            cmd1.ExecuteNonQuery();
            con.Close();
        }
        else
        {
            Response.Write("plz browse the files");
        }
    }
        
     }
  /*  protected void dd_ass_SelectedIndexChanged(object sender, EventArgs e)
    {
        con.Open();

    }*/
