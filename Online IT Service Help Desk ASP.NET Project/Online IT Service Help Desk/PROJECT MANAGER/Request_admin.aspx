<%@ Page Language="C#" MasterPageFile="~/PROJECT MANAGER/Project_manager.master" AutoEventWireup="true" CodeFile="Request_admin.aspx.cs" Inherits="PROJECT_MANAGER_Request_admin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 100%;
        }
        .style19
        {
            width: 80%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
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
                        <td align="center">
                            Employee I.D</td>
                                                <td>
                                                    <asp:TextBox ID="txt_id" runat="server"  
                                                        ReadOnly="True"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    Subject</td>
                        <td>
                            <asp:TextBox ID="txt_sbjct" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
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
                            <asp:Label ID="lbl_rqst" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


