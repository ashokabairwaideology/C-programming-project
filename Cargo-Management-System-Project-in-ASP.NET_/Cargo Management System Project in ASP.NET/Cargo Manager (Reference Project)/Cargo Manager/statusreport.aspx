<%@ Page Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="statusreport.aspx.cs" Inherits="statusreport" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <table style="z-index: 102; left: 172px; width: 433px; position: absolute; top: 279px;
        height: 382px">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Customer Id" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:TextBox ID="txtCustomerid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="Customername" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:TextBox ID="txtCustomername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Text="Source" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:DropDownList ID="ddlSource" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Banglore</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                
                <asp:Label ID="Label4" runat="server" Text="Destination" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:DropDownList ID="ddlDestination" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Banglore</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label5" runat="server" Text="Destination Address" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:TextBox ID="txtDestinationaddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label6" runat="server" Text="Flight No" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:DropDownList ID="ddlFlightno" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>A111-100</asp:ListItem>
                    <asp:ListItem>A333-100</asp:ListItem>
                    <asp:ListItem>B666-100</asp:ListItem>
                    <asp:ListItem>B777-100</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label7" runat="server" Text="Cargo No" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:DropDownList ID="ddlCargono" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>C1</asp:ListItem>
                    <asp:ListItem>C2</asp:ListItem>
                    <asp:ListItem>C3</asp:ListItem>
                    <asp:ListItem>C4</asp:ListItem>
                    <asp:ListItem>C5</asp:ListItem>
                    <asp:ListItem>C6</asp:ListItem>
                    <asp:ListItem>C7</asp:ListItem>
                    <asp:ListItem>C8</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 100px; height: 175px;">
                <asp:Label ID="Label8" runat="server" Text="Delivering Date" Font-Bold="True" Width="119px"></asp:Label>
            </td>
            <td style="width: 113px; height: 175px;">
                <asp:TextBox ID="txtDeliveringdate" runat="server"></asp:TextBox>
            </td>
            <td style="width: 123px; height: 175px;">
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label9" runat="server" Text="Status" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 113px">
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem>SELECT</asp:ListItem>
                    <asp:ListItem>On Travelling</asp:ListItem>
                    <asp:ListItem>Delivered</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" Text="Send" BackColor="#C0C0FF" Font-Bold="True" OnClick="Button1_Click" Width="70px" />
            </td>
            <td style="width: 113px">
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
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
</asp:Content>

