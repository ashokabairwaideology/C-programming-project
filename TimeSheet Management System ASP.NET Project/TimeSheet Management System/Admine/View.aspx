﻿<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="Admine_View" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table class="style27" __designer:mapid="80">
            <tr>
                <td>
                    &nbsp;First Name:</td>
                <td>
                    <asp:TextBox ID="txt_fname" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Lat Name:</td>
                <td>
                    <asp:TextBox ID="txt_lname" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Gender:</td>
                <td>
                    <asp:RadioButtonList ID="rdb_gender" runat="server" AutoPostBack="True">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    Phno:</td>
                <td>
                    <asp:TextBox ID="txt_pno" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email:</td>
                <td>
                    <asp:TextBox ID="txt_emai" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Alt Email:</td>
                <td>
                    <asp:TextBox ID="txt_atml" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Experence:</td>
                <td>
                    <asp:TextBox ID="txt_exc" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Date Of Join:</td>
                <td>
                    <asp:TextBox ID="txt_doj" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Address:</td>
                <td>
                    <asp:TextBox ID="txt_adress" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    City:</td>
                <td>
                    <asp:TextBox ID="txt_city" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    State:</td>
                <td>
                    <asp:TextBox ID="txt_state" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Country:</td>
                <td>
                    <asp:TextBox ID="txt_cuntry" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    PinCode:</td>
                <td>
                    <asp:TextBox ID="txt_pinc" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Position:</td>
                <td>
                    <asp:DropDownList ID="txt_posn" runat="server">
                        <asp:ListItem>ADMIN</asp:ListItem>
                        <asp:ListItem>MANAGER</asp:ListItem>
                        <asp:ListItem>EMPLOYEE</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Status:</td>
                <td>
                    <asp:TextBox ID="txt_status" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
<br />
</asp:Content>

