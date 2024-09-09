<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="all_register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h2>Registration</h2>
        <table>
            <tr>
                <td>
                    Email Address :
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="273px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email Address Is Required!" ControlToValidate="txtEmail"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Password :
                </td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Is Required!" ControlToValidate="txtPwd"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Confirm Password :
                </td>
                <td>
                    <asp:TextBox ID="txtConfirmPwd" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Confirm Password Is Required!" ControlToValidate="txtConfirmPwd"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    Fullname :
                </td>
                <td>
                    <asp:TextBox ID="txtFullname" runat="server" Width="272px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Occupation :
                </td>
                <td>
                    <asp:TextBox ID="txtOccup" runat="server" Width="475px"></asp:TextBox></td>
            </tr>
        </table>
    
    </div>
        <br />
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /><br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
    </form>
</body>
</html>
