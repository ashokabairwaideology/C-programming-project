<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="Admin_LoginPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 67%;
            height: 181px;
        }
        .style4
        {
            height: 12px;
        }
        .style5
        {
            height: 29px;
        }
        .style6
        {
            height: 35px;
        }
        .style7
        {
            width: 100%;
        }
        .style10
        {
            width: 157px;
            height: 169px;
        }
        .style11
        {
            width: 585px;
        }
        .style12
        {
            height: 12px;
            width: 94px;
        }
        .style13
        {
            height: 29px;
            width: 94px;
        }
        .style14
        {
            width: 94px;
        }
        .style15
        {
            height: 35px;
            width: 94px;
        }
        .style16
        {
            width: 700px;
            height: 238px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p>
            <span lang="en-us">&nbsp;&nbsp;&nbsp; </span>
            <table cellpadding="0" cellspacing="0" class="style7">
                <tr>
                    <td>
                        <span lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        </span>
                        <img alt="1" class="style16" src="Admin/Untitled-2%20copy.jpg" /></td>
                </tr>
            </table>
        </p>
    
        <table align="center" cellpadding="0" cellspacing="0" class="style1">
            <tr>
                <td rowspan="4" class="style11">
                    <span lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                    <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" 
                        codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,0,0" 
                        id="car" align="middle" class="style10">
<param name="allowScriptAccess" value="sameDomain" />
<param name="movie" value="Admin/car.swf" /><param name="quality" value="high" /><param name="bgcolor" value="#ffffff" />
                        <embed src="Admin/car.swf" quality="high" bgcolor="#ffffff" width="550" 
                            height="400" name="car" align="middle" allowScriptAccess="sameDomain" 
                            type="application/x-shockwave-flash" 
                            pluginspage="http://www.macromedia.com/go/getflashplayer" />
</object></td>
                <td class="style12">
                    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
                </td>
                <td class="style4">
                    <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="style5">
                    <asp:TextBox ID="txt_pwd" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style14">
                    </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Sign In" 
                        onclick="Button1_Click" />
                    <br />
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" 
                        PostBackUrl="~/Forget Password.aspx">Forget Password</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="style15">
                </td>
                <td class="style6">
                    <br />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
