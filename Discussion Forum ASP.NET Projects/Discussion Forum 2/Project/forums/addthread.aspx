<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addthread.aspx.cs" Inherits="addthread" Title="Untitled Page" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Add Thread</h2>
    <p>
        <table>
            <tr>
                <td>
                    Select Subject :
                </td>
                <td>
                    <asp:DropDownList ID="ddlSubjects" runat="server" DataSourceID="SqlDataSource1" DataTextField="subname"
                        DataValueField="subcode" Width="320px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    Enter Text :
                </td>
                <td>
                    <asp:TextBox ID="txtText" runat="server" Columns="50" Rows="10" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Button ID="btnAdd" runat="server" Text="Add Thread" OnClick="btnAdd_Click" />&nbsp;</p>
    <p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>&nbsp;</p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ForumsConnectionString %>"
            SelectCommand="SELECT [subcode], [subname] FROM [subjects] ORDER BY [subname]"></asp:SqlDataSource>
        &nbsp;</p>
</asp:Content>

