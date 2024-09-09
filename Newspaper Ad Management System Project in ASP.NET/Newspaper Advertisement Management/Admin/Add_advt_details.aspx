<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Add_advt_details.aspx.cs" Inherits="Admin_Add_advt_details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {            color: #CC99FF;
            font-weight: normal;
            font-style: normal;
            height: 29px;
            background-color: #CC99FF;
        }
        .style5
        {
            color: #FF0000;
            text-transform: uppercase;
            font-weight: bold;
        }
        .style7
        {
            font-style: normal;
            background-color: #CC99FF;
        }
        .style9
        {
            color: #CC99FF;
            background-color: #CC99FF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table cellpadding="0" cellspacing="0" class="style1" 
        style="color: #000000; height: 236px; width: 66%;">
        <tr>
            <td align="center" colspan="2" style="background-color: #CC99FF;" 
                class="style5">
                Add Details</td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="color: #000000" id="lbl_">
                <asp:Label ID="lbl_AddDetails" runat="server" Visible="False" 
                    style="color: #008000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  align="right" class="style7">
                Pagenumber&nbsp; </td>
            <td align="left" class="style9">
                <asp:TextBox ID="txtpgno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style7">
                PageLocation</td>
            <td align="left" class="style9">
                <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style7">
                Block_White cost</td>
            <td align="left" class="style9">
                <asp:TextBox ID="txtbwcost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right"  class="style7">
                Color_cost</td>
            <td align="left" class="style9">
                <asp:TextBox ID="txtccost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style7">
                Description</td>
            <td align="left" class="style9">
                <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style4" colspan="2">
                <asp:Button ID="Button1" runat="server" 
                    style="font-weight: 700; font-style: italic; background-color: #FFCC00;" Text="Add pageData" 
                    onclick="Button1_Click" />
            </td>
        </tr>
    </table>

</asp:Content>


