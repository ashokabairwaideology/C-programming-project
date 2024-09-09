<%@ Page Language="C#" MasterPageFile="~/Network Manager/Network_manager.master" AutoEventWireup="true" CodeFile="Update_profile.aspx.cs" Inherits="Network_Manager_Update_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 74%;
        }
        .style19
        {
            width: 201px;
        }
        .style20
        {
            width: 116px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style18">
                    <tr>
                        <td align="center" colspan="3" 
                            
                            style="color: #FF0000; font-family: Rockwell; font-size: x-large; text-decoration: blink">
                            Update Profile</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            EMPLOYEE ID</td>
                        <td colspan="2">
                                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            FIRST NAME</td>
                        <td colspan="2">
                                        <asp:TextBox ID="E_FNAME" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            LASTNAME</td>
                        <td colspan="2">
                                        <asp:TextBox ID="E_LNAME" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            EMAIL ID</td>
                        <td colspan="2">
                                        <asp:TextBox ID="EMAIL" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            ADDRESS FOR CORRESPONDENCE</td>
                        <td colspan="2">
                                        <asp:TextBox ID="ADDRS" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            MOBILE NUMBER</td>
                        <td colspan="2">
                                        <asp:TextBox ID="MOBILE" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            CITY</td>
                        <td colspan="2">
                                        <asp:TextBox ID="CITY" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            STATE</td>
                        <td colspan="2">
                                        <asp:TextBox ID="STATE" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            ZIP</td>
                        <td colspan="2">
                                        <asp:TextBox ID="ZIP" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            DATE OF BIRTH</td>
                        <td colspan="2">
                                        <asp:TextBox ID="DOB" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td class="style20">
                                        <asp:Button ID="Button1" runat="server"  Text="UPDATE" 
                                onclick="Button1_Click" />
                                    </td>
                        <td>
                                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td colspan="2">
                                        <asp:Label ID="lbl_updte" runat="server" Visible="False"></asp:Label>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td colspan="2">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

