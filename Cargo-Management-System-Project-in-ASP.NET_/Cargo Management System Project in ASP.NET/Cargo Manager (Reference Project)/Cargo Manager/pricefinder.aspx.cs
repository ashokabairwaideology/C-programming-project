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
public partial class pricefinder : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("server=IPOG-A95E1056D3;database=CargoSystem;user id=sa;password=sqlserver");
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

      if (!IsPostBack)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from places", con);
            DataSet ds=new DataSet();
            da.Fill(ds, "places");
            
            
            if (ds.Tables.Count>0)
            {
                ddlOrigincity.DataSource = ds.Tables["places"];
                ddlOrigincity.DataValueField = "sno";
                ddlOrigincity.DataTextField = "placename";
                ddlOrigincity.DataBind();


                ddlDestinationcity.DataSource  = ds;
               ddlDestinationcity.DataValueField  = "sno";
                ddlDestinationcity.DataTextField  = "placename";
                ddlDestinationcity.DataBind();

                
            }


            da.SelectCommand.CommandText = "select * from weightprice";
            da.Fill(ds, "weightprice");
            if (ds.Tables.Count>0)
            {
                ddlWeight.DataSource = ds.Tables["weightprice"];
                ddlWeight.DataValueField = "price";
                ddlWeight.DataTextField = "weight";
                ddlWeight.DataBind();
            }
            con.Close();
            ddlOrigincity.Items.Insert(0, "--Select--");
            ddlDestinationcity.Items.Insert(0, "--Select--");
            ddlWeight.Items.Insert(0, "--Select--");
        }
 
    }
    protected void btnFind_Click(object sender, EventArgs e)
    {
       if (ddlOrigincity.SelectedItem.Text != "--Select--" && ddlDestinationcity.SelectedItem.Text != "--Select--" && ddlWeight.SelectedItem.Text != "--Select--")
        {

            decimal total = 0;
            if (ddlDestinationcity.SelectedItem.Text != ddlOrigincity.SelectedItem.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select price from placeprice where place1=" + ddlOrigincity.SelectedValue.ToString() + " and place2=" + ddlDestinationcity.SelectedValue.ToString(), con);

                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                    total = Convert.ToDecimal(dr[0].ToString());
                else
                {
                    dr.Close();
                    cmd.CommandText = "select price from placeprice where place2=" + ddlOrigincity.SelectedValue.ToString() + " and place1=" + ddlDestinationcity.SelectedValue.ToString();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                        total = Convert.ToDecimal(dr[0].ToString());
                }

                total += Convert.ToDecimal(ddlWeight.SelectedValue.ToString());
                Label4.Text = total.ToString()+"Rupees";


            }

        }

        else
            Label4.Text = "please select the fields";

    }

}
