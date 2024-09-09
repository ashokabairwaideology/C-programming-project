<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="Viewshiftschdule.aspx.cs" Inherits="HRManager_Viewshiftschdule" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" Height="133px" 
        AutoGenerateColumns="false" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="cityId" DataNavigateUrlFormatString="EditCityDetails.aspx?cityId={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="cityId" DataNavigateUrlFormatString="EditCityDetails.aspx?cityId={0}"/>
                        <asp:BoundField DataField="Databound" HeaderText="Empid" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Departmentid" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Batchid" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Empname" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Shiftid" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="RouteId" 
                SortExpression="Databound" />
        </Columns>
    </asp:GridView>
</asp:Content>

