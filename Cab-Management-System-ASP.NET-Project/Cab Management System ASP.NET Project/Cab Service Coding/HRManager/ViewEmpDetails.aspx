<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="ViewEmpDetails.aspx.cs" Inherits="HRManager_ViewEmpDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 75%;
        }
        .style4
        {
            width: 143px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style3">
        <tr>
            <td valign="top" class="style4">
                        <br />
                </td>
            <td>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="966px" onselectedindexchanged="GridView1_SelectedIndexChanged" 
        >
    <Columns>
        <asp:HyperLinkField HeaderText="Edit"  DataNavigateUrlFields="EId" DataNavigateUrlFormatString="EditEmpDetails.aspx?EmId={0}" Text="Edit" />
        <asp:HyperLinkField HeaderText="Delete" DataNavigateUrlFields="EId" DataNavigateUrlFormatString="DeleteEmp.aspx?EmId={0}"  Text="Delete" />
        <asp:BoundField DataField="EmpId" HeaderText="Employee Id" 
            SortExpression="databound" />
        <asp:BoundField DataField="Password" HeaderText="Password" 
            SortExpression="Databound" />
        <asp:BoundField DataField="CandidateAdd" HeaderText="CandidateAddres" 
            SortExpression="Databound" />
            <asp:BoundField DataField="Qualification" HeaderText="Qualification" 
            SortExpression="Databound" />
            <asp:BoundField DataField="DOB" HeaderText="DOB" 
            SortExpression="Databound" />
        
        <asp:BoundField DataField="Gender" HeaderText="Gender" 
            SortExpression="Databound" />
        <asp:BoundField DataField="phno" HeaderText="PhoneNo" 
            SortExpression="Databound" />
        
        <asp:BoundField DataField="Designation" HeaderText="Designation" 
            SortExpression="Databound" />
            <asp:BoundField DataField="Departement" HeaderText="Departement" 
            SortExpression="Databound" />
            <asp:BoundField DataField="Dateofjoin" HeaderText="Date of join" 
            SortExpression="Databound" />
        <asp:BoundField DataField="Status" HeaderText="Status" 
            SortExpression="Databound" />
            <asp:BoundField DataField="Age" HeaderText="Age" 
            SortExpression="Databound" />
            <asp:BoundField DataField="timespan" HeaderText="timespan" 
            SortExpression="Databound" />
       
    </Columns>
</asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

