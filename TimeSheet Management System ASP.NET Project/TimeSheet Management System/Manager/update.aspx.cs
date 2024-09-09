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

public partial class Manager_update : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=AKITS-CSE\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
    SqlCommand cmd,cmd1,cmd2;
    SqlDataReader dr;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con.Open();
            string  id= Session["firstname"].ToString();
            cmd = new SqlCommand("select * from empinsert where empid='"+id+"'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_fname.Text = dr[2].ToString();
                txt_lname.Text = dr[3].ToString();
                txt_psw.Text = dr[4].ToString();
                txt_gen.Text = dr[5].ToString();
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
                txt_position.Text = dr[16].ToString();
                
            }

            dr.Close();
            con.Close();
        }
            
        }
        //cmd2 = new SqlCommand("select * from empinsert where position='MANAGER'", con);
        //dr = cmd2.ExecuteReader();
       // while (dr.Read())
        //{
        //    DropDownList1.Items.Add(dr[0].ToString());
        //}
        //dr.Close();
        //con.Close();

   

   

  // protected void btn_clk_Click(object sender, EventArgs e)
    //{
      //          con.Open();
        
        
    protected void btn_update_Click(object sender, EventArgs e)
    {
        con.Open();
        string id = Session["firstname"].ToString();
        cmd1 = new SqlCommand("update empinsert set firstname='" + txt_fname.Text + "',lastname='" + txt_lname.Text + "',paswd='" + txt_psw.Text + "',gender='" + txt_gen.Text + "',phonenum='" + txt_pno.Text + "',email='" + txt_emai.Text + "',altemail='" + txt_atml.Text + "',exprnc='" + txt_exc.Text + "',dateofjoin='" + txt_doj.Text + "',address='" + txt_adress.Text + "',city='" + txt_city.Text + "',state='" + txt_state.Text + "',country='" + txt_cuntry.Text + "',pincode='" + txt_pinc.Text + "',position='" + txt_position.Text + "' where empid='" +id+ "'", con);
        cmd1.ExecuteNonQuery();
        Response.Write("Updated");
        con.Close();
    }
}


