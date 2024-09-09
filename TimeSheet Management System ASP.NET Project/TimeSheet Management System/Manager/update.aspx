<%@ Page Language="C#" MasterPageFile="~/Manager/Mastermanager.master" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="Manager_update" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style27
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
        <table class="style27" __designer:mapid="0">
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
                    <asp:TextBox ID="txt_gen" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txt_position" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <br />
                    <br />
                   <asp:Button ID="btn_update" style="position:absolute; top: 690px; left: 365px; right: 497px;" 
                    runat="server" Text="Update" onclick="btn_update_Click"  />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
            </td>
        </tr>
    </table>
</asp:Content>

