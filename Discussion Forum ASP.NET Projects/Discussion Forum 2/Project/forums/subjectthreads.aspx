<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="subjectthreads.aspx.cs" Inherits="subjectthreads" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
        Threads</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1"
        EmptyDataText="No threads found in this subject!" Width="100%">
        <Columns>
            <asp:BoundField DataField="tid" HeaderText="tid" SortExpression="tid" Visible="False" />
            <asp:HyperLinkField DataNavigateUrlFields="tid" DataNavigateUrlFormatString="displaythread.aspx?tid={0}"
                DataTextField="text" HeaderText="Thread" />
            <asp:BoundField DataField="dp" HeaderText="dp" SortExpression="dp" />
            <asp:BoundField DataField="uid" HeaderText="uid" SortExpression="uid" Visible="False" />
            <asp:HyperLinkField DataNavigateUrlFields="uid" DataNavigateUrlFormatString="displayuser.aspx?uid={0}"
                DataTextField="fullname" HeaderText="Posted By" />
            <asp:BoundField DataField="noreplys" HeaderText="noreplys" ReadOnly="True" SortExpression="noreplys" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ForumsConnectionString %>"
        SelectCommand="GetSubjectThreads" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="subcode" QueryStringField="subcode" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

