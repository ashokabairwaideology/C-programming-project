<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Subjects<br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="subcode"
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="subcode" HeaderText="subcode" ReadOnly="True" SortExpression="subcode"
                Visible="False" />
            <asp:HyperLinkField DataNavigateUrlFields="subcode" DataNavigateUrlFormatString="subjectthreads.aspx?subcode={0}"
                DataTextField="subname" HeaderText="Subject" />
            <asp:BoundField DataField="nothreads" HeaderText="No. Threads" ReadOnly="True" SortExpression="nothreads" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ForumsConnectionString %>"
        SelectCommand="GetSubjects" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    
</asp:Content>

