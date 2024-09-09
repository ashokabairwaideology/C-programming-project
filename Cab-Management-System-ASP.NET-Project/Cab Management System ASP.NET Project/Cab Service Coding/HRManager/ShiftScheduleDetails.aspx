<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="ShiftScheduleDetails.aspx.cs" Inherits="HRManager_ShiftScheduleDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" Width="406px">
        <Columns>
            <asp:HyperLinkField HeaderText="Action" Text="Edit" />
            <asp:HyperLinkField HeaderText="Action" Text="Delete" />
            <asp:BoundField DataField="Databound" HeaderText="Shift Schedule id" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="EmpId" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Departement" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Batch id" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Emp Name" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="ShiftId" 
                SortExpression="Databound" />
            <asp:BoundField DataField="Databound" HeaderText="Route id" 
                SortExpression="Databound" />
        </Columns>
    </asp:GridView>
</asp:Content>

