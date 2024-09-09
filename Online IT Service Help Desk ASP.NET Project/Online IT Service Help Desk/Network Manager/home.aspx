<%@ Page Language="C#" MasterPageFile="~/Network Manager/Network_manager.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Network_Manager_home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
    {
        width: 116%;
            height: 135px;
            margin-left: 0px;
        }
    .style11
    {
    }
        .style12
        {
            height: 27px;
        }
        .style13
        {
            width: 373px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td>
                            <table align="center" cellpadding="0" cellspacing="0" class="style18" 
                                style="width: 609px; height: 221px; margin-left: 125px;">
                                <tr>
                                    <td align="center" class="style13">
                                        <asp:Label ID="lbl_home" runat="server"></asp:Label>
                                        <br />
                                        &nbsp;</td>
                                    <td align="center" rowspan="4">
                                        <table cellpadding="0" cellspacing="0" class="style10" align="center" 
                                            border="1" style="color: #FFFFFF">
                                            <tr>
                                                <td class="style11" colspan="2">
                                                    SERVICE REQUESTS</td>
                                            </tr>
                                            <tr>
                                                <td class="style11">
                                                    REQUESTS COMPLETED</td>
                                                <td class="style11">
                                                    <asp:LinkButton ID="lbl_CMPTD" runat="server" onclick="lbl_CMPTD_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style11">
                                                    REQUESTS PENDING</td>
                                                <td>
                                        <asp:LinkButton ID="lbl_PNDNG" runat="server" onclick="lbl_PNDNG_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style12">
                                                    REQUESTS ASSIGNED</td>
                                                <td class="style12">
                                        <asp:LinkButton ID="lbl_ASSGN" runat="server" onclick="lbl_ASSGN_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style11">
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style13">
                                        <asp:GridView ID="GDV" runat="server" Width="172px" AutoGenerateColumns="False">
                                        <Columns>
                                        <asp:BoundField DataField="Emp_id" HeaderText="Id" />
                                        <asp:BoundField DataField="Type" HeaderText="Type" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" />
                                        
                                        </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style13">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style13">
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

