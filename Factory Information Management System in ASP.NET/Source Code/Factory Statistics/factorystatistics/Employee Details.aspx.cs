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
public partial class Factory_Statistics_factorystatistics_Employee_Details : System.Web.UI.Page
{
    private SqlConnection cnn = new SqlConnection("server=IPOG-A95E1056D3;database=factorystatistics;uid=sa;password=sqlserver");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select fname,fcode from empdetails", cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());
                DropDownList2.Items.Add(dr[1].ToString());
            }
            dr.Close();
        }
        cnn.Close();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        cnn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select fname,fcode,numofemps,totsalofemps,bonusforemps from empdetails where fname='" + DropDownList1.SelectedItem.ToString() + "' and fcode ='" + DropDownList2.SelectedItem.ToString() + "'", cnn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}
