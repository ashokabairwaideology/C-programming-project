<%@ Page language="c#" Codebehind="InsuarnaceRenewal.aspx.cs" AutoEventWireup="false" Inherits="VIP.InsuarnaceRenewal" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>InsuarnaceRenewal</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
  </HEAD>
	<body bgColor=#ccccff >
		<form id="Form1" method="post" runat="server">
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
				&nbsp;&nbsp;&nbsp;
				<asp:Label id="Label1" runat="server" Width="256px" Height="32px" Font-Bold="True" Font-Size="X-Large"
					Font-Italic="True" Font-Underline="True" ForeColor="#000040">Insurance Renewal</asp:Label></P>
			<P><STRONG>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</STRONG></P>
<P><STRONG></STRONG>&nbsp;</P>
<P><STRONG>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<TABLE id=Table3 cellSpacing=1 cellPadding=1 width=300 align=center border=0>
  <TR>
    <TD>
      <TABLE id=Table1 cellSpacing=2 cellPadding=1 width=300 align=center 
      border=0>
        <TR>
          <TD>
<asp:Label id=Label2 runat="server" Font-Bold="True" Width="112px">Policy Number    :</asp:Label></TD>
          <TD>
            <P>
<asp:TextBox id=TextBox1 runat="server" AutoPostBack="True"></asp:TextBox>
<asp:RequiredFieldValidator id=RequiredFieldValidator1 runat="server" ControlToValidate="TextBox1" ErrorMessage="PolicyNumber required"></asp:RequiredFieldValidator></P></TD></TR>
        <TR>
          <TD>
<asp:Label id=Label3 runat="server" Font-Bold="True">Start Date  :</asp:Label></TD>
          <TD>
            <P>
<asp:TextBox id=TextBox2 runat="server"></asp:TextBox></P></TD></TR>
        <TR>
          <TD>
<asp:Label id=Label4 runat="server" Font-Bold="True">End Date</asp:Label></TD>
          <TD>
<asp:ImageButton id=ImageButton1 runat="server" ImageUrl="file:///C:\Inetpub\wwwroot\VIP\images\calendar.bmp"></asp:ImageButton></TD></TR>
        <TR>
          <TD>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:Button id=Button1 runat="server" Text="Renew"></asp:Button></TD>
          <TD>
            <P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
            <P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:Button id=Button2 runat="server" Text="Reset"></asp:Button></P>
            <P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            </P></TD></TR></TABLE></TD>
    <TD>
      <TABLE id=Table2 style="WIDTH: 151px; HEIGHT: 215px" cellSpacing=1 
      cellPadding=1 width=151 align=right border=0>
        <TR>
          <TD>
<asp:Calendar id=Calendar1 runat="server" Height="160px" Width="144px" Visible="False"></asp:Calendar></TD></TR></TABLE></TD></TR></TABLE>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</P></STRONG>
<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</P>
		</form>
	</body>
</HTML>
