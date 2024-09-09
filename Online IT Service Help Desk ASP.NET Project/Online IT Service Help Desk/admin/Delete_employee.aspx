<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Delete_employee.aspx.cs" Inherits="admin_Delete_employee" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style12
        {
            width: 100%;
            height: 117px;
        }
        .style13
        {
        }
        .style14
        {
            height: 22px;
        }
        .style15
        {
            height: 22px;
        }
        .style16
        {
            height: 22px;
            width: 516px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style12">
        <tr>
            <td align="center" colspan="2" 
                style="text-decoration: blink; font-family: Rockwell; font-size: x-large; color: #FFFFFF;" 
                valign="middle">
                DELETE EMPLOYEE</td>
        </tr>
        <tr>
            <td class="style16" align="center" style="color: #FF0000">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                ID (or) Name</td>
            <td class="style14">
                <asp:TextBox ID="dl_emp" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td class="style14">
                <asp:Button ID="dl_srch" runat="server" Text="search" onclick="dl_srch_Click" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style15" colspan="2">
                <asp:Label ID="lbl_delet" runat="server" Visible="False"></asp:Label>
                </td>
        </tr>
        <tr>
            <td align="center" class="style14" colspan="2">
                <asp:GridView ID="gv_delet" runat="server" Visible="False">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="emp_id" HeaderText="Action" DataNavigateUrlFormatString="~/admin/Delete_emp2.aspx?empid={0}" Text="Delete" />
                    </Columns>
                </asp:GridView>
               </td>
        </tr>
        <tr>
            <td class="style13" colspan="2">
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

