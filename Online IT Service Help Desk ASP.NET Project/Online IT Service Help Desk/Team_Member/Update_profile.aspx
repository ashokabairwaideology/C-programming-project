<%@ Page Language="C#" MasterPageFile="~/Team_Member/Team_member.master" AutoEventWireup="true" CodeFile="Update_profile.aspx.cs" Inherits="Team_Member_Update_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
            width: 100%;
        }
        .style12
        {
            margin-left: 235px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style12">
        <tr>
            <td>
                <table class="style13" style="width: 429px">
                    <tr>
                        <td align="center" class="style14" colspan="3" 
                            
                            style="font-family: Rockwell; font-size: x-large; text-decoration: blink; color: #FF0000">
                            Update Profile</td>
                    </tr>
                    <tr>
                        <td class="style15">
                            EMPLOYEE ID</td>
                        <td colspan="2">
                                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            FIRST NAME</td>
                        <td colspan="2">
                                        <asp:TextBox ID="E_FNAME" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            LASTNAME</td>
                        <td colspan="2">
                                        <asp:TextBox ID="E_LNAME" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            EMAIL ID</td>
                        <td colspan="2">
                                        <asp:TextBox ID="EMAIL" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            ADDRESS FOR CORRESPONDENCE</td>
                        <td colspan="2">
                                        <asp:TextBox ID="ADDRS" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            MOBILE NUMBER</td>
                        <td colspan="2">
                                        <asp:TextBox ID="MOBILE" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            CITY</td>
                        <td colspan="2">
                                        <asp:TextBox ID="CITY" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            STATE</td>
                        <td colspan="2">
                                        <asp:TextBox ID="STATE" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            ZIP</td>
                        <td colspan="2">
                                        <asp:TextBox ID="ZIP" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            DATE OF BIRTH</td>
                        <td colspan="2">
                                        <asp:TextBox ID="DOB" runat="server"></asp:TextBox>
                                    </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td class="style16">
                                        <asp:Button ID="Button1" runat="server"  Text="UPDATE" 
                                 />
                                    </td>
                        <td>
                                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td colspan="2">
                                        <asp:Label ID="lbl_updte" runat="server" Visible="False"></asp:Label>
                                    </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

