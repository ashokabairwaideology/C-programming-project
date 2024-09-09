<%@ Page Language="C#" MasterPageFile="~/Network Engineer/Network engineer.master" AutoEventWireup="true" CodeFile="View_Requests.aspx.cs" Inherits="Network_Engineer_View_Requests" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
    {
        width: 86%;
            margin-left: 36px;
        }
        .style19
        {
            width: 80%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
    <tr>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style18">
                <tr>
                    <td>
                        <table align="center" cellpadding="0" cellspacing="0" class="style19">
                            <tr>
                                <td align="center" 
                                    
                                    style="color: #9999FF; font-family: Rockwell; font-size: x-large; text-decoration: blink; ">
                                    View Requests</td>
                            </tr>
                            <tr>
                                <td>
                <asp:GridView ID="gv_approve" runat="server" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" Width="679px" AutoGenerateColumns="False">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="Request_id" HeaderText="Action" DataNavigateUrlFormatString="Completed.aspx?reqid={0}" Text="Completed" />
                        <asp:HyperLinkField />
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
                            <tr>
                                <td>
                                    <asp:Label ID="lbl_closetckt" runat="server" Visible="False"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>

