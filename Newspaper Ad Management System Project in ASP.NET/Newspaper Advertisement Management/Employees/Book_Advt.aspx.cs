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

public partial class Employees_Book_Advt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!IsPostBack)
        {
            string sql = "select * from AdvertaisementDetails";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql);

            ddl_addcod.DataTextField = "Addcode";
            ddl_addcod.DataSource = ds;
            ddl_addcod.DataBind();
            }
    }

    protected void ddl_addcod_SelectedIndexChanged(object sender, EventArgs e)
    {
        string id = ddl_addcod.Text;
        string sql1="select * from AdvertaisementDetails where Addcode='"+id+"'";
        DataSet ds1=new DataSet();
        ds1 = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, sql1);
        txt_pno.Text = ds1.Tables[0].Rows[0]["Pageno"].ToString();
        txt_plocation.Text = ds1.Tables[0].Rows[0]["Pagelocaton"].ToString();
        txt_advtdesc.Text = ds1.Tables[0].Rows[0]["Description"].ToString();
        rb_cost.Items.Insert(0, ds1.Tables[0].Rows[0]["Costscblkwhite"].ToString() + "(1-sq/cm cost for block & white)");
        rb_cost.Items.Insert(1, ds1.Tables[0].Rows[0]["Costsccolor"].ToString() + "(1-sq/cm cost for Coler)");
        rb_cost.Visible = true;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string BW = rb_cost.Text;
        
        string[] BW1=BW.Split('(');
        
        if (rb_cost.SelectedIndex == 0)
        {
            double bwcost =Convert.ToDouble(BW1[0].ToString());
            int sqcm=Convert.ToInt32(txt_totalcost.Text);
            double cost = (bwcost * sqcm);
            txt_totalAdvtCost.Text = cost.ToString();
        }
        else if (rb_cost.SelectedIndex == 1)
        {
            double bwcost = Convert.ToDouble(BW1[0].ToString());
            int sqcm = Convert.ToInt32(txt_totalcost.Text);
            double cost = (bwcost * sqcm);
            txt_totalAdvtCost.Text = cost.ToString();
 
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string empid = Session["Username"].ToString();
        string cusid = Request.QueryString["usid"].ToString();
        string addcod = ddl_addcod.Text;
        string dop = txt_Dateofpublish.Text;
        string sqcm = txt_totalcost.Text;
        string totcost = txt_totalAdvtCost.Text;
        string BW = rb_cost.Text;

        string[] BW1 = BW.Split('(');
        if (rb_cost.SelectedIndex == 0)
        {
            double bwcost = Convert.ToDouble(BW1[0].ToString());
            string pagestatus="Black & White";
            string sql = "insert into CustomerAddDetails values('" + empid + "','" + cusid + "','" + addcod + "',getdate(),'" + dop + "','" + bwcost + "','" + sqcm + "','" + totcost + "','" + pagestatus + "')";
            DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
        }
        else if (rb_cost.SelectedIndex == 1)
        {
            double bwcost = Convert.ToDouble(BW1[0].ToString());
            string pagestatus = "Colour";
            string sql = "insert into CustomerAddDetails values('" + empid + "','" + cusid + "','" + addcod + "',getdate(),'" + dop + "','" + bwcost + "','" + sqcm + "','" + totcost + "','" + pagestatus + "')";
            DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, sql);
 
        }
    }
}
