<%@ Page Language="C#" MasterPageFile="~/Team_Member/Team_member.master" AutoEventWireup="true" CodeFile="View_profile.aspx.cs" Inherits="Team_member_View_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
            width: 56%;
            height: 323px;
        }
        .style19
        {
            height: 52px;
        }
        .style21
        {
            width: 867px;
            height: 19px;
        }
        .style22
        {
            height: 19px;
        }
        .style20
        {
            width: 867px;
        }
        .style24
        {
            width: 56%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style14">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style13" 
                    style="width: 333px; margin-left: 0px">
                    <tr>
                        <td align="left" colspan="2" 
                            
                            style="font-family: Algerian; font-size: xx-large; text-decoration: blink; color: #3399FF" 
                            class="style19">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PROFILE</td>
                    </tr>
                    <tr>
                        <td class="style21">
                            EMPLOYEE ID</td>
                        <td class="style22">
                            <asp:Label ID="EID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            FIRST NAME</td>
                        <td>
                            <asp:Label ID="FNAME" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            LAST NAME</td>
                        <td>
                            <asp:Label ID="LNAME" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            EMAIL ID</td>
                        <td class="style24">
                            <asp:Label ID="EMAIL" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            ADDRESS</td>
                        <td>
                            <asp:Label ID="ADDRESS" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            MOBILE NUMBER</td>
                        <td>
                            <asp:Label ID="MOBILE" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            CITY</td>
                        <td>
                            <asp:Label ID="CITY" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            STATE</td>
                        <td>
                            <asp:Label ID="STATE" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            ZIP</td>
                        <td>
                            <asp:Label ID="ZIP" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style20">
                            DATE OF BIRTH</td>
                                                <td>
                                                    <asp:Label ID="DOB" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style20">
                                                    DATE OF JOINING</td>
                        <td>
                            <asp:Label ID="DOJ" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style21">
                            POSITION</td>
                        <td class="style22">
                            <asp:Label ID="POSITION" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style20">
                            &nbsp;</td>
                        <td align="right">
                            <asp:LinkButton ID="LinkButton11" runat="server" Font-Bold="True" 
                                Font-Italic="True" Font-Underline="False" ForeColor="#FF6600" 
                                PostBackUrl="~/admin/Update_Profile.aspx">Click here to Update&gt;&gt;</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

