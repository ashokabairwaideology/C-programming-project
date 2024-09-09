<%@ Page Language="C#" MasterPageFile="~/Team_Member/Team_member.master" AutoEventWireup="true" CodeFile="Track_request.aspx.cs" Inherits="Team_member_Track_request" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td align="center">
                <asp:GridView ID="gv_track" runat="server" CellPadding="4" ForeColor="#333333" 
                    GridLines="None" AutoGenerateColumns="False">
                    <Columns>
                    <asp:BoundField DataField="Type" HeaderText="Type" />
                    <asp:BoundField DataField="Description" HeaderText="Description" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    
                    </Columns>
                    <RowStyle BackColor="#EFF3FB" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <br />
                <asp:LinkButton ID="lnk_rjctdrqsts" runat="server" Font-Underline="False" 
                    onclick="lnk_rjctdrqsts_Click">Click here to View rejected Requests</asp:LinkButton>
                <br />
                <br />
                <asp:GridView ID="gv_rjctd" runat="server" Visible="False" 
                    BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
                    CellPadding="2" ForeColor="Black" GridLines="None">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="Request_id" HeaderText="Action" DataNavigateUrlFormatString="~/Team_Member/Delete_action.aspx?reqid={0}" Text="Delete" /> 
                        
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                        HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                </asp:GridView>
                <br />
                <asp:Label ID="lbl_dltd" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#FF0066" Text="There are no Rejected Requests" Visible="False"></asp:Label>
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

