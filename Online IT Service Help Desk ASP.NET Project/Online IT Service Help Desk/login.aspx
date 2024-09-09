<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style4
    {
        height: 268px;
        margin-left: 18px;
            width: 350px;
            margin-top: 10px;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="style4" style="color: #FFFFFF">
        <tr>
            <td align="center" class="style7" colspan="2">
                LOGIN</td>
        </tr>
        <tr>
            <td align="center" class="style6" 
                style="font-family: 'Times New Roman', Times, serif; font-size: medium">
                USER NAME</td>
            <td>
                <asp:TextBox ID="username" runat="server" Width="167px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style6" 
                style="font-family: 'Times New Roman', Times, serif; font-size: medium">
                PASSWORD</td>
            <td>
                <asp:TextBox ID="password" runat="server" Width="165px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6" 
                style="font-family: 'Times New Roman', Times, serif; font-size: medium">
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                    PostBackUrl="~/Forgot_password.aspx" Font-Underline="False" 
                    ForeColor="#FF3300">FORGOT PASSWORD</asp:LinkButton>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="height: 26px" Text="GO" />
            </td>
        </tr>
        <tr>
            <td class="style6" 
                style="font-family: 'Times New Roman', Times, serif; font-size: medium" 
                align="center" colspan="2">
                <asp:Label ID="lbl_invalid" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        </table>
</asp:Content>

