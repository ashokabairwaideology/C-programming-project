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
using System.Windows.Forms;


namespace VIP
{
	/// <summary>
	/// Summary description for InsuarnaceRenewal.
	/// </summary>
	public class InsuarnaceRenewal : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Label Label1;

		SqlConnection sqlcon;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
	    
		protected string con="server=.;database=pubs;uid=sa;pwd=sa";
		public int pno;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.Calendar Calendar1;
		SqlDataReader dr;
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			
			sqlcon = new SqlConnection(con);
			sqlcon.Open();
			
          
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
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Calendar1.SelectionChanged += new System.EventHandler(this.Calendar1_SelectionChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			 pno=Convert.ToInt32(TextBox1.Text.Trim());
			Session["pnum"]=pno;


			

			string comString1="select PK_PNO from VIP_POLICIES where PK_PNO="+pno;
			SqlCommand cmd2= new SqlCommand(comString1,sqlcon);
			dr=cmd2.ExecuteReader();
			dr.Read();
			
			if(!dr.HasRows)
			{
				Response.Write("The entered policy no is not existing");
				dr.Close();
			}
              
			else
			{
				dr.Close();
				string comStr="select START_DATE from VIP_POLICIES where PK_PNO=" + pno;
				SqlCommand SqlCom= new SqlCommand(comStr,sqlcon);
				SqlDataReader reader= SqlCom.ExecuteReader();
				reader.Read();
				TextBox2.Text=Convert.ToString(reader["START_DATE"]);
			}
        }

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
	        //int a=pno;	
			Calendar1.Visible=true;
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int pnum1=Convert.ToInt32(Session["pnum"]);
			DateTime dt = Calendar1.SelectedDate;
		
			string comStr1="update VIP_POLICIES set END_DATE='" + dt +"' where PK_PNO=" + pnum1;
			SqlCommand SqlCom1=new SqlCommand(comStr1,sqlcon);
			SqlCom1.ExecuteNonQuery();
			
//          MessageBox.Show("Policy Renewed","Message");
			//Response.Redirect("ClaimReport.aspx");
			Response.Write("Policy Renewed");
			sqlcon.Close();
		}

		private void Calendar1_SelectionChanged(object sender, System.EventArgs e)
		{
			Calendar1.Visible=false;
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text="";
			TextBox2.Text="";
								
		}
	}
}
