<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="Add_Booking.aspx.cs" Inherits="Employees_Add_Booking" Title="Untitled Page" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            width: 70%;
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
            font-style: italic;
            font-weight: bold;
            font-size: x-large;
            color: #FF00FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
ss<table align="center" cellpadding="0" cellspacing="0" class="style10">
        <tr>
            <td align="center" colspan="2" class="style11">
                <br />
                Add the Customer Profile<br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                CustomerName:</td>
            <td align="left">
                <asp:TextBox ID="txt_cname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                ContactNo:</td>
            <td align="left">
                <asp:TextBox ID="txt_cno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                Address</td>
            <td align="left">
                <asp:TextBox ID="txt_address" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Register" 
                    onclick="Button1_Click"/>
                <br />
                <asp:Label ID="lblusid" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Label ID="lbl_CPA" runat="server" 
                    style="color: #FF00FF; font-size: x-large; font-weight: 700; font-style: italic" 
                    Text="Customer profile added to Continue click the next button" 
                    Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button2" runat="server" Text="Continue" Visible="False" 
                    onclick="Button2_Click1"/>
            </td>
        </tr>
    </table>
</asp:Content>

