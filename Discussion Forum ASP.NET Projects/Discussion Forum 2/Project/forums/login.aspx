<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style>
     .header {
     background-color:#dddddd;
     font:700 14pt arial;
     color:red;
     text-align:center;
     }
     .logindiv {
       position:absolute;
       top:150px;
       left:200px;
       width:400px;
       height:200px;  
       background-color:white;
       text-align:center;
       border-right: black solid;
       border-top: black solid;
       border-left: black solid;
       border-bottom: black solid;
     }
     .title {
       font:700 30pt arial;
       color:white;
       background-color:red;
       text-align:center;
       letter-spacing:10pt;
     }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="title">Discussion Forums</div>
    <p></p>
    <div style="text-align:center">
      <a href="http://www.discoutasp.net" target="_blank"> <img  src="images/discountaspnet.gif" /> </a> &nbsp;&nbsp;
      <a href="http://www.aspnetinsider.com" target="_blank"> <img src="images/aspinsiderssmall.gif" /></a>
    </div>
    <div class="logindiv"> 
      <div class="header">Login</div>
      <p />
      <table>
       <tr>
       <td align="right"> Email Address : </td>
       <td>
           <asp:TextBox ID="txtEmail" runat="server" Width="150px"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail"
               Display="Dynamic" ErrorMessage="Email address is required!">*</asp:RequiredFieldValidator></td>
       </tr>
       <tr>
       <td align="right">Password: </td>
       <td>
           <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
               Display="Dynamic" ErrorMessage="Password is required!">*</asp:RequiredFieldValidator></td>
       </tr>
      </table>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="96px" />
        <br />
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#CC0066"></asp:Label><br />
        <br />
        <a href="all/forgotpassword.aspx">I Forgot My Password!</a>  &nbsp;
        <a href="all/register.aspx">Register As New User!</a>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
    </div>
   </form>
</body>
</html>
