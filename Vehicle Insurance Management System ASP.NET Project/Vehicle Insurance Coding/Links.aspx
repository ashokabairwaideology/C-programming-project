<%@ Page language="c#" Codebehind="Links.aspx.cs" AutoEventWireup="false" Inherits="VIP.Links" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Links</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body bgColor=#ccccff >
		<form id="Form1" method="post" runat="server">
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:HyperLink id="HyperLink1" runat="server" Font-Bold="True" BackColor="Transparent" BorderColor="Transparent"
					NavigateUrl="InitiateClaim.aspx" Target="f2">ClaimForm</asp:HyperLink></P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:HyperLink id="HyperLink4" runat="server" Target="f2" NavigateUrl="ClaimReport1.aspx" Font-Bold="True">View Claims</asp:HyperLink></P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:HyperLink id="HyperLink6" runat="server" Target="f2" NavigateUrl="Policies.aspx" Font-Bold="True">ViewPolicies</asp:HyperLink></P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:HyperLink id="HyperLink2" runat="server" Font-Bold="True" NavigateUrl="NewPolicy.aspx" Target="f2">NewInsuanceForm</asp:HyperLink></P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:HyperLink id="HyperLink3" runat="server" Font-Bold="True" NavigateUrl="InsuarnaceRenewal.aspx"
					Target="f2">InsuranceRenewalForm</asp:HyperLink></P>
			<P>&nbsp;</P>
			<P>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<asp:HyperLink id="HyperLink5" runat="server" Target="_parent" NavigateUrl="Logout.aspx" Font-Bold="True">LogOut</asp:HyperLink>
			</P>
		</form>
	</body>
</HTML>
