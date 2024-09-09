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


public partial class MovementManager_RouteDetails : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            con = new SqlConnection();
            con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
            //con.Open();

            string id = DropDownList1.Text;

            string myquery = null;
            myquery = "select * from AddCitys ";
            SqlDataAdapter adpt = new SqlDataAdapter(myquery, con.ConnectionString);
            DataTable dt = new DataTable();
            adpt.Fill(dt);

            DropDownList1.DataValueField="code";
            DropDownList1.DataTextField = "cityname";
            DropDownList2.DataValueField = "code";
            DropDownList2.DataTextField = "cityname";
            
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();

            //cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = myquery;
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    DropDownList1.Items.Insert(dr["cityname"].ToString());
            //    DropDownList2.Items.Add(dr["cityname"].ToString());
            //}
            
            //con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
        con.Open();
        string loc_cname = DropDownList1.SelectedItem.ToString();
        string loc_desti = DropDownList2.SelectedItem.ToString();
        string loc_Distance = TextBox2.Text;
        string loc_rutdis = TextBox1.Text;
        string myquery = null;
        myquery = "insert into RouteDetails values(' ','" + loc_cname + "','" + loc_desti + "','" + loc_rutdis + "','" + loc_Distance + "');" + "SELECT @@IDENTITY";

        
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        int Rid = Convert.ToInt32(cmd.ExecuteScalar());
        string Rtid = DropDownList1.SelectedValue + Rid + DropDownList2.SelectedValue;

        string update = "update RouteDetails set routeid='" + Rtid+ "' where RTID=" + Rid +"";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = update;
        cmd.ExecuteScalar();
        Response.Write("Record updated...");




    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        con = new SqlConnection();
        con.ConnectionString = @"data source=raj-pc\sqlexpress;initial catalog=cool cabs;integrated security=true";
        con.Open();

        

    }
}
