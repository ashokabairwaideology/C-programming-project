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
	/// Summary description for InitiateClaim.
	/// </summary>
	public class InitiateClaim : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.TextBox TextBox5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.Calendar Calendar1;
		protected System.Web.UI.WebControls.TextBox TextBox4;

		SqlConnection sqlcon;
		protected string con="server=.;database=pubs;uid=sa;pwd=sa";
		public DateTime sdate,edate,accidentdate;
		string hname,place;
		double insuredamount,claimedamount;
		int policyno;
		protected System.Web.UI.WebControls.TextBox TextBox7;
		protected System.Web.UI.WebControls.TextBox TextBox8;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		SqlDataReader dr,dr1;
		protected System.Web.UI.WebControls.Label Label3;
	  
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			sqlcon=new SqlConnection(con);
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

		private void Button1_Click(object sender, System.EventArgs e)
		{
			int policyno1=Convert.ToInt32(Session["policynumber"]);
			DateTime sdate1=Convert.ToDateTime(Session["startdate"]);
			DateTime edate1=Convert.ToDateTime(Session["enddate"]);
			string hname1=Convert.ToString(Session["holdername"]);
			double insuredamount1=Convert.ToDouble(Session["insuredamt"]);


			place=TextBox5.Text.Trim();
			claimedamount=Convert.ToDouble(TextBox8.Text.Trim());
			accidentdate=Calendar1.SelectedDate;
            DateTime claimdate = Convert.ToDateTime(DateTime.Now.ToLongDateString());
			string status="pending";
			//int datedifference=DateTime.Compare(claimdate,accidentdate);
			//DateTime
			//	int DayOfYear = Abs(DateDiff("d",claimdate,accidentdate));

			TimeSpan ts=claimdate.Subtract(accidentdate);
			int datediff=ts.Days;
			
				//string datediff=dt1.ToString();		

			if(datediff<=7)// && claimedamount<=insuredamount1)
			{
				string comStr1="insert into VIP_CLAIMED_POLICIES values("+ policyno1+",'"+sdate1+"','"+edate1+"','"+hname1+"','"+place+"','"+accidentdate+"',"+insuredamount1+","+claimedamount+",'"+claimdate+"','"+status+"')";
				SqlCommand sqlcmd1=new SqlCommand(comStr1,sqlcon);
				sqlcmd1.ExecuteNonQuery();
				Response.Write("Policy Claim Submitted");
				sqlcon.Close();
			}
			else
			{
				Response.Write("You are not Eligible to claim the insurance after 7days from accident OR Claimamout should be less than insuredamount");
			}
		}

		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{
			
			/*if(RegularExpressionValidator1.IsValid==true)
			{
				TextBox1.AutoPostBack=false;
				RegularExpressionValidator1.Visible=true;
			}*/

			//else
			//{			
				policyno=Convert.ToInt32(TextBox1.Text.Trim());

				string comString1="select PK_PNO from VIP_POLICIES where PK_PNO="+policyno;
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
					string comString="select FK_PNO from VIP_CLAIMED_POLICIES where FK_PNO="+policyno;
					SqlCommand cmd1=new SqlCommand(comString,sqlcon);
					dr=cmd1.ExecuteReader();
					dr.Read();
			
			

					if(!dr.HasRows)
					{
						dr.Close();
						string comStr="select START_DATE,END_DATE,NAME,INSURED_AMOUNT from VIP_POLICIES where PK_PNO="+policyno;
						SqlCommand sqlcmd=new SqlCommand(comStr,sqlcon);
						dr1 = sqlcmd.ExecuteReader();
						dr1.Read();
						sdate=Convert.ToDateTime(dr1["START_DATE"]);
						edate=Convert.ToDateTime(dr1["END_DATE"]);
						hname=Convert.ToString(dr1["NAME"]);
						insuredamount=Convert.ToDouble(dr1["INSURED_AMOUNT"]);

						Session["policynumber"]=policyno;
						Session["startdate"]=sdate;
						Session["enddate"]=edate;
						Session["holdername"]=hname;
						Session["insuredamt"]=insuredamount;
  


						TextBox2.Text=Convert.ToString(sdate);
						TextBox3.Text=Convert.ToString(edate);
						TextBox4.Text=hname;
						TextBox7.Text=Convert.ToString(insuredamount);
					}

					else
					{
						Response.Write("This policy is already claimed");

					}
		               sqlcon.Close();
				}			

  // }
		}


		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Calendar1.Visible=true;
		}

		private void Calendar1_SelectionChanged(object sender, System.EventArgs e)
		{
			Calendar1.Visible=false;
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			TextBox1.Text="";
			TextBox2.Text="";
			TextBox3.Text="";
			TextBox4.Text="";
			TextBox5.Text="";
			TextBox7.Text="";
			TextBox8.Text="";
			RequiredFieldValidator1.Visible=false;

		}

		
	}
}
