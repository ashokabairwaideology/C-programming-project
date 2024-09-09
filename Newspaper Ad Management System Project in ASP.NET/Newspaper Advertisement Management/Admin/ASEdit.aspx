<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ASEdit.aspx.cs" Inherits="Admin_ASEdit" Title="Untitled Page" %>

<script runat="server">

   
    
    
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style10
        {
            width: 70%;
        }
        .style11
        {
            font-size: x-large;
            color: #FF3300;
            text-transform: uppercase;
            font-style: italic;
            font-weight: bold;
            background-color: #CC99FF;
        }
        .style13
        {
            width: 353px;
            height: 43px;
            color: #000000;
            background-color: #CC99FF;
        }
        .style14
        {
            height: 43px;
            background-color: #CC99FF;
        }
        .style12
        {
            width: 353px;
            background-color: #CC99FF;
        }
        .style15
        {
            width: 353px;
            color: #000000;
            background-color: #CC99FF;
        }
        .style16
        {
            background-color: #CC99FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style10">
        <tr>
            <td align="center" colspan="2" class="style11">
                Add Details</td>
        </tr>
        <tr>
            <td align="right" class="style13">
                PageNo:</td>
            <td align="left" class="style14">
                <asp:TextBox ID="txt_pno" runat="server" Height="37px" Width="128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td  align="right" class="style15">
                PageLocation</td>
            <td align="left" class="style16">
                <asp:TextBox ID="txt_ploc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style15">
                Cost_SC_block &amp; white:</td>
            <td align="left" class="style16">
                <asp:TextBox ID="txt_bw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style15">
                Cost_SC_Colour</td>
            <td class="style16">
                <asp:TextBox ID="txt_colour" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style15">
                Description</td>
            <td align="left" class="style16">
                <asp:TextBox ID="txt_desc" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="update" 
                    style="background-color: #FFFF66" />
            </td>
            <td class="style16">
                &nbsp;
                <asp:Button ID="Button2" runat="server" Text="Reset" 
                    style="background-color: #FFFF66" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

