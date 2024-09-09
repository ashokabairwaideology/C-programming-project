<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ViewProfile.aspx.cs" Inherits="Admin_ViewProfile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        height: 37px;
    }
        .style19
        {
            width: 406px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="background-color: #E9B8F5; width: 62%;">
    <tr>
        <td class="style5" 
            style="background-image: url('../../Images/stock-photo-question-mark-made-by-font-face-50827306.jpg'); background-color: #FAC5EF;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" 
                style="font-size: xx-large; font-weight: 700; font-style: italic; font-family: Consolas; color: #BC4BE7;" 
                Text="VIEW PROFILE"></asp:Label>
            <br />
    <table class="style1" __designer:mapid="f" style="width: 100%">
        <tr>
            <td class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
                :</td>
            <td>
                <asp:Label ID="lbl_name" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Text="Username:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbl_uname" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="Email Id:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbl_emailid" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="Date Of Birth"></asp:Label>
                :</td>
            <td>
                <asp:Label ID="lbl_dob" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label12" runat="server" Text="Phone No:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbl_ph" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
        </td>
    </tr>
    </table>
</asp:Content>

