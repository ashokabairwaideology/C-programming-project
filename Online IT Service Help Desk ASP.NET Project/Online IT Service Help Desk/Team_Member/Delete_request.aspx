<%@ Page Language="C#" MasterPageFile="~/Team_Member/Team_member.master" AutoEventWireup="true" CodeFile="Delete_request.aspx.cs" Inherits="Team_member_Delete_request" Title="Untitled Page" %>

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
                <asp:GridView ID="gd_dltrqst" runat="server" BackColor="#DEBA84" 
                    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    CellSpacing="2">
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="Request_id" HeaderText="Action" DataNavigateUrlFormatString="~/Team_Member/Delete_rqst2.aspx?reqid={0}" Text="Delete" />
                    </Columns>
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
                <br />
                <asp:Label ID="lbl_dltd" runat="server" Text="Seected Request deleted. . . " 
                    Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
