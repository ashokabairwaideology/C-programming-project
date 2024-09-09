<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="passwordrecovery.aspx.cs" Inherits="passwordrecovery" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="Image1" runat="server" style="z-index: 100; left: 12px; position: absolute; top: 223px" Height="53px" ImageUrl="~/images/3.gif" Width="868px" />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table style="z-index: 102; left: 246px; width: 445px; position: absolute; top: 338px;
        height: 103px">
        <tr>
            <td style="width: 93px">
                <asp:Label ID="Label1" runat="server" Text="User Name" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 93px; height: 25px">
                <asp:Label ID="Label2" runat="server" Text="PhoneNo" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px; height: 25px">
                <asp:TextBox ID="txtPhoneno" runat="server"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td style="width: 93px; height: 24px">
                <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#C0C0FF" Font-Bold="True" OnClick="Button1_Click" />
            </td>
            <td style="width: 100px; height: 24px">
                <asp:Label ID="lblPassword" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
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
</asp:Content>

