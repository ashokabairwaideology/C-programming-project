<%@ Page Language="C#" MasterPageFile="~/Network Manager/Network_manager.master" AutoEventWireup="true" CodeFile="View_profile.aspx.cs" Inherits="Network_Manager_View_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 234px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style13" 
        style="height: 429px; width: 485px">
        <tr>
            <td align="center" colspan="2" 
                            
                style="font-family: Algerian; font-size: xx-large; text-decoration: blink; color: #FF00FF">
                            PROFILE</td>
        </tr>
        <tr>
            <td class="style18">
                            EMPLOYEE ID</td>
            <td>
                <asp:Label ID="EID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            FIRST NAME</td>
            <td>
                <asp:Label ID="FNAME" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            LAST NAME</td>
            <td>
                <asp:Label ID="LNAME" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            EMAIL ID</td>
            <td class="style14">
                <asp:Label ID="EMAIL" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            ADDRESS</td>
            <td>
                <asp:Label ID="ADDRESS" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            MOBILE NUMBER</td>
            <td>
                <asp:Label ID="MOBILE" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            CITY</td>
            <td>
                <asp:Label ID="CITY" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            STATE</td>
            <td>
                <asp:Label ID="STATE" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            ZIP</td>
            <td>
                <asp:Label ID="ZIP" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            DATE OF BIRTH</td>
            <td>
                <asp:Label ID="DOB" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                                                    DATE OF JOINING</td>
            <td>
                <asp:Label ID="DOJ" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style18">
                            POSITION</td>
            <td>
                <asp:Label ID="POSITION" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                &nbsp;</td>
            <td align="right">
                <asp:LinkButton ID="LinkButton11" runat="server" Font-Bold="True" 
                                Font-Italic="True" Font-Underline="False" ForeColor="#FF6600" 
                                PostBackUrl="~/admin/Update_Profile.aspx">Click here to Update&gt;&gt;</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>

