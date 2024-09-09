<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Admine_Update" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Panel ID="pnl_empudt" runat="server" Visible="False">
        <table class="style27">
            <tr>
                <td>
                    &nbsp;First Name:</td>
                <td>
                    <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Lat Name:</td>
                <td>
                    <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Gender:</td>
                <td>
                    <asp:RadioButtonList ID="rdb_gender" runat="server" AutoPostBack="True">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    Phno:</td>
                <td>
                    <asp:TextBox ID="txt_pno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email:</td>
                <td>
                    <asp:TextBox ID="txt_emai" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Alt Email:</td>
                <td>
                    <asp:TextBox ID="txt_atml" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Experence:</td>
                <td>
                    <asp:TextBox ID="txt_exc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Date Of Join:</td>
                <td>
                    <asp:TextBox ID="txt_doj" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Address:</td>
                <td>
                    <asp:TextBox ID="txt_adress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    City:</td>
                <td>
                    <asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    State:</td>
                <td>
                    <asp:TextBox ID="txt_state" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Country:</td>
                <td>
                    <asp:TextBox ID="txt_cuntry" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    PinCode:</td>
                <td>
                    <asp:TextBox ID="txt_pinc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Position:</td>
                <td>
                    <asp:DropDownList ID="txt_posn" runat="server">
                        <asp:ListItem>ADMIN</asp:ListItem>
                        <asp:ListItem>MANAGER</asp:ListItem>
                        <asp:ListItem>EMPLOYEE</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    Status:</td>
                <td>
                    <asp:TextBox ID="txt_status" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <br />
                    <asp:Button ID="btn_update" style="position:absolute; top: 683px; left: 344px;" 
                    runat="server" Text="Update" onclick="btn_update_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </asp:Panel>
    </asp:Content>

