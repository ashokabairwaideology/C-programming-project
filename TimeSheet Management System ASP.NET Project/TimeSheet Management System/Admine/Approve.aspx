<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="Approve.aspx.cs" Inherits="Admine_Approve" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" GridLines="Horizontal" Font-Size="Large">
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <Columns>
            <asp:HyperLinkField HeaderText="Approve" DataNavigateUrlFields="timesheetid" DataNavigateUrlFormatString="~/Admine/Approve_Action.aspx?relid={0}" Text="Approve" />
            <asp:HyperLinkField HeaderText="Reject" DataNavigateUrlFields="timesheetid" DataNavigateUrlFormatString="~/Admine/Approve_Action.aspx?relid={0}" Text="Reject" />
       <asp:BoundField DataField="timesheetid" HeaderText="ID" />
       <asp:BoundField DataField="empid" HeaderText="Emp Id" />
       <asp:BoundField DataField="projectid" HeaderText="Proj Id" />
       <asp:BoundField DataField="date" HeaderText="Date" />
       <asp:BoundField DataField="totaltime" HeaderText="Total Time" />
       <asp:BoundField DataField="status" HeaderText="Status" />
        </Columns>
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    </asp:GridView>

</asp:Content>


