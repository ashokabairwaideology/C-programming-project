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

public partial class Manager_viewt : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            /*string name = Session["firstname"].ToString();
            cmd = new SqlCommand("select * from empinsert where empid='" + name + "'", con);
            dr = cmd.ExecuteReader();
            
                GridView1.DataSource = dr;
                GridView1.DataBind();*/
            
            string id = Session["firstname"].ToString();

            cmd = new SqlCommand("select * from empinsert where empid='" + id + "'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_fname.Text = dr[2].ToString();
                txt_lname.Text = dr[3].ToString();
                rdb_gender.Text = dr[5].ToString();
                txt_psw.Text = dr[4].ToString();
                txt_pno.Text = dr[6].ToString();
                txt_emai.Text = dr[7].ToString();
                txt_atml.Text = dr[8].ToString();
                txt_exc.Text = dr[9].ToString();
                txt_doj.Text = dr[10].ToString();
                txt_adress.Text = dr[11].ToString();
                txt_city.Text = dr[12].ToString();
                txt_state.Text = dr[13].ToString();
                txt_cuntry.Text = dr[14].ToString();
                txt_pinc.Text = dr[15].ToString();
                txt_posn.Text = dr[16].ToString();
                txt_status.Text = dr[17].ToString();
            }
            dr.Close();
            con.Close();
        
            
        }
        catch (Exception ex)
        {
            Response.Write("handlor.." + ex.Message.ToString());
        }
        con.Close();
    }
}
