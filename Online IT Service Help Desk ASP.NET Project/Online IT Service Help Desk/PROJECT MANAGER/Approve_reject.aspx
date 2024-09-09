<%@ Page Language="C#" MasterPageFile="~/PROJECT MANAGER/Project_manager.master" AutoEventWireup="true" CodeFile="Approve_reject.aspx.cs" Inherits="PROJECT_MANAGER_Approve_reject" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style12
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style12">
        <tr>
            <td align="center">
                <asp:GridView ID="gv_approve" runat="server" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" Width="679px" AutoGenerateColumns="False">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="Request_id" HeaderText="Action" DataNavigateUrlFormatString="~/PROJECT MANAGER/Approve_action.aspx?reqid={0}" Text="Approve" />
                        <asp:HyperLinkField />
                        <asp:HyperLinkField DataNavigateUrlFields="Request_id" HeaderText="Action" DataNavigateUrlFormatString="~/PROJECT MANAGER/Reject_action.aspx?reqid={0}" Text="Reject" />
                        <asp:BoundField DataField="Request_id" HeaderText="REQUEST ID" />
                        <asp:BoundField DataField="Emp_id" HeaderText="EMPLOYEE ID" />

                        <asp:BoundField DataField="Type" HeaderText="TYPE" />

                        <asp:BoundField DataField="Description" HeaderText="Request For" />
                        
                    </Columns>
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

