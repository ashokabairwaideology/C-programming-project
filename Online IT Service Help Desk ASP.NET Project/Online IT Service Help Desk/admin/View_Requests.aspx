<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="View_Requests.aspx.cs" Inherits="admin_View_Requests" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style12
        {
            width: 100%;
        }
        .style13
        {
            width: 100%;
            border: 1px solid #000000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style12">
        <tr>
            <td>
                <table align="center" cellspacing="1" class="style13">
                    <tr>
                        <td align="center" 
                            style="font-family: Rockwell; color: #0066FF; text-decoration: blink; font-size: large">
                            Requests</td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:GridView ID="GV" runat="server" CellPadding="4" ForeColor="#333333" 
                                GridLines="None" AutoGenerateColumns="False">
                                <RowStyle BackColor="#EFF3FB" />
                                <Columns>
                                    <asp:HyperLinkField  DataNavigateUrlFields="req_id" HeaderText="Action" DataNavigateUrlFormatString="~/admin/Completed.aspx?reqid={0}" Text="Completed" />
                                    <asp:HyperLinkField  DataNavigateUrlFields="req_id" HeaderText="Action" DataNavigateUrlFormatString="~/admin/Rejected.aspx?reqid={0}" Text="Reject" />
                                    
                                    <asp:BoundField DataField="Req_id" HeaderText="Request I.D" />
                                    <asp:BoundField DataField="subject" HeaderText="Subject" />
                                    <asp:BoundField DataField="description" HeaderText="Description" />
                                    
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
            </td>
        </tr>
    </table>
</asp:Content>

