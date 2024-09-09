<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pricefinder.aspx.cs" Inherits="pricefinder" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>

    <asp:Image ID="Image1" runat="server" Height="52px" ImageUrl="~/images/3.gif" Width="867px" />
    <asp:Button ID="btnFind" runat="server" Text="Find" style="z-index: 101; left: 350px; position: absolute; top: 397px" BackColor="#C0C0FF" Font-Bold="True" Width="84px" OnClick="btnFind_Click" />
    &nbsp;
    <br />
    <br />
    <br />
    <table id="TABLE1" style="z-index: 102; left: 229px; position: absolute; top: 281px; width: 416px;" onclick="return TABLE1_onclick()">
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label1" runat="server" Text="Origin City" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlOrigincity" runat="server" Width="163px">
                </asp:DropDownList>
            </td>
           
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label2" runat="server" Text="Destination City" Font-Bold="True" Width="116px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlDestinationcity" runat="server" Width="162px">
                </asp:DropDownList>
            </td>
            
        </tr>
        <tr>
            <td style="width: 100px">
                <asp:Label ID="Label3" runat="server" Text="Weight" Font-Bold="True" Width="66px"></asp:Label>
            </td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddlWeight" runat="server" Width="164px">
                </asp:DropDownList>
            </td>
            
        </tr>
        <tr>
        <td style="height: 21px">
            <asp:Label ID="Label5" runat="server" Text="Total Price" Font-Bold="True" Width="90px"></asp:Label>
        
        </td>
        <td>
            &nbsp;
        <asp:Label ID="Label4" runat="server" style="z-index: 100; left: 179px;  top: 80px" Width="70px" ></asp:Label>
        </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    &nbsp;<br />
    <br />
    &nbsp;<br />
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

