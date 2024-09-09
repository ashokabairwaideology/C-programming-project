<%@ Page Language="C#" MasterPageFile="~/MovementManager/MovementManager.master" AutoEventWireup="true" CodeFile="ViewCityDetails.aspx.cs" Inherits="MovementManager_ViewCityDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4">
        <RowStyle BackColor="White" ForeColor="#330099" />
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="cityId" DataNavigateUrlFormatString="EditCityDetails.aspx?cityId={0}"/>
             <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="cityId" DataNavigateUrlFormatString="DeleteCitydetails.aspx?cityId={0}"/>
            <asp:BoundField DataField="cityname" HeaderText="cityname" 
                SortExpression="cityname" />
            <asp:BoundField DataField="code" HeaderText="Citycode" SortExpression="code" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    </asp:GridView>
</asp:Content>

