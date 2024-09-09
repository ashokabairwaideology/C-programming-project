<%@ Page Language="C#" MasterPageFile="~/MasterPageuser.master" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="changepassword" Title="Untitled Page" %>
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
    <table style="z-index: 102; left: 252px; width: 380px; position: absolute; top: 299px;
        height: 122px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Enter Your Username" Font-Bold="True" Width="152px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="Enter Your Current Password" Font-Bold="True" Width="204px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtCurrentpassword" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtCurrentpassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Text="Enter Your New Password" Font-Bold="True" Width="180px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtNewpassword" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="txtNewpassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Button ID="btnSubmit" runat="server" Text="Button" BackColor="#C0C0FF" Font-Bold="True" OnClick="btnSubmit_Click" Width="81px" />
            </td>
            <td style="width: 100px">
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
</asp:Content>

