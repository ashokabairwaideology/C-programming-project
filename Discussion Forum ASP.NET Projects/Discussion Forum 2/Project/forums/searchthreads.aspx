<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="searchthreads.aspx.cs" Inherits="searchthreads" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
        Search Threads<br />
    </h2>
    <p>
        Thread Text :
        <asp:TextBox ID="txtText" runat="server"></asp:TextBox>&nbsp;</p>
    <p>
        From Date &nbsp; &nbsp; :
        <asp:TextBox ID="txtFromDate" runat="server" Width="67px"></asp:TextBox>
        (mm/dd/yy) To Date :
        <asp:TextBox ID="txtToDate" runat="server" Width="79px"></asp:TextBox>&nbsp;
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" /></p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="5"
            Width="100%">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="tid" DataNavigateUrlFormatString="displaythread.aspx?tid={0}"
                    DataTextField="text" HeaderText="Thread" />
                <asp:HyperLinkField DataNavigateUrlFields="uid" DataNavigateUrlFormatString="displayuser.aspx?uid={0}"
                    DataTextField="fullname" HeaderText="Posted By" />
                <asp:BoundField DataField="dp" HeaderText="Posted On" />
                <asp:BoundField DataField="subname" HeaderText="Subject" />
                <asp:BoundField DataField="noreplys" HeaderText="No. Replys" />
            </Columns>
        </asp:GridView>
        &nbsp;</p>
</asp:Content>

