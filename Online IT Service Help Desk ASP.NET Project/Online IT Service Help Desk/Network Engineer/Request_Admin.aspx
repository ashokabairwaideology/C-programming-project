<%@ Page Language="C#" MasterPageFile="~/Network Engineer/Network engineer.master" AutoEventWireup="true" CodeFile="Request_Admin.aspx.cs" Inherits="Network_Engineer_Request_Admin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style22
    {
        height: 248px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style22">
        <tr>
            <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td align="center" colspan="2" 
                            style="font-size: large; text-decoration: blink; font-family: Rockwell; color: #CC33FF">
                            Request To Admin</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" 
                            style="font-size: large; text-decoration: blink; font-family: Rockwell; color: #CC33FF">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" 
                            style="color: #000000; font-family: 'Times New Roman', Times, serif;">
                            Employee I.D</td>
                        <td>
                            <asp:TextBox ID="txt_id" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" 
                            style="color: #000000; font-family: 'Times New Roman', Times, serif;">
                            Subject</td>
                        <td>
                            <asp:TextBox ID="txt_sbjct" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" 
                            style="color: #000000; font-family: 'Times New Roman', Times, serif;">
                            Request Description</td>
                        <td>
                            <asp:TextBox ID="txt_dscrptn" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                Text="Send Request" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="lbl_rqst" runat="server" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                </table>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

