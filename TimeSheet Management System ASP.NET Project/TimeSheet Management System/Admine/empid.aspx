<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="empid.aspx.cs" Inherits="Admine_empid" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style27">
        <tr>
            <td style="font-family: Magneto; font-size: x-large; font-weight: bold; font-style: italic; font-variant: normal; color: #0000FF">
                Welcom to
                <asp:Label ID="llb_fname" runat="server" Font-Bold="True" Font-Italic="True" 
                    Font-Names="Magneto" Font-Size="X-Large" ForeColor="#0033CC" Text="Label"></asp:Label>
&nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: Magneto; font-size: x-large; font-weight: bold; font-style: italic; color: #0000FF">
                Your Empid is&nbsp;&nbsp;
                <asp:Label ID="llb_id" runat="server" Font-Bold="True" Font-Italic="True" 
                    Font-Names="Magneto" Font-Size="X-Large" ForeColor="#0033CC" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

