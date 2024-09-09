<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="z-index: 100; left: 384px; position: absolute; top: 469px" BackColor="#C0C0FF" Font-Bold="True" OnClick="btnSubmit_Click" Width="80px" />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/homepage.aspx" Style="z-index: 103;
        left: 392px; position: absolute; top: 520px">Back</asp:HyperLink>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#804040" Height="16px"
        Style="z-index: 102; left: 526px; position: absolute; top: 474px" Text="Successfully Registered"
        Visible="False" Width="179px"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table style="z-index: 102; left: 278px; width: 327px; position: absolute; top: 301px;
        height: 83px">
        <tr>
            <td style="width: 68px; height: 37px;">
                <asp:Label ID="Label1" runat="server" Text="UserName" Font-Bold="True" Height="17px"></asp:Label>
                </td>
            <td style="width: 143px; height: 37px;">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px; height: 37px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="cannot be blank" ControlToValidate="txtUsername" Width="142px"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 68px; height: 33px;">
                <asp:Label ID="Label2" runat="server" Text="PassWord" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 143px; height: 33px;">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" MaxLength="8" Width="147px"></asp:TextBox>
            </td>
            <td style="width: 100px; height: 33px;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="cannot be blank" ControlToValidate="txtPassword" Width="170px"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="width: 68px">
                <asp:Label ID="Label3" runat="server" Text="Phone No" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 143px">
                <asp:TextBox ID="txtPhoneno" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="cannot exceed 10 no's" ControlToValidate="txtPhoneno" ValidationExpression="\d{10}" Width="142px"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 68px">
                <asp:Label ID="Label4" runat="server" Text="Email id" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 143px">
                <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="format is wrong" ControlToValidate="txtEmailid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Width="125px"></asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

