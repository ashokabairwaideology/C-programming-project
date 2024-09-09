<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="update_profile.aspx.cs" Inherits="Employees_update_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" class="style1">
        <tr>
            <td align="center" colspan="2" class="style5" scope="col">
                Update Profile</td>
        </tr>
        <tr>
            <td align="center" colspan="2" class="style5" scope="col">
                <asp:Label ID="lbl_myprofile" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Empname</td>
            <td align="left">
                <asp:TextBox ID="txtempname" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            Contactnumber</td>
            <td>
                <asp:TextBox ID="txtcontactname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            Mailid</td>
            <td>
                <asp:TextBox ID="txtmailid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            Country</td>
            <td>
                <asp:TextBox ID="txtcountry" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            State</td>
            <td>
                <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            City</td>
            <td>
                <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            Address</td>
            <td>
                <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="color: #000000">
                            EmpId</td>
            <td>
                <asp:TextBox ID="txtempid" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2" style="color: #000000">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
&nbsp;
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Reset" />
            </td>
        </tr>
    </table>
</asp:Content>

