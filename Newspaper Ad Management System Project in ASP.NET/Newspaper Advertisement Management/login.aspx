<%@ Page Language="C#" MasterPageFile="~/NewsPaper.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style3
        {
            width: 50%;
        }
        .style4
        {
        }
        .style5
        {
            height: 22px;
        }
        .style6
        {
            width: 242px;
        }
        .style7
        {
            height: 22px;
            width: 242px;
        }
        .style10
        {
            height: 141px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style2">
        <tr>
            <td>
                <table align="center" cellpadding="0" class="style3">
                    <tr>
                        <td align="center">
                            Login</td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>--Select--</asp:ListItem>
                                <asp:ListItem>Admin</asp:ListItem>
                                <asp:ListItem>Employee</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Panel ID="pnl_login" runat="server" Visible="False" Height="408px" 
                                Width="476px">
                                <table cellpadding="0" cellspacing="0" class="style2" 
                                    style="font-size: x-large">
                                    <tr>
                                        <td align="right" class="style6">
                                            User name:</td>
                                        <td align="left">
                                            <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" class="style7">
                                            Password:</td>
                                        <td align="left" class="style5">
                                            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style10" colspan="2">
                                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" Text="login" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style4" colspan="2">
                                            <asp:LinkButton ID="LinkButton5" runat="server">Forget Password?</asp:LinkButton>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

