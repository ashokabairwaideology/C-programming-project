<%@ Page Language="C#" MasterPageFile="~/User/userMasterPage.master" AutoEventWireup="true" CodeFile="ViewProfile.aspx.cs" Inherits="User_ViewProfile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style3
    {
        height: 519px;
        margin-bottom: 0px;
    }
    .style30
    {
        height: 32px;
            width: 595px;
        }
    .style28
    {
            height: 33px;
            width: 118px;
        }
    .style29
    {
            height: 33px;
            width: 595px;
        }
    .style31
    {
            height: 29px;
            width: 118px;
        }
    .style32
    {
            height: 29px;
            width: 595px;
        }
    .style33
    {
            height: 34px;
            width: 118px;
        }
    .style34
    {
            height: 30px;
            width: 118px;
        }
    .style35
    {
            height: 30px;
            width: 595px;
        }
    .style36
    {
            height: 31px;
            width: 118px;
        }
    .style37
    {
            height: 31px;
            width: 595px;
        }
    .style40
    {
        height: 25px;
        width: 118px;
    }
    .style41
    {
        height: 25px;
            width: 595px;
        }
    .style44
    {
        height: 26px;
        width: 118px;
    }
    .style45
    {
        height: 26px;
            width: 595px;
        }
    .style46
    {
            height: 20px;
            width: 118px;
        }
    .style47
    {
            height: 20px;
            width: 595px;
        }
    .style48
    {
        width: 118px;
    }
        .style49
        {
            height: 34px;
            width: 595px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style3" >
    <tr>
        <td class="style31">
            <asp:Label ID="Label2" runat="server" Text="FirstName"></asp:Label>
            :</td>
        <td class="style32">
            <asp:Label ID="lbl_Fname" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style48">
            <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
            :</td>
        <td class="style30">
            <asp:Label ID="lbl_Lname" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style28">
            <asp:Label ID="Label4" runat="server" Text="UserName"></asp:Label>
            :</td>
        <td class="style29">
            <asp:Label ID="lbl_Uname" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style28">
            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            :</td>
        <td class="style29">
            <asp:Label ID="lbl_pwd" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style31">
            <asp:Label ID="Label6" runat="server" Text="ConPassword"></asp:Label>
        </td>
        <td class="style32">
            <asp:Label ID="lbl_cpwd" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style33">
            <asp:Label ID="Label7" runat="server" Text="EmailID"></asp:Label>
            :</td>
        <td class="style49">
            <asp:Label ID="lbl_email" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style34">
            <asp:Label ID="Label8" runat="server" Text="AltEmailId"></asp:Label>
            :</td>
        <td class="style35">
            <asp:Label ID="lbl_altemail" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style36">
            <asp:Label ID="Label9" runat="server" Text="Gender"></asp:Label>
            :</td>
        <td class="style37">
            <asp:Label ID="lbl_gender" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style34">
            <asp:Label ID="Label10" runat="server" Text="Martstatus"></asp:Label>
            :</td>
        <td class="style35">
            <asp:Label ID="lbl_marsts" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style33">
            <asp:Label ID="Label11" runat="server" Text="DOB"></asp:Label>
            :</td>
        <td class="style49">
            <asp:Label ID="lbl_dob" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style33">
            <asp:Label ID="Label12" runat="server" Text="PhoneNo"></asp:Label>
            :</td>
        <td class="style49">
            <asp:Label ID="lbl_phno" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style40">
                HintQuestion:</td>
        <td class="style41">
            <asp:Label ID="lbl_hintq" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style36">
            <asp:Label ID="Label14" runat="server" Text="HintAnswer"></asp:Label>
            :</td>
        <td class="style37">
            <asp:Label ID="lbl_hinta" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style44">
            <asp:Label ID="Label15" runat="server" Text="City"></asp:Label>
            :</td>
        <td class="style45">
            <asp:Label ID="lbl_city" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style46">
            <asp:Label ID="Label16" runat="server" Text="State"></asp:Label>
            :</td>
        <td class="style47">
            <asp:Label ID="lbl_state" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style46">
            &nbsp;</td>
        <td class="style47">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

