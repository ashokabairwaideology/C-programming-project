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
	public class ClaimReport : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Label Label1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
            
			string uname1=Convert.ToString(Session["username"]);
			if(uname1.Equals("staff"))
			{
				HyperLink1.Visible=false;
			}
			
			
			string conStr="server=.;database=pubs;uid=sa;pwd=sa";
			string comStr="select FK_PNO,HOLDER_NAME,CLAIM_DATE from VIP_CLAIMED_POLICIES order by CLAIM_DATE desc";
			SqlConnection con= new SqlConnection(conStr);
			con.Open();
			SqlDataAdapter da=new SqlDataAdapter(comStr,conStr);
			DataSet ds= new DataSet();
			da.Fill(ds);
			DataGrid1.DataSource=ds;

			
			Page.DataBind();




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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
