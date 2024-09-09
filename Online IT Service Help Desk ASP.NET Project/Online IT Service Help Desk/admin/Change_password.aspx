<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Change_password.aspx.cs" Inherits="admin_Change_password" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
            width: 100%;
        }
        .style18
        {
            width: 367px;
        }
        .style22
        {
            width: 172px;
        }
        .style20
        {
            width: 61px;
        }
        .style21
        {
            width: 72px;
        }
        .style19
        {
            width: 6px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style14">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style18">
                    <tr>
                        <td align="center" class="style24" colspan="5" 
                            style="font-family: Rockwell; text-decoration: blink; font-size: x-large; font-style: inherit; color: #FF0000;">
                            Change Password</td>
                    </tr>
                    <tr>
                        <td align="center" class="style24" colspan="5" 
                            style="font-family: Rockwell; text-decoration: blink; font-size: x-large; font-style: inherit; color: #FF0000;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" class="style22">
                            Old Password</td>
                        <td colspan="4">
                            <asp:TextBox ID="old_pswrd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style22">
                            New Password</td>
                        <td colspan="4">
                            <asp:TextBox ID="new_pswrd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style22">
                            Confirm Password</td>
                        <td colspan="4">
                            <asp:TextBox ID="confirm_pswrd" runat="server" 
                                 TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="new_pswrd" ControlToValidate="confirm_pswrd" 
                                ErrorMessage="Passwords Doesnot Match" ValidationGroup="CMPRE">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style22">
                        </td>
                        <td class="style23" colspan="4">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                ShowMessageBox="True" ShowSummary="False" ValidationGroup="CMPRE" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style20">
                            <asp:Button ID="chng_pswrd" runat="server" 
                                Text="Update" ValidationGroup="CMPRE" Width="73px" />
                        </td>
                        <td class="style21">
                            &nbsp;</td>
                        <td class="style19">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style22">
                            &nbsp;</td>
                        <td class="style20" colspan="4">
                            <asp:Label ID="Lbl_pswrd" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

