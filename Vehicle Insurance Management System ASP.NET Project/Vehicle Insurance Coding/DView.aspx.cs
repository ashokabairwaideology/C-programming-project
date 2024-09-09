using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace VIP
{
	/// <summary>
	/// Summary description for DView.
	/// </summary>
	public class DView : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Label Label8;
        protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label10;
		
		
		protected int a;	
		static string conStr="server=.;database=pubs;uid=sa;pwd=sa";
        SqlConnection con= new SqlConnection(conStr);

		
        			
		SqlDataReader dr;

		private void Page_Load(object sender, System.EventArgs e)
		{
			
           
			string usr=Convert.ToString(Session["username"]);
			if(usr.Equals("staff"))
			{
				Button1.Visible=false;
				Button2.Visible=false;
			}	
	
			
			
			string s=Request.QueryString["FK_PNO"];
            a=Convert.ToInt16(s);
			//Response.Write("This is FK" + a);
			
			string comStr="select * from VIP_CLAIMED_POLICIES where FK_PNO=" + a;
			
			con.Open();
			SqlCommand com= new SqlCommand(comStr,con);
			dr= com.ExecuteReader();
      		
			dr.Read();
			Label1.Text=dr.GetValue(0).ToString();
			Label2.Text=dr.GetValue(1).ToString();
			Label3.Text=dr.GetValue(2).ToString();
			Label4.Text=dr.GetValue(3).ToString();
			Label5.Text=dr.GetValue(4).ToString();
			Label6.Text=dr.GetValue(5).ToString();
			Label7.Text=dr.GetValue(6).ToString();
			Label8.Text=dr.GetValue(7).ToString();
			Label9.Text=dr.GetValue(8).ToString();
			Label10.Text=dr.GetValue(9).ToString();


			if(Label10.Text.Trim().Equals("Accept") || Label10.Text.Trim().Equals("Reject"))
			{
				Button1.Visible=false;
				Button2.Visible=false;
			}


			con.Close();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			con.Open();
            string comStr1="update VIP_CLAIMED_POLICIES set STATUS='Accept' where FK_PNO=" + a;		SqlCommand com1=new SqlCommand(comStr1,con);
			com1.ExecuteNonQuery();
			//Response.Write("Claim is Accepted");
			Label10.Text="Accepted";
			con.Close();
			
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			con.Open();
			string comStr1="update VIP_CLAIMED_POLICIES set STATUS='Reject' where FK_PNO=" + a;
			SqlCommand com1=new SqlCommand(comStr1,con);
			com1.ExecuteNonQuery();
			//Response.Write("Claim is Rejected");
			Label10.Text="Rejected";
			con.Close();
		}
	}
}
