<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="displaythread.aspx.cs" Inherits="displaythread" Title="Untitled Page" ValidateRequest ="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
    Thread
    </h2>
    <br />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="100%">
        <HeaderTemplate >
           <table border="1" width="100%">
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
              <td width="20%">
                <img src='images/<%#Eval("uid")%>.jpg' width="100" height="100" alt="No Photo" />
                <br />
                <a href='displayuser.aspx?uid=<%#Eval("uid")%>'> <%#Eval("fullname") %> </a>
                <br />
                <%#Eval("dp") %>
              </td>
              <td>
               <pre><%# Server.HtmlEncode(Eval("text").ToString())%> </pre>
              </td>
            <tr>
        </ItemTemplate>
        <FooterTemplate>
          </table>
        </FooterTemplate>
    </asp:DataList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ForumsConnectionString %>"
        SelectCommand="GetThreadDetails" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:QueryStringParameter Name="tid" QueryStringField="tid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    Reply To This Thread:<br />
    <asp:TextBox ID="txtReply" runat="server" Height="128px" TextMode="MultiLine" Width="898px"></asp:TextBox><br />
    <asp:Button ID="btnReply" runat="server" OnClick="btnReply_Click" Text="Add Reply" /><br />
    <br />
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
</asp:Content>

