<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Add_Employees.aspx.cs" Inherits="Admin_Add_Employees" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 101%;
            height: 431px;
        }
        .style5
        {            background-color: #CC99FF;
        }
        .style7
        {
            width: 311px;
            background-color: #CC99FF;
        }
        .style8
        {
            text-transform: uppercase;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style1" 
        style="height: 411px; width: 53%">
        <tr>
            <td style="color: #000000">
                <table align="center" cellpadding="0" cellspacing="0" class="style4">
                    <tr>
                        <td align="center" colspan="2" 
                            
                            style="color: #FF0000; font-size: x-large; font-weight: bold; background-color: #CC99FF;" 
                            class="style8">
                            Add Employees</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Label ID="lbl_addemp" runat="server" Visible="False" 
                                style="color: #669900"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Name:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Contact no:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_contactno" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Mail Id:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_mail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Country</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_country" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            State</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_state" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            City:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_city" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Address:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_address" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            User name:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Password:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style7">
                            Re-password:</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="txt_repwd" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style5" colspan="2">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                Text="Add Emp" style="background-color: #FFFF99" />
                            &nbsp;&nbsp;
                            <asp:Button ID="Button2" runat="server" Text="Reset" 
                                style="background-color: #FFFF99" />
                        </td>
                    </tr>
                    </table>
            </td>
        </tr>
    </table>
</asp:Content>

