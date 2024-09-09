<%@ Page Language="C#" MasterPageFile="~/User/userMasterPage.master" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="User_UpdateProfile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style30
    {
        height: 30px;
        width: 249px;
    }
        .style19
        {
            height: 30px;
        }
        .style36
    {
        height: 26px;
        width: 249px;
    }
        .style18
        {
            height: 26px;
        }
        .style31
    {
        height: 33px;
        width: 249px;
    }
    .style32
    {
        height: 33px;
    }
    .style33
    {
        height: 26px;
        width: 100%;
    }
        .style27
        {
        height: 29px;
        width: 249px;
    }
        .style37
    {
        height: 22px;
        width: 249px;
    }
    .style34
    {
        height: 22px;
        width: 100%;
    }
        .style29
        {
            width: 249px;
        }
    .style35
    {
        width: 282px;
    }
        .style28
        {
            height: 32px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="width: 623px">
        <table cellpadding="0" cellspacing="0" class="style3" 
            style="margin-bottom: 0px">
            <tr>
                <td class="style30">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="FirstName"></asp:Label>
                </td>
                <td class="style19">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style36">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
                </td>
                <td class="style18">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style31">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="EmailID"></asp:Label>
                </td>
                <td class="style32">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style36">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="AltEmailId"></asp:Label>
                </td>
                <td class="style33">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style27">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Text="MaritalStatus"></asp:Label>
                </td>
                <td class="style21">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style37">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="PhoneNo"></asp:Label>
                </td>
                <td class="style34">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style27">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="City"></asp:Label>
                </td>
                <td class="style21">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style29">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label9" runat="server" Text="State"></asp:Label>
                </td>
                <td class="style35">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style28" align="left">
                    <asp:Label ID="Label10" runat="server">Edit Image:</asp:Label>
                </td>
                <td class="style28">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style28" colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" 
                        style="font-weight: 700; font-size: large" />
                </td>
            </tr>
        </table>
        <br />
</p>
<p>
</p>
</asp:Content>

