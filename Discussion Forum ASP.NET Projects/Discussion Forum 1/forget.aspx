<%@ Page Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="forget.aspx.cs" Inherits="forget" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style18
    {
        height: 86px;
    }
    .style19
    {
        height: 45px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <table class="style1" style="height: 110px">
            <tr>
                <td class="style19">
                    <asp:Label ID="Label1" runat="server" Text="Emailid:"></asp:Label>
                </td>
                <td class="style19">
                    <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style18">
                    </td>
                <td class="style18" valign="top">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        style="height: 26px; font-weight: 700; font-size: large; width: 129px;" 
                        Text="ClickHere" Height="37px" Width="116px" />
                    <br />
                </td>
            </tr>
        </table>
        </p>
    <p>
    </p>
</asp:Content>

