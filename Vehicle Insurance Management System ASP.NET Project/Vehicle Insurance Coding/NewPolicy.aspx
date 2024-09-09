<%@ Page language="c#" Codebehind="NewPolicy.aspx.cs" AutoEventWireup="false" Inherits="VIP.NewPolicy" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>NewPolicy</title>
<meta content="Microsoft Visual Studio .NET 7.1" name=GENERATOR>
<meta content=C# name=CODE_LANGUAGE>
<meta content=JavaScript name=vs_defaultClientScript>
<meta content=http://schemas.microsoft.com/intellisense/ie5 name=vs_targetSchema>
  </HEAD>
<body bgColor=#ccccff>
<form id=Form1 method=post runat="server">
<P align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;<FONT size=5>NewInsurance Form</FONT></P>
<TABLE cellSpacing=1 cellPadding=1 width=300 align=left border=0>
  <TR>
    <TD><asp:label id=Label2 runat="server">Name</asp:label></TD>
    <TD><asp:textbox id=TextBox1 runat="server"></asp:textbox>
      <P align=center><asp:requiredfieldvalidator id=RequiredFieldValidator1 runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Required"></asp:requiredfieldvalidator></P></TD>
    <TD>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id=Label10 runat="server" Width="104px">Purchase Date</asp:label></TD>
    <TD><asp:imagebutton id=ImageButton3 tabIndex=8 runat="server" ImageUrl="file:///C:\Inetpub\wwwroot\VIP\images\calendar.bmp"></asp:imagebutton></TD>
    <TD></TD></TR>
  <TR>
    <TD><asp:label id=Label3 runat="server">Age</asp:label></TD>
    <TD><asp:textbox id=TextBox2 tabIndex=1 runat="server" DESIGNTIMEDRAGDROP="217"></asp:textbox></TD>
    <TD>&nbsp;&nbsp;&nbsp; <asp:label id=Label11 runat="server" Width="104px" DESIGNTIMEDRAGDROP="218">Chassis number</asp:label></TD>
    <TD><asp:textbox id=TextBox6 tabIndex=10 runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD><asp:label id=Label4 runat="server">Address</asp:label></TD>
    <TD><asp:textbox id=TextBox3 tabIndex=2 runat="server" Height="96px"></asp:textbox></TD>
    <TD>&nbsp;&nbsp;&nbsp; <asp:label id=Label12 runat="server">Engine Number</asp:label></TD>
    <TD><asp:textbox id=TextBox7 tabIndex=11 runat="server" DESIGNTIMEDRAGDROP="224"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD><asp:label id=Label5 runat="server">Phone Number</asp:label></TD>
    <TD><asp:textbox id=TextBox4 tabIndex=3 runat="server"></asp:textbox></TD>
    <TD>&nbsp;&nbsp; <asp:label id=Label13 runat="server">Service Tax</asp:label></TD>
    <TD><asp:textbox id=TextBox8 tabIndex=12 runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD><asp:label id=Label6 runat="server">Vehicle Type</asp:label></TD>
    <TD><asp:dropdownlist id=DropDownList1 tabIndex=4 runat="server" Width="144px" AutoPostBack="True">
							<asp:ListItem Value="TwoWheeler">TwoWheeler</asp:ListItem>
							<asp:ListItem Value="ThreeWheeler">ThreeWheeler</asp:ListItem>
							<asp:ListItem Value="FourWheeler">FourWheeler</asp:ListItem>
							<asp:ListItem Value="Twentyfour Wheeler">Twentyfour Wheeler</asp:ListItem>
						</asp:dropdownlist></TD>
    <TD>&nbsp;&nbsp;&nbsp; <asp:label id=Label14 runat="server">Insured Amount</asp:label></TD>
    <TD><asp:textbox id=TextBox9 tabIndex=13 runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD><asp:label id=Label8 runat="server">Maker Name</asp:label></TD>
    <TD><asp:dropdownlist id=DropDownList2 tabIndex=5 runat="server" Width="144px" AutoPostBack="True"></asp:dropdownlist></TD>
    <TD>&nbsp;&nbsp;&nbsp; <asp:label id=Label15 runat="server">Premium Amount</asp:label></TD>
    <TD><asp:textbox id=TextBox10 tabIndex=14 runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD><asp:label id=Label7 runat="server" Width="134px" DESIGNTIMEDRAGDROP="242">Vehicle Model Name</asp:label></TD>
    <TD><asp:dropdownlist id=DropDownList3 tabIndex=6 runat="server" Width="144px" DESIGNTIMEDRAGDROP="243"></asp:dropdownlist></TD>
    <TD>&nbsp;&nbsp;&nbsp; <asp:label id=Label16 runat="server" Width="80px">Start Date</asp:label></TD>
    <TD><asp:imagebutton id=ImageButton1 tabIndex=15 runat="server" ImageUrl="file:///C:\Inetpub\wwwroot\VIP\images\calendar.bmp"></asp:imagebutton></TD>
    <TD></TD></TR>
  <tr>
    <td><asp:label id=Label9 runat="server">Showroom Value</asp:label></td>
    <td>
      <P align=center><asp:textbox id=TextBox5 tabIndex=7 runat="server"></asp:textbox></P></td>
    <td>&nbsp;&nbsp;&nbsp; <asp:label id=Label17 runat="server" DESIGNTIMEDRAGDROP="672">End Date</asp:label></td>
    <td><asp:imagebutton id=ImageButton2 tabIndex=17 runat="server" DESIGNTIMEDRAGDROP="673" ImageUrl="file:///C:\Inetpub\wwwroot\VIP\images\calendar.bmp"></asp:imagebutton></td>
    <td></td></tr>
  <tr>
    <td></td>
    <td><asp:button id=Button1 tabIndex=19 runat="server" Width="104px" Height="22px" Text="Submit"></asp:button></td>
    <td>&nbsp; <asp:button id=Button2 tabIndex=20 runat="server" Width="104px" Height="22px" Text="Reset"></asp:button></td>
    <td></td>
    <td></td></tr></TABLE>
<P align=center>
<TABLE id=Table1 cellSpacing=1 cellPadding=1 width=300 border=0>
  <TR>
    <TD style="HEIGHT: 192px"><asp:calendar id=Calendar1 tabIndex=9 runat="server" Visible="False" Width="137px" Height="152px" DESIGNTIMEDRAGDROP="2100"></asp:calendar></TD></TR>
  <TR>
    <TD><asp:calendar id=Calendar2 tabIndex=16 runat="server" Visible="False" Width="138px" Height="152px" DESIGNTIMEDRAGDROP="2101"></asp:calendar></TD></TR>
  <TR>
    <TD><asp:calendar id=Calendar3 tabIndex=18 runat="server" Visible="False" Width="121px" Height="152px"></asp:calendar></TD></TR></TABLE></P>
<P align=center><STRONG><FONT size=6></FONT></STRONG></P>
<P align=center>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
<P align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
<P align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
<P align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
<P align=left>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P></form>
	
	</body>
</HTML>
