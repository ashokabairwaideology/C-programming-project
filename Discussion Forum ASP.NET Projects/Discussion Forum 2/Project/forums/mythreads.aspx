<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mythreads.aspx.cs" Inherits="mythreads" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    My Threads<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="tid" HeaderText="tid" SortExpression="tid" />
            <asp:HyperLinkField DataNavigateUrlFields="tid" DataNavigateUrlFormatString="displaythread.aspx?tid={0}"
                DataTextField="text" HeaderText="Text" />
            <asp:BoundField DataField="subname" HeaderText="subname" SortExpression="subname" />
            <asp:BoundField DataField="dp" HeaderText="dp" SortExpression="dp" />
            <asp:BoundField DataField="noreplys" HeaderText="noreplys" ReadOnly="True" SortExpression="noreplys" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ForumsConnectionString %>"
        SelectCommand="MyThreads" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="uid" SessionField="uid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

