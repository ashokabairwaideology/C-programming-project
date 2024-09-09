<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="adminmodule.aspx.cs" Inherits="adminmodule" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Menu ID="Menu1" runat="server" style="z-index: 100; left: 11px; position: absolute; top: 221px" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Bold="True" Font-Names="Arial Narrow" Font-Size="0.9em" ForeColor="Black" Height="401px" StaticSubMenuIndent="10px" Width="176px">
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
        <DynamicMenuStyle BackColor="#F7F6F3" />
        <StaticSelectedStyle BackColor="#5D7B9D" />
        <DynamicSelectedStyle BackColor="#5D7B9D" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <Items>
            <asp:MenuItem Text="Customer Details List" Value="Customer Details List" NavigateUrl="~/customerdetailslist.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Conformation details" Value="Conformation Mail" NavigateUrl="~/conformationdetails.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Customer Cancel Request List" Value="Customer Cancel Request List" NavigateUrl="~/cancelrequestlist.aspx">
            </asp:MenuItem>
            <asp:MenuItem Text="Customer Status Report" Value="Customer Status Report" NavigateUrl="~/statusreport.aspx"></asp:MenuItem>
            <asp:MenuItem Text="Feedbacks List" Value="Feedbacks List" NavigateUrl="~/feedbackslist.aspx"></asp:MenuItem>
        </Items>
        <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
    </asp:Menu>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

