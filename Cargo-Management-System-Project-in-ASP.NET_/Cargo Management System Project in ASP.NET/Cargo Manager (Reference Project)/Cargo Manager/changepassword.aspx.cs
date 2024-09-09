using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

public partial class changepassword : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
                con.Open();

        SqlCommand cmd = new SqlCommand("select * from register where Username='" + txtUsername.Text + "' and Password='" + txtCurrentpassword.Text + "'",con);
        SqlDataReader dr;
        Boolean boo = false;
        dr=cmd.ExecuteReader();
        if (dr.HasRows)
            boo = true;
        dr.Close();

        if (boo)
        {

            cmd.CommandText = "update register set password='" + txtNewpassword.Text + "' where username='" + txtUsername.Text + "' and password='" + txtCurrentpassword.Text + "'";

            
            cmd.ExecuteNonQuery();


            Label4.Text = "Successfully completed";
        }
       
        con.Close();
    }

    }



    

