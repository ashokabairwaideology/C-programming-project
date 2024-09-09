<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="view managers.aspx.cs" Inherits="Admin_view_managers" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="ManagerId" DataNavigateUrlFormatString="edit_manager.aspx?ManagerId={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="ManagerId" DataNavigateUrlFormatString="Delete.aspx?ManagerId={0}" />
        </Columns>
    </asp:GridView>
</asp:Content>

