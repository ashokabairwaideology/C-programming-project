<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Modify_employee.aspx.cs" Inherits="admin_Modify_employee" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
        {
            width: 100%;
            margin-left: 77px;
        }
        .style16
        {
            width: 362px;
        }
        .style15
        {
        }
        .style17
        {
            width: 280px;
            height: 30px;
        }
        .style18
        {
            height: 30px;
        }
        .style19
        {
            width: 280px;
            height: 25px;
        }
        .style20
        {
            height: 25px;
        }
        .style21
        {
        }
        .style22
        {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style14">
        <tr>
            <td>
    <table class="style12" style="width: 577px">
        <tr>
            <td class="style16">
                <table class="style14">
                    <tr>
                        <td class="style15" align="center" colspan="3">
                MODIFY EMPLOYEE</td>
                    </tr>
                    <tr>
                        <td class="style15">
                            EMPLOYEE ID</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                            FIRST NAME</td>
                        <td class="style18" colspan="2">
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            LASTNAME</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            EMAIL ID</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            PASSWORD</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            ADDRESS FOR CORRESPONDENCE</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            MOBILE NUMBER</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            CITY</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            STATE</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            ZIP</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            DATE OF BIRTH</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            DATE OF JOINING</td>
                        <td class="style20" colspan="2">
                            <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            POSITION</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            STATUS</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            PREVIOUS COMPANY</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            UNIQUE I.D</td>
                        <td colspan="2">
                            <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td class="style21">
                            <asp:Button ID="Button1" runat="server" Text="Update" onclick="Button1_Click" />
                        </td>
                        <td class="style22">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style15">
                            &nbsp;</td>
                        <td class="style21" colspan="2">
                                        <asp:Label ID="lbl_updte" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
            </td>
        </tr>
    </table>
</asp:Content>

