<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="Advertisement_Details.aspx.cs" Inherits="Employees_Advertisement_Details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="Addcode" DataNavigateUrlFormatString="~/Employees/ESEditt.aspx?id={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="Addcode" DataNavigateUrlFormatString="~/ESDelete.aspx?id={0} "/>
        </Columns>
    </asp:GridView>
</asp:Content>

