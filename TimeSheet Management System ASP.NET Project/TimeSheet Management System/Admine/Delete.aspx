﻿<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Admine_Delete" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label2" runat="server" Font-Size="X-Large" ForeColor="blue" 
        Text="Delete Emp Details"></asp:Label>
    <br />
    <br />
    <br />
<br />
    <table class="style27">
        <tr>
            <td>
                <br />
                <asp:Label ID="Label3" 
                    style="position:absolute; top: 332px; left: 20px; width: 113px; height: 30px;" 
                    runat="server" Text="Enter Uniqid:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" 
                    style="position:absolute; top: 327px; left: 202px;" runat="server">
                </asp:DropDownList>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" style="position:absolute; top: 329px; left: 459px; right: 558px;" 
                    runat="server" Text="View Details" onclick="Button1_Click" />
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    GridLines="Horizontal">
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:GridView>
                <asp:Button ID="Button2" style="position:absolute; top: 334px; left: 787px;" 
                    runat="server" Text="Delete" onclick="Button2_Click" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

