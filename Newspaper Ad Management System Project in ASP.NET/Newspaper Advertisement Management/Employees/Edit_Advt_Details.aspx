<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="Edit_Advt_Details.aspx.cs" Inherits="Employees_Edit_Advt_Details" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            width: 320px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table cellpadding="0" cellspacing="0" class="style1" style="color: #000000">
        <tr>
            <td align="center" colspan="2" style="color: #000000">
                Update Advertisement Details</td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="color: #000000" id="lbl_">
                <asp:Label ID="lbl_AddDetails" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td  align="right" class="style4" style="color: #000000">
                Pagenumber&nbsp; </td>
            <td align="left" class="style10">
                <asp:TextBox ID="txtpgno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4" style="color: #000000">
                PageLocation</td>
            <td align="left" class="style10">
                <asp:TextBox ID="txtlocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Block_White cost</td>
            <td align="left" class="style10">
                <asp:TextBox ID="txtbwcost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right"  class="style4">
                Color_cost</td>
            <td align="left" class="style10">
                <asp:TextBox ID="txtccost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Description</td>
            <td align="left" class="style10">
                <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                Addid:</td>
            <td align="left" class="style10">
                <asp:TextBox ID="txtaddid" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" class="style4" colspan="2">
                <asp:Button ID="Button1" runat="server" 
                    style="font-weight: 700; font-style: italic" Text="Update pageData" 
                    onclick="Button1_Click" />
            &nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Cancel" />
            </td>
        </tr>
    </table>
</asp:Content>

