<%@ Page Language="C#" MasterPageFile="~/Emp/emp.master" AutoEventWireup="true" CodeFile="Modify.aspx.cs" Inherits="Emp_Modify" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style2">
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    Height="153px" Width="588px" BackColor="White" BorderColor="#E7E7FF" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <Columns>
                    <asp:BoundField DataField="timesheetid" HeaderText="ID" />
                    <asp:BoundField DataField="empid" HeaderText="Emp Id" />
                    <asp:BoundField DataField="projectid" HeaderText="Project Id" />
                    <asp:BoundField DataField="date" HeaderText="Date" />
                    <asp:BoundField DataField="totaltime" HeaderText="Total Time" />
                    <asp:BoundField DataField="status" HeaderText="Status" />
                    
                        <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="timesheetid" DataNavigateUrlFormatString="~\Emp\Updatetimesht.aspx?updateid={0}"  Text="Modify" />
                        <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="timesheetid" DataNavigateUrlFormatString="~\Emp\Delsht.aspx?deleid={0}" Text="Delete" />
                    </Columns>
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

