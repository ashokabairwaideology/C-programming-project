<%@ Page Language="C#" MasterPageFile="~/MovementManager/MovementManager.master" AutoEventWireup="true" CodeFile="EditCityDetails.aspx.cs" Inherits="MovementManager_EditCityDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style4
    {
        width: 75%;
        background-color: #CCCCCC;
    }
        .style6
        {
            width: 465px;
        }
        .style7
        {
            height: 21px;
            width: 465px;
        }
    .style5
    {
        height: 21px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style4">
        <tr>
            <td colspan="2" align="center" 
            style="font-family: Algerian; font-size: x-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; color: #CC3300">
                Edit
            City Details</td>
        </tr>
        <tr>
            <td align="right" class="style6">
                <asp:Label ID="Label1" runat="server" Text="City Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style7" align="right">
                <asp:Label ID="Label2" runat="server" Text="City Cocd"></asp:Label>
            </td>
            <td class="style5">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
            &nbsp;</td>
            <td>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
            &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
            </td>
        </tr>
    </table>
</asp:Content>

