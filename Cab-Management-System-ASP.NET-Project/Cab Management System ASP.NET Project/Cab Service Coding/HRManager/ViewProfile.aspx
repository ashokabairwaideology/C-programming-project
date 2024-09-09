<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="ViewProfile.aspx.cs" Inherits="HRManager_ViewProfile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 252px;
        }
        .style4
        {
            height: 19px;
        }
        .style5
        {
            width: 252px;
            height: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" bgcolor="White" cellpadding="0" cellspacing="0" 
        width="75%">
        <tr>
            <td align="center" colspan="2" 
                style="font-family: 'Old English Text MT'; font-size: x-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; color: #000000;">
                <asp:Label ID="Label2" runat="server" Text="View Profile"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style18">
                <asp:Label ID="Label3" runat="server" Text="Manager Name"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style32">
                <asp:Label ID="Label5" runat="server" Text="Qualification"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style24">
                <asp:Label ID="Label6" runat="server" Text="D.O.B"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style22">
                <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style20">
                <asp:Label ID="Label8" runat="server" Text="Ph.no."></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style18">
                <asp:Label ID="Label9" runat="server" Text="Email ID"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style4">
                <asp:Label ID="Label13" runat="server" Text="Age"></asp:Label>
            </td>
            <td class="style5">
                <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style28">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td class="style3">
                <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="style4">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" class="style4">
                </td>
        </tr>
    </table>
</asp:Content>

