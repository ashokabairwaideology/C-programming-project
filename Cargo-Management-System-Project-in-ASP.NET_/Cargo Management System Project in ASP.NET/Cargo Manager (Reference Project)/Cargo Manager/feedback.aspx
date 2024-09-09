<%@ Page Language="C#" MasterPageFile="~/MasterPageuser.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="feedback" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table style="z-index: 102; left: 247px; width: 413px; position: absolute; top: 333px;
        height: 98px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Feedback" Font-Bold="True" Width="94px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtFeedback" runat="server" Height="89px" TextMode="MultiLine" Width="351px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" Text="Send" BackColor="#C0C0FF" Font-Bold="True" OnClick="Button1_Click" Width="92px" />
            
            </td>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

