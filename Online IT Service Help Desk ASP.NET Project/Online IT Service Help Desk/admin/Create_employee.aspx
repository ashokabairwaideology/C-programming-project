<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Create_employee.aspx.cs" Inherits="admin_Create_employee" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style14
    {
        width: 136%;
        height: 568px;
        margin-left: 75px;
        margin-top: 0px;
            margin-right: 26px;
        }
        .style16
        {
            width: 707px;
        }
        .style17
        {
            width: 254px;
            height: 30px;
        }
        .style18
        {
            height: 30px;
        }
        .style24
        {
            width: 254px;
            height: 23px;
        }
        .style25
        {
            height: 23px;
        }
        .style19
        {
            width: 254px;
            height: 25px;
        }
        .style20
        {
            height: 25px;
        }
        .style22
        {
        width: 254px;
        height: 26px;
    }
        .style23
        {
            height: 26px;
        }
        .style21
        {
            width: 28px;
        }
        .style29
    {
        width: 254px;
    }
    .style30
    {}
    .style31
    {
        width: 296px;
    }
    .style32
    {
        height: 46px;
    }
    .style33
    {
        height: 84px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style14">
    <tr>
        <td>
    <table class="style12" style="width: 797px; height: 735px; margin-top: 0px;">
        <tr>
            <td class="style16">
                <table class="style14">
                    <tr>
                        <td class="style32" align="center" colspan="3">
                CREATE EMPLOYEE</td>
                    </tr>
                    <tr>
                        <td class="style33">
                            EMPLOYEE ID</td>
                        <td colspan="2" class="style33">
                            <asp:TextBox ID="EID" runat="server"></asp:TextBox>
                            <asp:LinkButton ID="LinkButton11" runat="server" BorderColor="#FF0066" 
                                Font-Underline="False" ForeColor="#FF0066" onclick="LinkButton11_Click" 
                                ValidationGroup="ckavbl">Check Availability</asp:LinkButton>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:Label ID="label_check" runat="server" Font-Size="Medium" ForeColor="Blue" 
                                Visible="False"></asp:Label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="EID" ErrorMessage="Eployee I.D must not be blank" 
                                ValidationGroup="ckavbl">*</asp:RequiredFieldValidator>
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                ShowMessageBox="True" ShowSummary="False" ValidationGroup="ckavbl" 
                                style="margin-bottom: 9px" Width="421px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style17">
                            FIRST NAME</td>
                        <td class="style18" colspan="2">
                            <asp:TextBox ID="E_FNAME" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            LASTNAME</td>
                        <td colspan="2">
                            <asp:TextBox ID="E_LNAME" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            EMAIL ID</td>
                        <td colspan="2">
                            <asp:TextBox ID="EMAIL" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            PASSWORD</td>
                        <td colspan="2">
                            <asp:TextBox ID="PSWRD" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style24">
                            CONFIRM PASSWORD</td>
                        <td colspan="2" class="style25">
                            <asp:TextBox ID="CNF_PWD" runat="server"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="PSWRD" ControlToValidate="CNF_PWD" 
                                ErrorMessage="PASSWORDS DOES NOT MATCH" ValidationGroup="ADD">*</asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            ADDRESS FOR CORRESPONDENCE</td>
                        <td colspan="2">
                            <asp:TextBox ID="ADDRS" runat="server" TextMode="MultiLine" Width="151px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            MOBILE NUMBER</td>
                        <td colspan="2">
                            <asp:TextBox ID="MOBILE" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            CITY</td>
                        <td colspan="2">
                            <asp:TextBox ID="CITY" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            STATE</td>
                        <td colspan="2">
                            <asp:TextBox ID="STATE" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            ZIP</td>
                        <td colspan="2">
                            <asp:TextBox ID="ZIP" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            DATE OF BIRTH</td>
                        <td colspan="2">
                            <asp:TextBox ID="DOB" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style19">
                            DATE OF JOINING</td>
                        <td class="style20" colspan="2">
                            <asp:TextBox ID="DOJ" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            POSITION</td>
                        <td colspan="2">
                            <asp:DropDownList ID="ddl_position" runat="server">
                                <asp:ListItem>Team member</asp:ListItem>
                                <asp:ListItem>Project manager</asp:ListItem>
                                <asp:ListItem>Network manager</asp:ListItem>
                                <asp:ListItem>Network Engineer</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="style22">
                            PREVIOUS COMPANY</td>
                        <td colspan="2" class="style23">
                            <asp:TextBox ID="PRVCMPNY" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style22">
                            &nbsp;</td>
                        <td colspan="2" class="style23">
                            <asp:Label ID="lbl_insert" runat="server" Visible="False"></asp:Label>
                            <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                                ShowMessageBox="True" ShowSummary="False" ValidationGroup="ADD" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style29">
                            &nbsp;</td>
                        <td class="style21">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ADD" 
                                ValidationGroup="ADD" Width="71px" />
                        </td>
                        <td class="style31">
                            &nbsp;</td>
                        <td class="style30">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
        </td>
    </tr>
</table>
</asp:Content>

