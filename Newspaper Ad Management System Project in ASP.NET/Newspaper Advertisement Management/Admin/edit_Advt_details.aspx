<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="edit_Advt_details.aspx.cs" Inherits="Admin_edit_Advt_details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style4
    {
        color: #FF3300;
        background-color: #CC99FF;
    }
    .style5
    {
        color: #FF3300;
        font-weight: bold;
        text-transform: uppercase;
        background-color: #CC99FF;
    }
    .style6
    {
        background-color: #CC99FF;
    }
        .style7
        {
            color: #FF3300;
            font-weight: bold;
            text-transform: uppercase;
            width: 100%;
            height: 65px;
            font-style: normal;
            background-color: #CC99FF;
        }
        .style8
        {
            color: #FF3300;
            font-family: "Times New Roman", Times, serif;
            font-style: italic;
            background-color: #CC99FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="0" cellspacing="0" class="style1" 
    style="color: #000000; height: 325px; width: 60%;">
        <tr>
            <td align="center" colspan="2" class="style7">
                Update Advertisement Details</td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="color: #000000" id="lbl_">
                <asp:Label ID="lbl_AddDetails" runat="server" Visible="False" 
                    style="color: #0066FF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  align="right" class="style8" style="color: #000000">
                Pagenumber:&nbsp; </td>
            <td align="left" class="style6">
                <asp:TextBox ID="txtpgno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style8" style="color: #000000">
                PageLocation:</td>
            <td align="left" class="style6">
                <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style6">
                Block_White cost:</td>
            <td align="left" class="style6">
                <asp:TextBox ID="txtbwcost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right"  class="style6">
                Color_cost:</td>
            <td align="left" class="style6">
                <asp:TextBox ID="txtccost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style6">
                Description:</td>
            <td align="left" class="style6">
                <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style6">
                Addid::</td>
            <td align="left" class="style6">
                <asp:TextBox ID="txtaddid" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style4" colspan="2">
                <asp:Button ID="Button1" runat="server" 
                    style="font-weight: 700; font-style: italic; background-color: #FFCC00;" Text="Update pageData" 
                    onclick="Button1_Click" />
            &nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Cancel" 
                    style="background-color: #FFCC66" />
            </td>
        </tr>
    </table>
</asp:Content>

