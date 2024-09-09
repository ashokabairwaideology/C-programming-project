<%@ Page Language="C#" MasterPageFile="~/Network Manager/Network_manager.master" AutoEventWireup="true" CodeFile="Request_admin.aspx.cs" Inherits="Network_Manager_Request_admin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style20
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style20">
        <tr>
            <td align="center" colspan="2" 
                style="font-family: Rockwell; color: #0066FF; text-decoration: blink; font-size: large">
                            Request To Admin</tr>
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

