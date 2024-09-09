<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Change_Password.aspx.cs" Inherits="Admin_Change_Password" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 56%;
        }
        .style5
        {
        background-color: #CC99FF;
    }
    .style6
    {
        color: #FF3300;
    }
    .style7
    {
        text-transform: uppercase;
        font-weight: bold;
            font-style: italic;
            font-size: x-large;
        }
        .style11
        {
            width: 952px;
            height: 34px;
            font-style: normal;
            font-weight: bold;
            font-size: x-large;
            text-transform: none;
            background-color: #CC99FF;
        }
        .style12
        {
            width: 100%;
            height: 34px;
            font-style: normal;
            font-weight: bold;
            background-color: #CC99FF;
        }
        .style13
        {
            width: 952px;
            height: 28px;
            font-style: normal;
            font-weight: bold;
            font-size: x-large;
            text-transform: none;
            background-color: #CC99FF;
        }
        .style14
        {
            width: 100%;
            height: 28px;
            font-style: normal;
            font-weight: bold;
            background-color: #CC99FF;
        }
        .style15
        {
            width: 952px;
            height: 20px;
            font-style: normal;
            font-weight: bold;
            font-size: x-large;
            text-transform: none;
            background-color: #CC99FF;
        }
        .style16
        {
            width: 100%;
            height: 20px;
            font-style: normal;
            font-weight: bold;
            background-color: #CC99FF;
        }
        .style17
        {
            width: 100%;
            height: 37px;
            font-style: normal;
            font-weight: bold;
            background-color: #CC99FF;
        }
        .style18
        {
            width: 100%;
            height: 26px;
            font-style: normal;
            font-weight: bold;
            background-color: #CC99FF;
        }
        .style19
        {
            width: 100%;
            height: 61px;
            font-style: normal;
            font-weight: bold;
            background-color: #CC99FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style4" 
    style="color: #333300; height: 340px; margin-left: 105px;">
        <tr>
            <td colspan="2" class="style19">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style6"><span class="style7">Change Your Password</span></span></td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="font-size: x-large" class="style18">
                &nbsp; &nbsp;<asp:Label ID="lbl_changepwd" runat="server" Visible="False" 
                    style="color: #FFFF00"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style11">
                Old Password:&nbsp;</td>
            <td class="style12">
                <asp:TextBox ID="Txt_oldpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style13">
                New Password:</td>
            <td style="color: #000000" class="style14">
                <asp:TextBox ID="Txt_newpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style15">
                Conform Password:</td>
            <td class="style16">
                <asp:TextBox ID="Txt_Cnfrmpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td align="center" class="style17" colspan="2">
                &nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Change pwd" style="background-color: #FFFF66" />
                <asp:Button ID="Button2" runat="server" Text="Cancel" 
                    style="background-color: #FFFF66" />
            </td>
        </tr>
    </table>
</asp:Content>

