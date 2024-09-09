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

public partial class Admin_AddSubCategory : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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
            con.Close();
            DropDownList1.Items.Insert(0, "select one option");
        }

    }
    protected void btn_insert_Click(object sender, EventArgs e)
    {
        con.Open();
        string cat = DropDownList1.Text;
        string loc_subcatname = txt_subcatname.Text;
        string loc_des = txt_des.Text;
        string sql = "insert into SubCategory values ('" + cat + "','" + loc_subcatname + "','" + loc_des + "')";

        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
        Label5.Text = "Inserted succesfully";
        con.Close();

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
