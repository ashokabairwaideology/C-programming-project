<%@ Page Language="C#" MasterPageFile="~/MasterPageuser.master" AutoEventWireup="true" CodeFile="cancel.aspx.cs" Inherits="cancel" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
    <br />
    <br />
    <table style="z-index: 102; left: 235px; width: 364px; position: absolute; top: 281px;
        height: 133px">
        <tr>
            <td style="width: 86px; height: 24px">
                <asp:Label ID="Label1" runat="server" Text="Customer Id" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 115px; height: 24px">
                <asp:TextBox ID="txtCustomerid" runat="server"></asp:TextBox>
            </td>
            <td style="width: 134217727px; height: 24px">
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
                <asp:Label ID="Label2" runat="server" Text="Customer Cancel Request" Font-Bold="True" Width="186px"></asp:Label>
            </td>
            <td style="width: 115px">
                <asp:TextBox ID="txtCusotmerrequest" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 134217727px">
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
                <asp:Label ID="Label3" runat="server" Text="Date" Font-Bold="True" Width="63px"></asp:Label>    
            </td>
            <td style="width: 115px">
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            </td>
            <td style="width: 134217727px">
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
            <asp:Button ID="btnSend" runat="server" Text="Send" BackColor="#C0C0FF" Font-Bold="True" Width="84px" OnClick="btnSend_Click" />
            </td>
            <td style="width: 115px">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            
            </td>
            <td style="width: 134217727px">
            
            </td>
        </tr>
    </table>
</asp:Content>

