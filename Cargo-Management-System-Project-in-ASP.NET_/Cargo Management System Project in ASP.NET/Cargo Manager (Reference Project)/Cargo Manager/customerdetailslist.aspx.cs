using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class customerdetailslist : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
            

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        select();

    }

    protected void select()
{
            con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from CustmerDetails1", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "CustmerDetails1");
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();
}
    protected void Button2_Click(object sender, EventArgs e)
    {
        for(int i=0;i<GridView1.Rows.Count;i++)
        {
            CheckBox cbx=((CheckBox)GridView1.Rows[i].Cells[i].FindControl("checkbox1"));
            if(cbx!=null)
        {
            if(cbx.Checked)
            {
                string Customername = GridView1.Rows[i].Cells[1].Text;
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustmerDetails1 where customername='" + Customername + "'",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script> confirm('record deleted sucessfully')</script>");
                    select();
            }

            }
        }
       
    }
}
