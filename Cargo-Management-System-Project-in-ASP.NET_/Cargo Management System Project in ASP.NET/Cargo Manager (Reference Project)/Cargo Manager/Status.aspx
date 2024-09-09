<%@ Page Language="C#" MasterPageFile="~/MasterPageuser.master" AutoEventWireup="true" CodeFile="Status.aspx.cs" Inherits="Status" Title="Untitled Page" %>
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
    <table style="z-index: 102; left: 158px; position: absolute; top: 307px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Customer Id" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtCustomerid" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Can't be blank" ControlToValidate="txtCustomerid"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="Customername" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtCustomername" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
            
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            
            </td>
            <td style="width: 100px">
                <asp:Button ID="btnStatus" runat="server" Text="Status" BackColor="#C0C0FF" Font-Bold="True" Width="86px" OnClick="btnStatus_Click" />
            </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" style="z-index: 100; left: 227px; position: absolute; top: 434px" Height="240px" Width="301px">
    </asp:GridView>
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
</asp:Content>

