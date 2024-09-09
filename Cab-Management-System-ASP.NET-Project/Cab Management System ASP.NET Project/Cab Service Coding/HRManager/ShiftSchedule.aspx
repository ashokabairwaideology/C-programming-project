<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="ShiftSchedule.aspx.cs" Inherits="HRManager_ShiftSchedule" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 75%;
        }
        .style4
        {
            width: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style3">
        <tr>
            <td align="center" bgcolor="Aqua" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Shift Schedule"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label2" runat="server" Text="Emp Id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label3" runat="server" Text="Departement"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label5" runat="server" Text="Emp Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label6" runat="server" Text="Shift Id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label7" runat="server" Text="Route Id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server" 
                    >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Clear" onclick="Button2_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

