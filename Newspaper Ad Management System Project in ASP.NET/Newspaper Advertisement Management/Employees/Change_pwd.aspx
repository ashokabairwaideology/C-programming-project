<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="Change_pwd.aspx.cs" Inherits="Employees_Change_pwd" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            font-size: x-large;
            color: #000000;
            font-style: italic;
            font-weight: bold;
        }
        .style11
        {
            color: #FF00FF;
            font-style: italic;
            font-weight: bold;
        }
        .style12
        {
            font-size: x-large;
            color: #FF00FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style4" 
        style="color: #333300; background-color: #FFFFFF; width: 483px;">
        <tr>
            <td colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span 
                    class="style12">&nbsp;&nbsp; 
                Change Your Password</span><br />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="font-size: x-large">
                &nbsp;<span class="style11"> &nbsp;<i><b><asp:Label ID="lbl_changepwd" runat="server" Visible="False"></asp:Label>
                </b></i></span>
            </td>
        </tr>
        <tr>
            <td align="right" class="style10">
                Old Password:&nbsp;</td>
            <td>
                <asp:TextBox ID="Txt_oldpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style10">
                New Password:</td>
            <td style="color: #000000">
                <asp:TextBox ID="Txt_newpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style10">
                Conform Password:</td>
            <td>
                <asp:TextBox ID="Txt_Cnfrmpwd" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style5" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Change pwd" style="background-color: #FFFFFF" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>

