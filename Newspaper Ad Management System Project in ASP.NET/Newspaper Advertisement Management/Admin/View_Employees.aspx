<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="View_Employees.aspx.cs" Inherits="Admin_View_Employees" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

    <asp:GridView ID="GridView1" runat="server" ForeColor="Black">
        <Columns>
        <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="Empid" DataNavigateUrlFormatString="ASDelete.aspx?Empid={0}" />
        </Columns>
    </asp:GridView>

</asp:Content>



