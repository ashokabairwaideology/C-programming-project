<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="changeprofile.aspx.cs" Inherits="changeprofile" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
        Change Profile</h2>
    <table>
        <tr>
            <td style="width: 100px">
                Fullname :
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtFullname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Occupation :
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtOccup" runat="server" Width="351px"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Photo JPG :
            </td>
            <td style="width: 100px">
                <asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnChange" runat="server" OnClick="btnChange_Click" Text="Change Profile" /><br />
    <br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label><br />
</asp:Content>

