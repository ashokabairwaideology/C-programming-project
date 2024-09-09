<%@ Page Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="My_profile.aspx.cs" Inherits="Admin_My_profile" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            color: #000000;
            font-style: normal;
            font-weight: bold;
        }
        .style6
        {
            color: #FF3300;
            font-weight: bold;
            width: 100%;
            height: 37px;
            text-transform: uppercase;
            background-color: #CC99FF;
        }
        .style7
        {
            color: #000000;
            font-style: normal;
            font-weight: bold;
            width: 100%;
            height: 27px;
        }
        .style8
        {
            background-color: #CC99FF;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">

                <table align="center" class="style1" style="width: 57%">
                    <tr>
                        <td align="center" colspan="2" class="style6" scope="col">
                            My Profile</td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" class="style7" scope="col">
                            <asp:Label ID="lbl_myprofile" runat="server" Visible="False" 
                                style="color: #008000"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Empname</td>
                        <td align="left" class="style8">
                            <asp:TextBox ID="txtempname" runat="server" ReadOnly="True" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            Contactnumber</td>
                        <td class="style8">
                            <asp:TextBox ID="txtcontactname" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            Mailid</td>
                        <td class="style8">
                            <asp:TextBox ID="txtmailid" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            Country</td>
                        <td class="style8">
                            <asp:TextBox ID="txtcountry" runat="server" Height="22px" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            State</td>
                        <td class="style8">
                            <asp:TextBox ID="txtstate" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            City</td>
                        <td class="style8">
                            <asp:TextBox ID="txtcity" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            Address</td>
                        <td class="style8">
                            <asp:TextBox ID="txtaddress" runat="server" ReadOnly="True" 
                                TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="color: #000000" class="style8">
                            EmpId</td>
                        <td class="style8">
                            <asp:TextBox ID="txtempid" runat="server" ReadOnly="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" style="color: #000000" class="style8">
                            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                                PostBackUrl="~/Admin/Update_Profile.aspx">Edit</asp:LinkButton>
                        </td>
                    </tr>
    </table>

</asp:Content>



