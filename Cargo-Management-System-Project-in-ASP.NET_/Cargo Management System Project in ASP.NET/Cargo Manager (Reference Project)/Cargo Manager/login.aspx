<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" Style="z-index: 103; left: 550px; position: absolute;
        top: 483px" ForeColor="#400000" NavigateUrl="~/register.aspx">Registration</asp:HyperLink>
    
    <asp:Image ID="Image2" runat="server" style="z-index: 101; left: 12px; position: absolute; top: 303px" Height="281px" ImageUrl="~/images/boeing_01.jpg" Width="469px" /><asp:Image ID="Image1" runat="server" style="z-index: 102; left: 10px; position: absolute; top: 246px" Height="57px" ImageUrl="~/images/3.gif" Width="874px" />
    &nbsp;
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table frame="border" style="z-index: 102; left: 517px; width: 323px; position: absolute;
        top: 387px; height: 94px">
        <tr>
            <td style="width: 146px">
                <asp:Label ID="Label1" runat="server" Text="User Name" Font-Bold="True" Width="144px"></asp:Label>
            </td>
            <td style="width: 145px">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
                <asp:Label ID="Label2" runat="server" Text="PassWord" Font-Bold="True" Width="145px"></asp:Label>
            </td>
            <td style="width: 145px">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
            </td>
            <td style="width: 145px">
                <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="False" Font-Underline="True" ForeColor="Blue" Width="131px">Forgot Password</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td style="width: 146px">
            </td>
            <td style="width: 145px">
                <asp:Button ID="btnLogin" runat="server" Text="Login" BackColor="#C0C0FF" Font-Bold="True" Width="77px" OnClick="btnLogin_Click" />
            </td>
        </tr>
        <tr>
        
        
        
        </tr>
    </table>
</asp:Content>

