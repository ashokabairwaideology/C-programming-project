<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Report based on Advt Reg date.aspx.cs" Inherits="Admin_Report_based_on_Advt_Reg_date" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 70%;
            border: 1px solid #FFFFFF;
        }
        .style5
        {
        }
        .style6
        {
            color: #FF3300;
            background-color: #CC99FF;
        }
        .style7
        {
            width: 740px;
            height: 39px;
            font-style: normal;
            font-weight: bold;
        }
        .style8
        {
            height: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style4">
        <tr>
            <td align="center" colspan="2" class="style6">
                Advt&nbsp; Registration Date</td>
        </tr>
        <tr>
            <td align="right" class="style7" style="color: #000000">
                Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td align="left" class="style8">
                <asp:TextBox ID="txt_date" runat="server" Height="34px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style5" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
            </td>
        </tr>
        <tr>
            <td class="style5" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView1" runat="server" style="color: #000000">
                </asp:GridView>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
