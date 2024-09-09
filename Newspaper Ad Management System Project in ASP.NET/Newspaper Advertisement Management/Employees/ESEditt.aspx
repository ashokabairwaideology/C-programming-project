<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="ESEditt.aspx.cs" Inherits="Employees_ESEditt" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            width: 70%;
        }
        .style11
        {
            font-size: x-large;
            color: #FF00FF;
            text-transform: uppercase;
            font-style: italic;
            font-weight: bold;
        }
        .style12
        {
            width: 235px;
        }
        .style13
        {
            width: 235px;
            height: 43px;
        }
        .style14
        {
            height: 43px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style10">
        <tr>
            <td align="center" colspan="2" class="style11">
                Add Details</td>
        </tr>
        <tr>
            <td align="right" class="style13">
                PageNo:</td>
            <td align="left" class="style14">
                <asp:TextBox ID="txt_pno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  align="right" class="style12">
                PageLocation</td>
            <td align="left">
                <asp:TextBox ID="txt_ploc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                Cost_SC_block &amp; white:</td>
            <td align="left">
                <asp:TextBox ID="txt_bw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                Cost_SC_Colour</td>
            <td>
                <asp:TextBox ID="txt_colour" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                Description</td>
            <td align="left">
                <asp:TextBox ID="txt_desc" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="update" />
            </td>
            <td>
                &nbsp;
                <asp:Button ID="Button2" runat="server" Text="Reset" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

