<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LiveDocs.pages.pub.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 500px;
        }
        .style2
        {
            width: 126px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div id="regform">
    <h1>Register</h1>
    <table class="style1">
        <tr>
            <td class="style2">
                Username:</td>
            <td>
                <asp:TextBox ID="RegisterUserNick" TabIndex="10" runat="server" Width="184px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="RegisterUsername" ErrorMessage="Username required" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Mail adress:</td>
            <td>
                <asp:TextBox ID="RegisterUsername" TabIndex="10" runat="server" Width="184px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="RegisterUsername" ErrorMessage="Username required" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ErrorMessage="Not a valid e-mail address" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ControlToValidate="RegisterUsername"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Password:</td>
            <td>
                <asp:TextBox ID="RegisterPassword" runat="server" TextMode="Password" 
                    Width="184px" TabIndex="11"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="RegisterUsername" ErrorMessage="Password required" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat=server display=dynamic
            ControlToValidate="RegisterPassword" 
            ErrorMessage="Password not long enough! Minimum 6 characters" 
            ValidationExpression="[^\s]{6,99}" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                Confirm password:</td>
            <td>
                <asp:TextBox ID="RegisterPasswordConfirm" runat="server" TextMode="Password" 
                    Width="184px" TabIndex="12"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="RegisterPassword" ControlToValidate="RegisterPasswordConfirm" 
                    ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="RegistrationSubmit" runat="server" TabIndex="13"
                    onclick="RegistrationSubmit_Click" Text="Register" />
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
