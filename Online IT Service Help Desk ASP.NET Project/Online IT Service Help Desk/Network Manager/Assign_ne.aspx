<%@ Page Language="C#" MasterPageFile="~/Network Manager/Network_manager.master" AutoEventWireup="true" CodeFile="Assign_ne.aspx.cs" Inherits="Network_Manager_Assign_ne" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 100%;
        }
        .style19
        {
            width: 80%;
        }
        .style20
        {
            height: 7px;
        }
        .style21
        {
            width: 73px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td align="center" class="style20" colspan="3" 
                            style="font-family: Rockwell; font-size: x-large; color: #CCFF66">
                            Assign To</td>
                    </tr>
                    <tr>
                        <td>
                            Request ID</td>
                        <td colspan="2">
                            <asp:TextBox ID="assign_reqid" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Employee ID</td>
                        <td colspan="2">
                            <asp:TextBox ID="assign_empid" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Type</td>
                        <td colspan="2">
                            <asp:TextBox ID="assign_type" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Description</td>
                        <td colspan="2">
                            <asp:TextBox ID="assign_description" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Assign To
                        </td>
                        <td colspan="2">
                            <asp:DropDownList ID="ddl_ne" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td colspan="2">
                            <asp:Label ID="assign_lbl" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                        <td class="style21">
                            <asp:Button ID="Assign_ne" runat="server" Text="Assign" 
                                onclick="Assign_ne_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Cancel_ne" runat="server" style="margin-left: 0px" 
                                Text="Cancel" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

