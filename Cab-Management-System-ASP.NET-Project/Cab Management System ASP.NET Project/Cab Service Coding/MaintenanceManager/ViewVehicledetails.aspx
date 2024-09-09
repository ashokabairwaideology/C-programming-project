<%@ Page Language="C#" MasterPageFile="~/MaintenanceManager/Maintainance.master" AutoEventWireup="true" CodeFile="ViewVehicledetails.aspx.cs" Inherits="MaintenanceManager_ViewVehicledetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="RegNo" DataNavigateUrlFormatString="Editvehicledetails.aspx?vechid={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="RegNo" DataNavigateUrlFormatString="DeleteVehicles.aspx?vechid={0}"/>
            
            <asp:BoundField DataField="vehNo" HeaderText="vehicle number" 
                SortExpression="vehNo" />
            <asp:BoundField DataField="vehName" HeaderText="Vehicle name" 
                SortExpression="vehName" />
            <asp:BoundField DataField="vehType" HeaderText="VehicleType" 
                SortExpression="vehType" />
            <asp:BoundField DataField="RegNo" HeaderText="Registernumber" 
                SortExpression="RegNo" />
           
            <asp:BoundField DataField="Rate_per_km" HeaderText="Rate_per_km" 
                SortExpression="Rate_per_km" />
            <asp:BoundField DataField="Capacity" HeaderText="Capacity" 
                SortExpression="Capacity" />
            <asp:BoundField DataField="RouteId" HeaderText="RouteId" 
                SortExpression="RouteId" />
            <asp:BoundField DataField="Status" HeaderText="Status" 
                SortExpression="Status" />
            <asp:BoundField DataField="Daily_rent" HeaderText="Daily_rent" 
                SortExpression="Daily_rent" />
           
        </Columns>
    </asp:GridView>
</asp:Content>

