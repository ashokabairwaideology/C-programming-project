<%@ Page Language="C#" AutoEventWireup="true" CodeFile="fogotpassword.aspx.cs" Inherits="all_fogotpassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <h2>
            Forgot Password</h2>
        Enter your email address :
        <asp:TextBox ID="txtEmail" runat="server" Width="327px"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" /><br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label></div>
    </form>
</body>
</html>
