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

public partial class Manager_changepsw : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
            }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = Session["firstname"].ToString();
        /*string oldpwd = txt_oldpsw.Text;

        string sql="select *from empinsert where paswd='"+oldpwd+"' and empid='"+id+"'";

        DataSet ds = new DataSet();
        ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

        //if (ds.Tables[0].Rows[0]["paswd"].ToString() = oldpwd)
        if(ds.Tables[0].Rows.Count==1)
        {
            string nwpwd = txt_newpsw.Text;
            string sql1 = "update empinsert set paswd='" + nwpwd + "' where firstname='" + id + "'";
            DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql1);

        }
        else
        {
            Response.Write("Password Dous Not Match with Ur Database");
        }*/
        if (txt_newpsw.Text == txt_confrm.Text)
        {
            SqlCommand cmd = new SqlCommand("update empinsert set paswd='" + txt_newpsw.Text + "' where empid='" + id + "'", con);
            Response.Write("Successfully Changed");
            cmd.ExecuteNonQuery();
        }
        else
        {
            Response.Write("Plz Enter Valied Password");
        }


       /* con.Open();
        string id=Session["firstname"].ToString();
        cmd = new SqlCommand("update empinsert set paswd='" + txt_newpsw.Text + "' where firstname=" + id + "", con);
        cmd.ExecuteNonQuery();
        con.Close();*/
    }
}
