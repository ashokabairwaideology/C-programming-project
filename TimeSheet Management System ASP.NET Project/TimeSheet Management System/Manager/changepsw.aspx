<%@ Page Language="C#" MasterPageFile="~/Manager/Mastermanager.master" AutoEventWireup="true" CodeFile="changepsw.aspx.cs" Inherits="Manager_changepsw" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label6" runat="server" Text="Change Your Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Old Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_oldpsw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <asp:Label ID="Label5" runat="server" Text="New Password:"></asp:Label>
            </td>
            <td class="style5">
                <asp:TextBox ID="txt_newpsw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Coform Password</td>
            <td>
                <asp:TextBox ID="txt_confrm" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" style="position:absolute; top: 305px; left: 198px;" 
                    runat="server" Text="Change" onclick="Button1_Click" />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

