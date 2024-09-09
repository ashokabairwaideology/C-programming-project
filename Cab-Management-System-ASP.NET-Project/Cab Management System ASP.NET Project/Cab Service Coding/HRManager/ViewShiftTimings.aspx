<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="ViewShiftTimings.aspx.cs" Inherits="HRManager_ViewShiftTimings" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" DataNavigateUrlFields="Sid" DataNavigateUrlFormatString="Edit_shifttimeings.aspx?Shiftid={0}" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="Sid" DataNavigateUrlFormatString="Delete_shifttimeings.aspx?Shiftid={0}" />
            <asp:BoundField DataField="Shiftid" HeaderText="Shift id" 
                  />
            <asp:BoundField DataField="ShiftName" HeaderText="ShiftName" 
                  />
            <asp:BoundField DataField="StartingTIme" HeaderText="StartingTime" 
                  />
            <asp:BoundField DataField="DispatchTime" HeaderText="DispatchTime" 
                  />
            <asp:BoundField DataField="NoBatchs" HeaderText="NoOfBatchs" 
                  />
        </Columns>
    </asp:GridView>
</asp:Content>

