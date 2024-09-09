<%@ Page Language="C#" MasterPageFile="~/Network Engineer/Network engineer.master" AutoEventWireup="true" CodeFile="Change_password.aspx.cs" Inherits="Network_Engineer_Change_password" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 75%;
        height: 196px;
        margin-left: 52px;
            margin-top: 9px;
        }
        .style19
        {
            width: 349px;
        }
        .style20
        {
            width: 87px;
        }
        .style21
        {
            width: 58px;
        }
        .style22
        {
            width: 349px;
            height: 57px;
        }
        .style23
        {
            height: 57px;
        }
        .style24
        {
            width: 106px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style18">
                    <tr>
                        <td align="center" colspan="5" 
                            
                            style="font-family: Rockwell; text-decoration: blink; font-size: x-large; font-style: normal; color: #FF0000;">
                &nbsp;&nbsp;&nbsp;&nbsp;
                Change Password</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="5" 
                            
                            style="font-family: Rockwell; text-decoration: blink; font-size: x-large; font-style: normal; color: #FF0000;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" class="style19">
                Old Password</td>
                        <td colspan="4">
                <asp:TextBox ID="old_pswrd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style19">
                New Password</td>
                        <td colspan="4">
                <asp:TextBox ID="new_pswrd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style19">
                Confirm Password</td>
                        <td colspan="4">
                <asp:TextBox ID="confirm_pswrd" runat="server" 
                    ontextchanged="confirm_pswrd_TextChanged" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator runat="server" ControlToCompare="new_pswrd" 
                    ControlToValidate="confirm_pswrd" ErrorMessage="Passwords Doesnot Match" 
                    ValidationGroup="CMPRE" ID="CompareValidator1">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style22">
                            </td>
                        <td colspan="4" class="style23">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                    ShowMessageBox="True" ShowSummary="False" ValidationGroup="CMPRE" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                <asp:Button ID="chng_pswrd" runat="server" Text="Update" 
                    onclick="chng_pswrd_Click1" ValidationGroup="CMPRE" Width="73px" />
                        </td>
                        <td class="style21">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style24">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                <asp:Label ID="Lbl_pswrd" runat="server" Visible="False"></asp:Label>
                        </td>
                        <td class="style21">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td class="style24">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

