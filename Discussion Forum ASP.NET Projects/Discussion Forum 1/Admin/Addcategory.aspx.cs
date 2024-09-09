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

public partial class Admin_AddCategory : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection("data source=.\\SQLEXPRESS;Initial Catalog=BB;Integrated security=true");
    SqlCommand cmd,cmd1;

    protected void Page_Load(object sender, EventArgs e)
    {
    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        string loc_catname = txt_catname  .Text;
        string loc_des = txt_des .Text;
        string myquery = "insert into Category (cat_id,categoryname,Description) values ('','" + loc_catname + "','" + loc_des + "')" + "select @@Identity";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;

        int uniq_id = Convert.ToInt32(cmd.ExecuteScalar());
        string catid = uniq_id + loc_catname[0].ToString();

        string sql = "update Category set cat_id='" + catid + "' where unique_id=" + uniq_id + "";
        cmd1 = new SqlCommand();
        cmd1.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd1.CommandText = sql;
        cmd1.ExecuteNonQuery();
        lbl_valid.Text = "insert succesfully";

   
    }
}
