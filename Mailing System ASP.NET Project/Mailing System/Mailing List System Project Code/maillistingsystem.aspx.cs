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
using System.Net ;
using System.Net.Mail ;
public partial class maillistingsystem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string query = "select * from user_subject";


            string cnstr = ConfigurationSettings.AppSettings["dbconnection"];
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();


            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataSet ds = new DataSet();

            da.Fill(ds, "user_subject");

            dgrid.DataSource = ds;
            dgrid.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminhome.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string query = "select * from user_subject where subject='" + ddlsubject.SelectedItem.Text + "'";


        string cnstr = ConfigurationSettings.AppSettings["dbconnection"];
        SqlConnection cn = new SqlConnection(cnstr);
        cn.Open();


        SqlDataAdapter da = new SqlDataAdapter(query, cn);

        DataSet ds = new DataSet();

        da.Fill(ds, "user_subject");

        dgrid.DataSource = ds;
        dgrid.DataBind();




    }
    protected void dgrid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void dgrid_ItemCommand(object source, DataGridCommandEventArgs e)
    {
      try 
        {
        DataGridItem dgi;
            int  i = 0;
            
        MailMessage  oMessage=new MailMessage ();
        
            
               
        string s=e.Item .Cells [1].Text.ToString (); 

                oMessage.Subject = "Hello! " + s ;
                oMessage.Body = "hai....";
                oMessage.IsBodyHtml = true;
                oMessage.To.Add(new MailAddress(e.Item .Cells [1].Text.ToString ()));
                oMessage.Priority = MailPriority.High;
        SmtpClient  client= new SmtpClient();
                client.Send(oMessage);

                Response.Write("<script>alert('Message Has Been Sent')</script>");
          
        }
        catch (System .Exception i)
        {
            Response.Write ("<script>alert('Message  Sending Failed')</script>");
        }
    }
}
