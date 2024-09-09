<%@ Page Language="C#" MasterPageFile="~/MaintenanceManager/Maintainance.master" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="MaintenanceManager_UpdateProfile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 75%;
            height: 298px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style4">
    <tr>
        <td>
    <table align="center" bgcolor="White" cellpadding="0" cellspacing="0" 
        width="75%">
        <tr>
            <td align="center" colspan="2" 
                style="font-family: 'Old English Text MT'; font-size: x-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; color: #000000;">
                <asp:Label ID="Label2" runat="server" Text="Update Profile"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style18">
                <asp:Label ID="Label3" runat="server" Text="Manager Name"></asp:Label>
            </td>
            <td class="style19">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style32">
                <asp:Label ID="Label5" runat="server" Text="Qualification"></asp:Label>
            </td>
            <td class="style33">
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
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style30">
                <asp:Label ID="Label13" runat="server" Text="Age"></asp:Label>
            </td>
            <td class="style31">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style28">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="style29">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
        </td>
    </tr>
</table>
</asp:Content>

