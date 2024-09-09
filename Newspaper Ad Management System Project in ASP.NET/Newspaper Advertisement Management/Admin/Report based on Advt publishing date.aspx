<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Report based on Advt publishing date.aspx.cs" Inherits="Admin_Report_based_on_Advt_publishing_date" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 58%;
            height: 476px;
        }
        .style5
        {
            height: 27px;
        }
        .style6
        {            background-color: #CC99FF;
        }
        .style7
        {
            height: 26px;
            background-color: #CC99FF;
        }
        .style8
        {
            height: 74px;
            width: 100%;
            font-style: normal;
            font-weight: bold;
            color: #FF3300;
            background-color: #CC99FF;
        }
        .style9
        {
            background-color: #CC99FF;
        }
        .style10
        {
            font-size: x-large;
            text-transform: none;
            background-color: #CC99FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style4">
        <tr>
            <td align="center" colspan="2" class="style8">
                Advt Publishing Date</td>
        </tr>
        <tr>
            <td align="right" style="color: #000000" class="style10">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                Date:</td>
            <td align="left" class="style9">
                <asp:TextBox ID="txt_date" runat="server" Height="44px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td align="center" class="style7" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="sumit" onclick="Button1_Click" 
                    style="color: #000000; background-color: #FFCC00" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style6" colspan="2">
                <asp:GridView ID="GridView1" runat="server" 
                    style="color: #000000; background-color: #FFFF99;">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

