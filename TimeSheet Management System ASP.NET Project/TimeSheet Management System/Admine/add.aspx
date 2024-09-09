<%@ Page Language="C#" MasterPageFile="~/Admine/Admin.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="Admine_add" Title="Untitled Page" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <table class="style27">
        <tr>
            <td style="color: #0000FF; font-size: x-large;">
                ADD EMPLOYEE:<br />
                                </td>
            <td>
                &nbsp;</td>
        </tr>
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
                password:</td>
            <td>
                <asp:TextBox ID="txt_psw" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Alt Email:</td>
            <td>
                <asp:TextBox ID="txt_aitmail" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="txt_adderss" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="txt_county" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                PinCode:</td>
            <td>
                <asp:TextBox ID="txt_pincde" runat="server"></asp:TextBox>
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
                <asp:TextBox ID="txt_stus" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <br />
                <asp:Button ID="btn_insert" style="position:absolute; top: 718px; left: 303px; height: 26px;" 
                    runat="server" Text="Insert" onclick="btn_insert_Click" />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>

