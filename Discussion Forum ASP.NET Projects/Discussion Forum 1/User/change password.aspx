<%@ Page Language="C#" MasterPageFile="~/User/userMasterPage.master" AutoEventWireup="true" CodeFile="change password.aspx.cs" Inherits="User_change_password" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
        {
            width: 100%;
        height: 206px;
    }
        .style5
    {
        height: 19px;
    }
        .style17
        {
        width: 241px;
        height: 33px;
    }
        .style17
    {
        height: 35px;
    }
        .style18
        {
            width: 737px;
        }
    .style18
    {
        height: 34px;
    }
    .style26
    {
        width: 282px;
        height: 30px;
    }
    .style27
    {
        height: 30px;
    }
    .style28
    {
        width: 597px;
        height: 33px;
    }
    .style29
    {
        width: 597px;
    }
    .style30
    {
        width: 597px;
        height: 30px;
    }
        .style31
        {
            width: 597px;
            height: 37px;
        }
        .style32
        {
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td class="style5" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" 
                    style="font-size: xx-large; font-weight: 700; font-style: italic" 
                    Text="Change Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style28">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="Old Password" 
                    style="font-weight: 700"></asp:Label>
                :</td>
            <td class="style17">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style29">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="New Password" 
                    style="font-weight: 700"></asp:Label>
                :</td>
            <td class="style18">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style31">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                    ID="Label5" runat="server" Text="Conform Password" style="font-weight: 700"></asp:Label>
                :</td>
            <td class="style32">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style30">
                &nbsp;</td>
            <td class="style27">
                <asp:Button ID="Button1" runat="server" Height="30px" onclick="Button1_Click" 
                    Text="SUBMIT" Width="112px" style="font-size: x-large" />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server"></asp:Label>
            </td>
        </tr>
        </table>
    <br />
</p>
<p>
</p>
</asp:Content>

