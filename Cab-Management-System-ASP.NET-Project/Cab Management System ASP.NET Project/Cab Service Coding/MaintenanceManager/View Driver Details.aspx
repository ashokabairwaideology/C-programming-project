<%@ Page Language="C#" MasterPageFile="~/MaintenanceManager/Maintainance.master" AutoEventWireup="true" CodeFile="View Driver Details.aspx.cs" Inherits="MaintenanceManager_View_Driver_Details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:HyperLinkField HeaderText="Action"  DataNavigateUrlFields="DId" DataNavigateUrlFormatString="~/Edit driver details.aspx?DriverId={0}" Text="Edit" />
                        <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="DId" DataNavigateUrlFormatString="~/Delete.aspx?ManagerId={0}?DriverId={0}" Text="Delete" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

