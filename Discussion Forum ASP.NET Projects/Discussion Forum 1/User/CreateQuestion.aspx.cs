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

public partial class User_PostQuestion : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
            con.Open();

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Category";

            SqlDataAdapter adpt = new SqlDataAdapter(cmd.CommandText, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            DropDownList1.DataTextField = "categoryname";
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "select one");
            con.Close();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string category_name = DropDownList1.Text;
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();
        string sql = "select * from SubCategory where cat_id='" + category_name + "' ";

        SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);

        DropDownList2.DataTextField = "subcat_name";
        DropDownList2.DataValueField = "subcat_id";
        DropDownList2.DataSource = dt;
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "select one");
   
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string subcat = DropDownList2.Text;
        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");

        con.Open();
        string sql1 = "select * from tbl_topic where subcat_id='" + subcat + "'";

        SqlDataAdapter adpt = new SqlDataAdapter(sql1, con);
        DataTable dt1 = new DataTable();
        adpt.Fill(dt1);

        DropDownList3.DataTextField = "topic";
        DropDownList3.DataValueField = "topic_id";
        DropDownList3.DataSource = dt1;
        DropDownList3.DataBind();
        DropDownList3.Items.Insert(0, "select one");
   
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string cat = DropDownList1.Text;
        string subcat = DropDownList2.Text;
        string topicname = DropDownList3.Text;
        string que = TextBox1.Text;
        string name = Session["UserName"].ToString();

        SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
        con.Open();

        string sql2 = "insert into tbl_question values ('" + cat + "'," + subcat + ",'" + topicname + "','" + que + "','','',getdate(),'"+name+"')";

        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql2;
        cmd.ExecuteNonQuery();

        Response.Write("inserted");

        con.Close();
  
    }
}
