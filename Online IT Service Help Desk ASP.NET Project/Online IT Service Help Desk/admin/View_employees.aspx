<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="View_employees.aspx.cs" Inherits="admin_View_employees" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style12
        {
            width: 100%;
        }
        .style13
        {
            width: 80%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style12">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style13">
                    <tr>
                        <td align="center">
                            View Employees</td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:GridView ID="gv_view" runat="server" CellPadding="4" ForeColor="#333333" 
                                GridLines="None" AutoGenerateColumns="False">
                                <Columns>
                                <asp:BoundField DataField="emp_id" HeaderText="Employee Id" />
                                <asp:BoundField DataField="first_name" HeaderText="Name" />
                                <asp:BoundField DataField="email_id" HeaderText="E-Mail Id" />
                                <asp:BoundField DataField="position" HeaderText="Position" />
                                <asp:BoundField DataField="status" HeaderText="Status" />
                                </Columns>
                                <RowStyle BackColor="#EFF3FB" />
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
            </td>
        </tr>
    </table>
</asp:Content>

