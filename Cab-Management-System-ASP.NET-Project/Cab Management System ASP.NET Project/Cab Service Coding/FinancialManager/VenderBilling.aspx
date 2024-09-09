<%@ Page Language="C#" MasterPageFile="~/FinancialManager/FinacialManager.master" AutoEventWireup="true" CodeFile="VenderBilling.aspx.cs" Inherits="FinancialManager_VenderBilling" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 69%;
        }
        .style4
        {
            width: 361px;
        }
        .style5
        {
            width: 143px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style3">
        <tr>
            <td align="center" colspan="3">
                Cost Estimation For Vendor</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label1" runat="server" Text="VendorId"></asp:Label>
            </td>
            <td class="style5">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Show" onclick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label2" runat="server" Text="NetAmount"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

