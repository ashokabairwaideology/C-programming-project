<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="edit_manager.aspx.cs" Inherits="Admin_edit_manager" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style18
    {
        width: 327px;
        height: 42px;
        margin-bottom: 0px;
    }
    .style19
    {
        height: 42px;
    }
    .style28
    {
        width: 327px;
        height: 45px;
        margin-bottom: 0px;
    }
    .style29
    {
        height: 45px;
    }
    .style26
    {
        width: 327px;
        height: 36px;
        margin-bottom: 0px;
    }
    .style27
    {
        height: 36px;
    }
    .style24
    {
        width: 327px;
        height: 38px;
        margin-bottom: 0px;
    }
    .style25
    {
        height: 38px;
    }
    .style22
    {
        width: 327px;
        height: 54px;
        margin-bottom: 0px;
    }
    .style23
    {
        height: 54px;
    }
    .style20
    {
        width: 327px;
        height: 34px;
        margin-bottom: 0px;
    }
    .style21
    {
        height: 34px;
    }
    .style14
    {
        width: 327px;
        height: 46px;
        margin-bottom: 0px;
    }
    .style15
    {
        height: 46px;
    }
    .style16
    {
        width: 327px;
        height: 41px;
        margin-bottom: 0px;
    }
    .style17
    {
        height: 41px;
    }
    .style12
    {
        width: 327px;
        height: 39px;
        margin-bottom: 0px;
    }
    .style13
    {
        height: 39px;
    }
    .style30
    {
        width: 327px;
        height: 37px;
        margin-bottom: 0px;
    }
    .style31
    {
        height: 37px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style1" 
            bgcolor="White">
        <tr>
            <td align="center" colspan="2" 
                    
                    style="font-family: 'Old English Text MT'; font-size: x-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; color: #000000;">
                <asp:Label ID="Label2" runat="server" Text="Manager Creation"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style18">
                <asp:Label ID="Label3" runat="server" Text="Manager Name"></asp:Label>
            </td>
            <td class="style19">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style28">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="style29">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style26">
                <asp:Label ID="Label5" runat="server" Text="Qualification"></asp:Label>
            </td>
            <td class="style27">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style24">
                <asp:Label ID="Label6" runat="server" Text="D.O.B"></asp:Label>
            </td>
            <td class="style25">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style22">
                <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
            </td>
            <td class="style23">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="52px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="center" class="style20">
                <asp:Label ID="Label8" runat="server" Text="Ph.no."></asp:Label>
            </td>
            <td class="style21">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style18">
                <asp:Label ID="Label9" runat="server" Text="Email ID"></asp:Label>
            </td>
            <td class="style19">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style14">
                <asp:Label ID="Label10" runat="server" Text="Designation"></asp:Label>
            </td>
            <td class="style15">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Manager</asp:ListItem>
                    <asp:ListItem>Maintance Manager</asp:ListItem>
                    <asp:ListItem>finance Manager</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" class="style16">
                <asp:Label ID="Label11" runat="server" Text="Department"></asp:Label>
            </td>
            <td class="style17">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>manager</asp:ListItem>
                    <asp:ListItem>finance</asp:ListItem>
                    <asp:ListItem>maintance</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="center" class="style12">
                <asp:Label ID="Label12" runat="server" Text="Date of Join"></asp:Label>
            </td>
            <td class="style13">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style30">
                <asp:Label ID="Label13" runat="server" Text="Age"></asp:Label>
            </td>
            <td class="style31">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button5" runat="server" Text="UPDATE" onclick="Button5_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

