<%@ Page Language="C#" MasterPageFile="~/Emp/emp.master" AutoEventWireup="true" CodeFile="empchange.aspx.cs" Inherits="Emp_empchange" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
        <td>
            <asp:Label ID="Label5" runat="server" Text="New Password:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_newpsw" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Conform Password:</td>
        <td>
            <asp:TextBox ID="txt_conform" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="Button1" style="position:absolute; top: 375px; left: 372px;" 
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

