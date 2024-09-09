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

public partial class search : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select distinct district from search where state='" + ddlStates.SelectedItem.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            ddldistrict.DataSource = ds;
            ddldistrict.DataTextField = "district";
            ddldistrict.DataBind();

            ds.Tables.Clear();
            da.SelectCommand.CommandText = "select address from search where state='" + ddlStates.SelectedItem + "' and district='" + ddldistrict.SelectedItem + "'";
            
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();


            con.Close();
        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlDataAdapter da=new SqlDataAdapter("select address from search where state='" +ddlStates.SelectedItem + "' and district='"+ddldistrict.SelectedItem+"'" ,con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        
        GridView1.DataSource = ds;
        GridView1.DataBind();
       
        
        con.Close();
    }
    protected void ddlStates_SelectedIndexChanged(object sender, EventArgs e)
    {

        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select distinct district from search where state='" + ddlStates.SelectedItem.Text + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);

        ddldistrict.DataSource = ds;
        ddldistrict.DataTextField = "district";
        ddldistrict.DataBind();

        ds.Tables.Clear();
        da.SelectCommand.CommandText = "select address from search where state='" + ddlStates.SelectedItem + "' and district='" + ddldistrict.SelectedItem + "'";
        
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();


        con.Close();
    }
}
