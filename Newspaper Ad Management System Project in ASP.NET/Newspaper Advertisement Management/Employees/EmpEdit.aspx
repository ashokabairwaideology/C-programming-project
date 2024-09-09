<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="EmpEdit.aspx.cs" Inherits="Employees_EmpEdit" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            width: 76%;
        }
        .style11
        {
            font-size: x-large;
            text-transform: uppercase;
            font-style: italic;
            font-weight: bold;
        }
        .style12
        {
            width: 220px;
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
            <td align="center" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="lbl_Adddetails" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                PageNo:</td>
            <td align="left"
                <asp:TextBox ID="txt_pno" runat="server"></asp:TextBox>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style12">
                PageLocation</td>
            <td align="left">
                <asp:TextBox ID="txt_ploc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

