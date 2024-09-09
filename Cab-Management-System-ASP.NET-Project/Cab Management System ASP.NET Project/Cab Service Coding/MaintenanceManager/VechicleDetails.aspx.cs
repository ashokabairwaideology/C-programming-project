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


public partial class MaintenanceManager_VechicleDetails : System.Web.UI.Page
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
            con.Open();

            string id = DropDownList1.Text;

            string myquery = null;
            myquery = "select * from RouteDetails ";

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = myquery;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr["routeid"].ToString());
                         }

            con.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string loc_vchno = TextBox9.Text; 
        string loc_vehiname = TextBox1.Text;
        string loc_Daily_rent = TextBox2.Text;
        string loc_vehiltype = RadioButtonList1.Text;
        string loc_regno = TextBox5.Text;
        string loc_rate = TextBox6.Text;
        string loc_capaacity = TextBox7.Text;
        string loc_routeid = DropDownList1.Text;
        con = new SqlConnection();
        con.ConnectionString = @"data source=RAJ-PC\SQLEXPRESS;Initial Catalog=cool cabs;Integrated Security=true";
        con.Open();
        
        string myquery = null;
        myquery = "insert into vehicledetails values('" + loc_vchno + "','" + loc_vehiname + "','" + loc_vehiltype + "','" + loc_regno + "','" + loc_rate + "','" + loc_capaacity + "','" + loc_routeid + "','inactive','" + loc_Daily_rent + "');" + "SELECT @@IDENTITY";
        cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = myquery;
        
        int loc_vehid = Convert.ToInt32(cmd.ExecuteScalar());

        string veId=loc_vchno[1].ToString()+loc_vehiname[2].ToString();


      

       
    }
}
