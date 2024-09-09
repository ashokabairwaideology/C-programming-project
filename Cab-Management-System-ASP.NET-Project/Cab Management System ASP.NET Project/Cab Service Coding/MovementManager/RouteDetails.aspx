<%@ Page Language="C#" MasterPageFile="~/MovementManager/MovementManager.master" AutoEventWireup="true" CodeFile="RouteDetails.aspx.cs" Inherits="MovementManager_RouteDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 75%;
        }
        .style4
        {
            width: 389px;
        }
        .style5
        {
            margin-left: 40px;
        }
    .style6
    {
        width: 292px;
        height: 197px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style6">
        <tr>
            <td align="center" colspan="2" 
                style="font-family: Algerian; font-size: x-large; font-weight: bold; font-style: normal; font-variant: normal; text-transform: none">
                RouteDettails</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label12" runat="server" Text="CityName"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label13" runat="server" Text="Destination"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label1" runat="server" Text="Distance"></asp:Label>
            </td>
            <td class="style5">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="style4">
                <asp:Label ID="Label11" runat="server" Text="RouteDiscription"></asp:Label>
            </td>
            <td class="style5">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Clear" />
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

