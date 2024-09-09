<%@ Page Language="C#" MasterPageFile="~/MaintenanceManager/Maintainance.master" AutoEventWireup="true" CodeFile="VehicleAllocation.aspx.cs" Inherits="MaintenanceManager_VehicleAllocation" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 272px;
            border-color: #666633;
        }
        .style6
        {
            border-color: #666633;
            font-weight: bold;
        }
        .style7
        {
            font-weight: bold;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="right" cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td align="center" colspan="2" 
                style="font-family: Algerian; font-size: x-large; font-weight: normal; font-style: normal; font-variant: normal; text-transform: none; color: #000000">
                Vehicle Allocation</td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label6" runat="server" Text="Vendor Id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label1" runat="server" Text="Vender Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label2" runat="server" Text="VendeAddress"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label3" runat="server" Text="Phone No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label4" runat="server" Text="Email ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="22px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style4">
                <asp:Label ID="Label5" runat="server" Text="Remarks"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6" colspan="2">
                Select Vender Travel Route Details:-</td>
            </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label7" runat="server" Text="RouteId"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label12" runat="server" Text="CityName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label13" runat="server" Text="Destination"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label11" runat="server" Text="RouteDiscription"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                Distance</td>
            <td>
                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6" colspan="2">
                Select Vehicle For Travaling :-</td>
            </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label20" runat="server" Text="VehicleId"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList7_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label15" runat="server" Text="VechileName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label16" runat="server" Text="VehicleType"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label17" runat="server" Text="Register No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                Daily Rent</td>
            <td>
                <asp:TextBox ID="TextBox18" runat="server" 
                    ontextchanged="TextBox18_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label18" runat="server" Text="Rate/KM"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label19" runat="server" Text="Capacity"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                <asp:Label ID="Label8" runat="server" Text="Route Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                travalling date</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" align="right">
                No Of&nbsp; Days For Traveling:</td>
            <td>
                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton9" runat="server" CssClass="style7" 
                    onclick="LinkButton9_Click">Check Amount</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4" align="right">
                Car Rentel Amount</td>
            <td>
                <asp:Label ID="lbl_CarRent" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                Travel Distance Amount</td>
            <td>
                <asp:Label ID="lbl_DisAmount" runat="server" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4" align="right">
                Total</td>
            <td>
                <asp:Label ID="lbl_total" runat="server" Font-Bold="True" Font-Size="Medium" 
                    ForeColor="#FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" 
                    style="height: 26px" />
                <asp:Button ID="Button2" runat="server" Text="CLEAR" />
            </td>
        </tr>
    </table>
</asp:Content>

