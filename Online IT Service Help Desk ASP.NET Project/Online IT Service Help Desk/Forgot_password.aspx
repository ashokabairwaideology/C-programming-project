<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Forgot_password.aspx.cs" Inherits="Forgot_password" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
    {
        width: 100%;
            height: 188px;
        }
    .style9
    {
        width: 335px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style8">
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style8">
                <tr>
                    <td align="center" colspan="2">
                        Forgot Password ? ? ?</td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style9">
                        E-mail I.D</td>
                    <td>
                        <asp:TextBox ID="txt_email" runat="server" style="margin-left: 0px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="btn_smt" runat="server" onclick="btn_smt_Click" Text="Submit" />
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Label ID="lbl_psswrd" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>

