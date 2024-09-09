<%@ Page Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="frgtpswd2.aspx.cs" Inherits="frgtpswd2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style13
        {
            width: 342px;
        }
        .style14
        {
            width: 343px;
        }
    .style18
    {
        width: 343px;
        font-weight: normal;
        height: 21px;
    }
    .style19
    {
        height: 21px;
    }
    .style20
    {
        width: 100%;
        height: 25px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table class="style1" style="height: 113px">
            <tr>
                <td class="style13">
                    <asp:Label ID="Label1" runat="server" Text="Hint Question:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lbl_hintq" runat="server" Text="lbl_hintq"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:Label ID="Label4" runat="server" Text="Hint Answer"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style13">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
                        style="font-weight: 700; font-size: large" />
&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lbl_msg" runat="server" Text="lbl_Msg" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
    </p>
    <table class="style20">
        <tr>
            <td class="style18">
                <asp:Label ID="Label3" runat="server" Text="Your Password is:" Visible="False"></asp:Label>
            </td>
            <td class="style19">
                <asp:Label ID="Label5" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

