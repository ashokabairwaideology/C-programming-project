<%@ Page Language="C#" MasterPageFile="~/Network Engineer/Network engineer.master" AutoEventWireup="true" CodeFile="Udate_profile.aspx.cs" Inherits="Network_Engineer_Udate_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 71%;
            margin-left: 73px;
            margin-top: 4px;
        margin-right: 52px;
    }
        .style19
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style18">
                    <tr>
                        <td class="style19" align="center" colspan="3" 
                            style="font-family: Rockwell; text-decoration: blink; font-size: x-large; color: #FF3399">
                            Update Profile</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td colspan="2">
                                        &nbsp;</td>
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
                        <td colspan="2">
                                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style19">
                            &nbsp;</td>
                        <td>
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

