<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddSubCategory.aspx.cs" Inherits="Admin_AddSubCategory" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style3
        {
            height: 52px;
        }
        .style17
        {
        width: 307px;
    }
        .style18
        {
            height: 63px;
            font-weight: 700;
            font-style: italic;
            font-size: xx-large;
            width: 389px;
        }
    .style20
    {
        height: 63px;
        font-weight: 700;
        font-style: italic;
        font-size: xx-large;
        width: 307px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1">
    <tr>
        <td class="style3" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" 
                        style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: 700; font-style: italic;" 
                        Text="SUBCATEGORY SELECTION"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style17">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Category name" 
                style="font-weight: 700"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style17">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Subcategory Name" 
                style="font-weight: 700"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_subcatname" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style17">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Description" 
                style="font-weight: 700"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txt_des" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style20">
        </td>
        <td class="style2">
            <asp:Button ID="btn_insert" runat="server" onclick="btn_insert_Click" 
                        Text="INSERT" style="font-weight: 700; font-size: large" />
        </td>
    </tr>
    <tr>
        <td class="style17">
            &nbsp;</td>
        <td>
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>

