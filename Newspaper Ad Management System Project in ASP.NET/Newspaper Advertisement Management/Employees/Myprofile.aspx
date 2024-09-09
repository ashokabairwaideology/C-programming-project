<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="Myprofile.aspx.cs" Inherits="Employees_Myprofile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table align="center" cellpadding="0" cellspacing="0" class="style9">
        <tr>
            <td>

                <table align="center" class="style1">
                    <tr>
                        <td align="center" colspan="2" class="style5" scope="col">
                            My Profile</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" class="style5" scope="col">
                            <asp:Label ID="lbl_myprofile" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Empname</td>
                        <td align="left">
                            <asp:TextBox ID="txtempname" runat="server" ReadOnly="True" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            Contactnumber</td>
                        <td>
                            <asp:TextBox ID="txtcontactname" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            Mailid</td>
                        <td>
                            <asp:TextBox ID="txtmailid" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            Country</td>
                        <td>
                            <asp:TextBox ID="txtcountry" runat="server" Height="22px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            State</td>
                        <td>
                            <asp:TextBox ID="txtstate" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            City</td>
                        <td>
                            <asp:TextBox ID="txtcity" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            Address</td>
                        <td>
                            <asp:TextBox ID="txtaddress" runat="server" ReadOnly="True" 
                                TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style6">
                            EmpId</td>
                        <td>
                            <asp:TextBox ID="txtempid" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" style="color: #000000">
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                                PostBackUrl="~/Employees/update_profile.aspx">Edit</asp:LinkButton>
                        </td>
                    </tr>
    </table>

            </td>
        </tr>
    </table>
</asp:Content>


