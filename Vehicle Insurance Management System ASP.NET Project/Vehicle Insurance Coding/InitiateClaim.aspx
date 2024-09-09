<%@ Page language="c#" Codebehind="InitiateClaim.aspx.cs" AutoEventWireup="false" Inherits="VIP.InitiateClaim" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>InitiateClaim</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
  </HEAD>
	<body bgColor=#ccccff >
		<form id="Form1" method="post" runat="server">
<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
<P>&nbsp;</P>
<P>&nbsp;</P>
<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
		<asp:label id=Label1 runat="server" Width="232px" Height="24px" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Font-Underline="True" ForeColor="Navy">Initiating Claim</asp:label></P>
<P></P>
			<P>
<TABLE id=Table1 cellSpacing=3 cellPadding=0 width=300 align=left border=0>
  <TR>
    <TD style="WIDTH: 139px">
				<asp:label id="Label2" runat="server">Policy Number</asp:label></TD>
    <TD>
      <P> 
				
				<asp:textbox id="TextBox1" runat="server" Width="160px" AutoPostBack="True"></asp:textbox>
				<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Height="17px" Width="160px" ErrorMessage="PolicyNumber required"
					ControlToValidate="TextBox1"></asp:requiredfieldvalidator></P></TD>
    <TD>&nbsp;&nbsp;&nbsp;&nbsp; 
				<asp:label id="Label6" runat="server">Place of Accident</asp:label></TD>
    <TD> 
				
				<asp:textbox id="TextBox5" tabIndex="4" runat="server" Width="160px"></asp:textbox></TD></TR>
  <TR>
    <TD style="WIDTH: 139px">
				<asp:label id="Label3" runat="server" Width="112px">Policy Start Date</asp:label></TD>
    <TD>
      <P>
<asp:textbox id=TextBox2 tabIndex=1 runat="server" Width="160px"></asp:textbox></P></TD>
    <TD>&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:label id=Label7 runat="server" Width="184px" Height="20px">Date of occurence of accident</asp:label></TD>
    <TD>
				<asp:imagebutton id="ImageButton1" tabIndex="5" runat="server" ImageUrl="file:///C:\Inetpub\wwwroot\VIP\images\calendar.bmp"></asp:imagebutton></TD></TR>
  <TR>
    <TD style="WIDTH: 139px">
      <P>
<asp:label id=Label4 runat="server" DESIGNTIMEDRAGDROP="26">Policy End date</asp:label></P></TD>
    <TD>
      <P>
				<asp:textbox id="TextBox3" tabIndex="2" runat="server" Width="160px"></asp:textbox></P></TD>
    <TD>&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:label id=Label8 runat="server" DESIGNTIMEDRAGDROP="28">Insured Amount</asp:label></TD>
    <TD>
				<asp:textbox id="TextBox7" tabIndex="7" runat="server" Width="160px"></asp:textbox></TD></TR>
  <TR>
    <TD style="WIDTH: 139px">
				<asp:label id="Label5" runat="server" Width="128px">Policy Holder Name</asp:label></TD>
    <TD>
				<asp:textbox id="TextBox4" tabIndex="3" runat="server" Width="160px"></asp:textbox></TD>
    <TD>&nbsp;&nbsp;&nbsp;&nbsp; 
				
				<asp:label id="Label9" runat="server">Claimable Amount</asp:label></TD>
    <TD>
<asp:textbox id=TextBox8 tabIndex=8 runat="server" Width="160px" DESIGNTIMEDRAGDROP="34"></asp:textbox></TD></TR>
  <TR>
    <TD style="WIDTH: 139px"></TD>
    <TD>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:button id=Button1 tabIndex=9 runat="server" Width="96px" Height="26px" Text="Claim" DESIGNTIMEDRAGDROP="38"></asp:button></TD>
    <TD> 
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:button id="Button2" tabIndex="10" runat="server" Height="26px" Width="96px" Text="Reset"></asp:button></TD>
    <TD></TD></TR></TABLE><asp:calendar id="Calendar1" tabIndex="6" runat="server" Visible="False"></asp:calendar>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 

					</form></P>
	</body>
</HTML>
