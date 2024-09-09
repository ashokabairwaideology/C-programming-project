<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="chngpsw.aspx.cs" Inherits="Admine_chngpsw" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table class="style27">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" 
                    Font-Names="Magneto" Font-Size="X-Large" ForeColor="blue" 
                    Text="Change Your Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Old password:</td>
            <td>
                <asp:TextBox ID="txt_olpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                New Password:</td>
            <td>
                <asp:TextBox ID="txt_newpsw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Conform Password:</td>
            <td>
                <asp:TextBox ID="txt_conpass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" style="position:absolute; top: 429px; left: 366px;" 
                    runat="server" Text="Change Passwod" onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            
        </tr>
    </table>

    </asp:Content>


