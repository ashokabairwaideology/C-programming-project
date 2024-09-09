<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="BatchDetails.aspx.cs" Inherits="HRManager_BatchDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style3
    {
        width: 75%;
    }
    .style4
    {
        width: 314px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    *<table align="center" cellpadding="0" cellspacing="0" class="style3">
    <tr>
        <td align="center" bgcolor="#FF9966" colspan="2">
            <asp:Label ID="Label1" runat="server" Text="BatchDetails"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="right" class="style4">
            <asp:Label ID="Label2" runat="server" Text="Total No Of Employee"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right" class="style4">
            <asp:Label ID="Label3" runat="server" Text="ShiftId"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
</table>
</asp:Content>

