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
	/// Summary description for NewPolicy.
	/// </summary>
	public class NewPolicy : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Label Label11;
		protected System.Web.UI.WebControls.Label Label12;
		protected System.Web.UI.WebControls.Label Label15;
		protected System.Web.UI.WebControls.Label Label16;
		protected System.Web.UI.WebControls.Label Label17;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Web.UI.WebControls.Label Label13;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.Label Label14;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		
		
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.TextBox TextBox4;
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.TextBox TextBox6;
		protected System.Web.UI.WebControls.TextBox TextBox7;
		protected System.Web.UI.WebControls.TextBox TextBox8;
		protected System.Web.UI.WebControls.TextBox TextBox9;
		protected System.Web.UI.WebControls.TextBox TextBox10;
		protected System.Web.UI.WebControls.TextBox TextBox5;
		protected System.Web.UI.WebControls.Calendar Calendar2;
		protected System.Web.UI.WebControls.Calendar Calendar3;
		
		SqlConnection sqlcon;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label10;
		protected System.Web.UI.WebControls.Calendar Calendar1;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected string con="server=.;database=pubs;uid=sa;pwd=sa";
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
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.DropDownList1.SelectedIndexChanged += new System.EventHandler(this.DropDownList1_SelectedIndexChanged);
			this.DropDownList2.SelectedIndexChanged += new System.EventHandler(this.DropDownList2_SelectedIndexChanged);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Calendar1.SelectionChanged += new System.EventHandler(this.Calendar1_SelectionChanged);
			this.Calendar2.SelectionChanged += new System.EventHandler(this.Calendar2_SelectionChanged);
			this.Calendar3.SelectionChanged += new System.EventHandler(this.Calendar3_SelectionChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string name=TextBox1.Text.Trim();
			int age=Convert.ToInt32(TextBox2.Text.Trim());
			string address=TextBox3.Text.Trim();
			Double phno=Convert.ToDouble(TextBox4.Text.Trim());
			
			
			
		
		
			string vehicletype=DropDownList1.SelectedItem.Value.Trim();
			string makername=DropDownList2.SelectedItem.Value.Trim();
			string modelname=DropDownList3.SelectedItem.Value.Trim();
       	
			int    showroomvalue=Convert.ToInt32(TextBox5.Text.Trim());
			DateTime purchasedate=Calendar1.SelectedDate;
			Calendar1.Visible=false;
			Double chassisno=Convert.ToDouble(TextBox6.Text.Trim());
			Double engineno=Convert.ToDouble(TextBox7.Text.Trim());
			int servicetax=Convert.ToInt32(TextBox8.Text.Trim());
			Double insuredamount=Convert.ToDouble(TextBox9.Text.Trim());
			int premiumamount=Convert.ToInt32(TextBox10.Text.Trim());
			DateTime startdate=Calendar2.SelectedDate;
			Calendar2.Visible=false;
			DateTime enddate=Calendar3.SelectedDate;
			Calendar3.Visible=false;

			Random ran=new Random();
			int policynum=ran.Next(1000);
			
			
			string comStr="insert VIP_POLICIES values( " +policynum + ",'" + name + "'," + age + " , '"+ address + "' , " + phno + "  , '"+ vehicletype + "' ,'" + modelname + "','" + makername  + "', " + showroomvalue + " ,'" + purchasedate + "' , " + chassisno + " , " + engineno + " ," + servicetax + " ," + insuredamount + " , " + premiumamount + " , '" + startdate + "' , '" + enddate + "')";
			SqlCommand sqlcom=new SqlCommand(comStr,sqlcon);
			sqlcom.ExecuteNonQuery();

			Response.Write("your policy number is "+policynum);

			clear();
	        
		}//buttonclick

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Calendar1.Visible=true;
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Calendar2.Visible=true;
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Calendar3.Visible=true;
		}

		private void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
			if(DropDownList1.SelectedItem.Text.Trim().Equals("TwoWheeler"))
			{
				DropDownList2.Items.Add("Bajaj");
				DropDownList2.Items.Add("Honda");
				DropDownList2.Items.Add("RoyalEnfield");
				DropDownList2.Items.Add("Suzuki");
                				
			}


			if(DropDownList1.SelectedItem.Text.Trim().Equals("ThreeWheeler"))
			{
				DropDownList2.Items.Add("Bajaj");
				DropDownList2.Items.Add("Mahindra");
			}	
			if(DropDownList1.SelectedItem.Text.Trim().Equals("FourWheeler"))
			{
				DropDownList2.Items.Add("Toyota");
				DropDownList2.Items.Add("Tata");
				DropDownList2.Items.Add("MercedesBenz");
			}



		}//dlist1 changed

		
		private void DropDownList2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
			if(DropDownList2.SelectedItem.Text.Trim().Equals("Bajaj")&& DropDownList1.SelectedItem.Text.Trim().Equals("TwoWheeler"))
			{
				DropDownList3.Items.Add("Boxer");
				DropDownList3.Items.Add("Pulsar");
				DropDownList3.Items.Add("Calibar");
				DropDownList3.Items.Add("HudiBaba");	
			}

			if(DropDownList2.SelectedItem.Text.Trim().Equals("Honda"))
			{
				DropDownList3.Items.Add("CD100");
				DropDownList3.Items.Add("Splendor");
				DropDownList3.Items.Add("PassionPlus");
				DropDownList3.Items.Add("Karizma"); 
			}


			if(DropDownList2.SelectedItem.Text.Trim().Equals("RoyalEnfield"))
			{
				DropDownList3.Items.Add("Bullet");
				DropDownList3.Items.Add("ThunderBird");
			}

			if(DropDownList2.SelectedItem.Text.Trim().Equals("Suzuki"))
			{
				DropDownList3.Items.Add("Samurai");
				DropDownList3.Items.Add("Shavolin");
				DropDownList3.Items.Add("Fierro");
				DropDownList3.Items.Add("Haybuza");
			}
					
		
			
		
		if(DropDownList2.SelectedItem.Text.Trim().Equals("Bajaj")&& DropDownList1.SelectedItem.Text.Trim().Equals("ThreeWheeler"))
	{
		DropDownList3.Items.Add("AutoRikshaw");
		DropDownList3.Items.Add("Ape");
	}

	if(DropDownList2.SelectedItem.Text.Trim().Equals("Mahindra"))
{
	DropDownList3.Items.Add("Champion");
	DropDownList3.Items.Add("Sarpanch");
}
			

			
			
			
	

	if(DropDownList2.SelectedItem.Text.Trim().Equals("Toyota"))
{
	DropDownList3.Items.Add("Qualis");
	DropDownList3.Items.Add("Corolla");
	DropDownList3.Items.Add("Innova");
}
	if(DropDownList2.SelectedItem.Text.Trim().Equals("Tata"))
{
	DropDownList3.Items.Add("SafariDicor");
	DropDownList3.Items.Add("Indica");
	DropDownList3.Items.Add("TataSumo");
}
	if(DropDownList2.SelectedItem.Text.Trim().Equals("MercedesBenz"))
{
	DropDownList3.Items.Add("C Class");
	DropDownList3.Items.Add("E Class");
	DropDownList3.Items.Add("S Class");
}
}

		private void Calendar1_SelectionChanged(object sender, System.EventArgs e)
		{

			Calendar1.Visible=false;
		}

		private void Calendar2_SelectionChanged(object sender, System.EventArgs e)
		{
			Calendar2.Visible=false;
		}

		private void Calendar3_SelectionChanged(object sender, System.EventArgs e)
		{
			Calendar3.Visible=false;
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			clear();


		}//dlist2 changed

		private void clear()
		{
			TextBox1.Text="";
			TextBox2.Text="";
			TextBox3.Text="";
			TextBox4.Text="";
			TextBox5.Text="";
			TextBox6.Text="";
			TextBox7.Text="";
			TextBox8.Text="";
			TextBox9.Text="";
			TextBox10.Text="";
			DropDownList1.Items.Clear();
			DropDownList2.Items.Clear();
			DropDownList3.Items.Clear();

		}
	
	}
}