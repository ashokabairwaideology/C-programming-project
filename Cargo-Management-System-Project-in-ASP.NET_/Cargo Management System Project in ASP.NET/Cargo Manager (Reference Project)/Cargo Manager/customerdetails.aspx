<%@ Page Language="C#" MasterPageFile="~/MasterPageuser.master" AutoEventWireup="true" CodeFile="customerdetails.aspx.cs" Inherits="customerdetails" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    &nbsp;<br />
    <asp:Image ID="Image1" runat="server" style="z-index: 100; left: 2px; position: absolute; top: 222px" Height="55px" ImageUrl="~/images/customer details form.gif" Width="882px" />
    <asp:Button ID="Button1" runat="server" Text="Submit" style="z-index: 101; left: 394px; position: absolute; top: 904px" BackColor="#C0C0FF" Font-Bold="True" OnClick="Button1_Click" Width="77px" /> 
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table style="z-index: 102; left: 200px; width: 422px; position: absolute; top: 295px;
        height: 383px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Customer Name" Font-Bold="True" Width="115px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Can't be blank" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="Phone No" Font-Bold="True" Width="79px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Text="Email Id" Font-Bold="True" Width="75px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox3" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label4" runat="server" Text="Address" Font-Bold="True" Width="80px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label5" runat="server" Text="Type of Material" Font-Bold="True" Width="116px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>documents</asp:ListItem>
                    <asp:ListItem>non documents</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label6" runat="server" Text="Product Name" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label7" runat="server" Text="Number Of Products" Font-Bold="True" Width="160px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label8" runat="server" Text="Source" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label9" runat="server" Text="Destination" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label10" runat="server" Text="Destination Address" Font-Bold="True" Width="157px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label11" runat="server" Text="Destination Phone No" Font-Bold="True" Width="149px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox9" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label12" runat="server" Text="Time" Font-Bold="True" Width="67px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label13" runat="server" Text="Date" Font-Bold="True" Width="68px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
            <td style="width: 100px">
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label14" runat="server" style="z-index: 103; left: 511px; position: absolute; top: 909px" Width="182px"></asp:Label>
    <br />
    <br />
</asp:Content>

