<%@ Page Language="C#" MasterPageFile="~/HRManager/HRMasterPage.master" AutoEventWireup="true" CodeFile="EmpRegistration.aspx.cs" Inherits="HRManager_EmpRegistration" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style4
    {
        width: 326px;
    }
        .style5
        {
            width: 312px;
            height: 32px;
        }
        .style6
        {
            height: 32px;
        }
        .style7
        {
            width: 312px;
            height: 30px;
        }
        .style8
        {
            height: 30px;
        }
        .style9
        {
            width: 312px;
        }
        .style10
        {
            width: 312px;
            height: 37px;
        }
        .style11
        {
            height: 37px;
        }
        .style12
        {
            width: 312px;
            height: 22px;
        }
        .style13
        {
            height: 22px;
        }
        .style14
        {
            width: 312px;
            height: 26px;
        }
        .style15
        {
            height: 26px;
        }
        .style16
        {
            width: 312px;
            height: 25px;
        }
        .style17
        {
            height: 25px;
        }
        .style18
        {
            width: 312px;
            height: 29px;
        }
        .style19
        {
            height: 29px;
        }
        .style20
        {
            width: 312px;
            height: 33px;
        }
        .style21
        {
            height: 33px;
        }
        .style22
        {
            margin-left: 0px;
        }
        .style23
        {
            width: 72%;
            height: 489px;
        }
        .style24
        {
            width: 107px;
        }
    .style25
    {
        width: 75%;
    }
        .style26
        {
            width: 312px;
            height: 32px;
            margin-left: 80px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table align="center" bgcolor="#FFCCFF" cellpadding="0" cellspacing="0" 
            class="style23">
            <tr>
                <td align="center" valign="top"
                    
                     font-weight: normal; font-style: normal; font-variant: normal; 
                    text-transform: none;" 
                    rowspan="18" class="style24">
                            &nbsp;</td>
                <td align="center" colspan="2" 
                    style="font-family: Algerian; font-size: x-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none;">
                    <asp:Label ID="Label1" runat="server" Text="Employe Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" class="style26">
                    <asp:Label ID="Label2" runat="server" Text="EmpName"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style7">
                    <asp:Label ID="Label16" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="TextBox12" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style9">
                    <asp:Label ID="Label3" runat="server" Text="Candidate Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style9">
                    <asp:Label ID="Label4" runat="server" Text="Qualification"></asp:Label>
                </td>
                <td class="style4">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style9">
                    <asp:Label ID="Label5" runat="server" Text="D.O.B"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style9">
                    <asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style10">
                    <asp:Label ID="Label8" runat="server" Text="Phone Number"></asp:Label>
                </td>
                <td class="style11">
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="style22"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style12">
                    <asp:Label ID="Label9" runat="server" Text="Designation"></asp:Label>
                </td>
                <td class="style13">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Manager</asp:ListItem>
                        <asp:ListItem>Maintance Manager</asp:ListItem>
                        <asp:ListItem>Finance Manager</asp:ListItem>
                        <asp:ListItem>Movement Manager</asp:ListItem>
                        <asp:ListItem>Driver</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style14">
                    <asp:Label ID="Label10" runat="server" Text="Department"></asp:Label>
                </td>
                <td class="style15">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Maintance</asp:ListItem>
                        <asp:ListItem>Finance</asp:ListItem>
                        <asp:ListItem>Movement</asp:ListItem>
                        <asp:ListItem>manager</asp:ListItem>
                        <asp:ListItem>Driver</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" class="style5">
                    <asp:Label ID="Label11" runat="server" Text="D.O.Join"></asp:Label>
                </td>
                <td class="style6">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style7">
                    <asp:Label ID="Label12" runat="server" Text="Status"></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style16">
                    <asp:Label ID="Label13" runat="server" Text="Age"></asp:Label>
                </td>
                <td class="style17">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style18">
                    <asp:Label ID="Label14" runat="server" Text="TimeSpan"></asp:Label>
                </td>
                <td class="style19">
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style20">
                    <asp:Label ID="Label15" runat="server" Text="ImagePath"></asp:Label>
                </td>
                <td class="style21">
                    <asp:FileUpload ID="FileUpload2" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="Panel1" runat="server" Visible="False">
                        <table align="center" cellpadding="0" cellspacing="0" 
    class="style25">
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label17" runat="server" Text="Experince"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label6" runat="server" Text="Licence No"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="Label18" runat="server" Text="No Of Accident"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Clear" onclick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Height="26px" 
                        Text="Insert" onclick="Button2_Click" />
                </td>
            </tr>
        </table>
</asp:Content>


