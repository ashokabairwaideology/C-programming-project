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
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.Image Image1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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

		
			

		
            
			
			

		

		private void TextBox2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string uname,pwd,reader1;
						uname=TextBox1.Text.Trim();
						pwd=TextBox2.Text.Trim();
						
			            
						Session["username"]=uname;
			
						string com= "select * from VIP_LOGIN where UNAME='" + uname + "' and PWD='" + pwd + "'";
						string con="server=.;database=pubs;uid=sa;pwd=sa";
						SqlConnection sqlcon = new SqlConnection(con);
						sqlcon.Open();
						SqlCommand sqlcom = new SqlCommand(com,sqlcon);
					    SqlDataReader reader = sqlcom.ExecuteReader();
					     reader.Read();
			             reader1=Convert.ToString(reader["UNAME"]).Trim();
						
						if(!reader.HasRows)
							Response.Write("Invalid user");
						else if(reader1.Trim().Equals("admin"))
							Response.Redirect("ClaimReport1.aspx");
						else if(reader1.Trim().Equals("staff"))
							Response.Redirect("ClaimReport.aspx");

		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text="";
			TextBox2.Text="";
		
		}
}
}
