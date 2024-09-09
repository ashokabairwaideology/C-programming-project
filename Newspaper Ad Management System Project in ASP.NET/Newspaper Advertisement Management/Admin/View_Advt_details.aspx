<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="View_Advt_details.aspx.cs" Inherits="Admin_View_Advt_details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:GridView ID="GridView1" runat="server" ForeColor="Black" Width="647px">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="Addcode" DataNavigateUrlFormatString="edit_Advt_details.aspx?id={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="Addcode" DataNavigateUrlFormatString="ASDelete.aspx?id={0}" />
        </Columns>
    
    </asp:GridView>

</asp:Content>



