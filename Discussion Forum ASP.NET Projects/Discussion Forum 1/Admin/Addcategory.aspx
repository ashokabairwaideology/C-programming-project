<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddCategory.aspx.cs" Inherits="Admin_AddCategory" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style3
        {
            font-family: Chiller;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <table align="center" class="style1">
            <tr>
                <td class="style2" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <span class="style3">&nbsp;<b 
                        style="font-family: 'Times New Roman', Times, serif">&nbsp; CATEGORY SELECTION</b></span></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="CategoryName:" 
                        style="font-weight: 700"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_catname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Description" runat="server" Text="Description" 
                        style="font-weight: 700"></asp:Label>
                &nbsp;<b>:</b></td>
                <td>
                    <asp:TextBox ID="txt_des" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="SUBMIT" 
                        style="font-weight: 700; font-size: large" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lbl_valid" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
</p>
<p>
</p>
</asp:Content>

