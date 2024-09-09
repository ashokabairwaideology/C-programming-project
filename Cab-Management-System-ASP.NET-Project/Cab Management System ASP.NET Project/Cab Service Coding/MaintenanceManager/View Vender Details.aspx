<%@ Page Language="C#" MasterPageFile="~/MaintenanceManager/Maintainance.master" AutoEventWireup="true" CodeFile="View Vender Details.aspx.cs" Inherits="MaintenanceManager_View_Vender_Details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        >
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="vid" DataNavigateUrlFormatString="edit vender.aspx?venid={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="DELETE" DataNavigateUrlFields="vid" DataNavigateUrlFormatString="Delete Vender Details.aspx?venid={0}" />
            <asp:BoundField DataField="venderId" HeaderText="Vender ID" 
                SortExpression="venderId" />
            <asp:BoundField DataField="venderName" HeaderText="venderId" 
                SortExpression="venderName" />
            <asp:BoundField DataField="Address" HeaderText="VendeAddress" 
                SortExpression="Address" />
            <asp:BoundField DataField="PhoneNo" HeaderText="Phone No" 
                SortExpression="PhoneNo" />
            <asp:BoundField DataField="Email" HeaderText="Email ID	" 
                SortExpression="Email" />
            <asp:BoundField DataField="Remarks" HeaderText="Remarks	" 
                SortExpression="Remarks" />
        </Columns>
    </asp:GridView>
</asp:Content>

