<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="Edit_shifttimeings.aspx.cs" Inherits="HRManager_Edit_shiftDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style3
    {
        width: 75%;
    }
    .style4
    {
            width: 329px;
        }
    .style5
    {
        width: 329px;
        height: 19px;
    }
    .style6
    {
        height: 19px;
    }
        .style7
        {
            width: 329px;
            height: 22px;
        }
        .style8
        {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style3">
        <tr>
            <td align="center" bgcolor="#CCCCFF" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Shift TIming"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
            &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" class="style4">
            ShiftId
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style7">
                <asp:Label ID="Label2" runat="server" Text="ShiftName"></asp:Label>
            </td>
            <td class="style8">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style5">
                <asp:Label ID="Label3" runat="server" Text="StartingTime"></asp:Label>
            </td>
            <td class="style6">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label4" runat="server" Text="Dispatch"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label5" runat="server" Text="Total No Of Batches"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
            &nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Update" />
                <asp:Button ID="Button2" runat="server" Text="Clear" />
            </td>
        </tr>
    </table>
</asp:Content>

