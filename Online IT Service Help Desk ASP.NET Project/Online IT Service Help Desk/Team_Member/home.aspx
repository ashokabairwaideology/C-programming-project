<%@ Page Language="C#" MasterPageFile="~/Team_Member/Team_member.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Team_member_home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            width: 103%;
            margin-left: 0px;
        }
        .style19
        {
            width: 57%;
            margin-left: 348px;
        }
        .style21
        {
            width: 355px;
        }
        .style22
        {
            width: 355px;
            height: 7px;
        }
        .style25
        {
            height: 59px;
        }
        .style27
        {
            width: 100%;
        }
        .style28
        {
            width: 69px;
        }
        .style29
        {
            width: 355px;
            height: 133px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18" 
        border="0">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td>
                            <table align="center" cellpadding="0" cellspacing="0" class="style18" 
                                border="0" style="color: #FFFFFF; height: 231px;">
                                <tr>
                                    <td align="center" class="style22">
                                        &nbsp;</td>
                                    <td align="center" class="style25" rowspan="3">
                                        <table border="1" cellpadding="0" cellspacing="0" class="style27">
                                            <tr>
                                                <td colspan="4">
                                                    SERVICE REQUESTS</td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    Requets Posted</td>
                                                <td colspan="2">
                                        <asp:LinkButton ID="lbl_PSTD" runat="server" onclick="lbl_PSTD_Click"></asp:LinkButton>
                                                            </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    Requests Closeed</td>
                                                <td colspan="2">
                                        <asp:LinkButton ID="lbl_CMPLTD" runat="server" onclick="lbl_CMPLTD_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="4" style="color: #00FF00">
                                                    Pending Requests</td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    Approved
                                                </td>
                                                <td colspan="2">
                                                    Rejeccted</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    P.M</td>
                                                <td class="style28">
                                                    N.M</td>
                                                <td>
                                                    P.M</td>
                                                <td>
                                                    N.M</td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:LinkButton ID="lbl_PNM" runat="server" onclick="lbl_PNM_Click"></asp:LinkButton>
                                                </td>
                                                <td class="style28">
                                        <asp:LinkButton ID="lbl_ANM" runat="server" onclick="lbl_ANM_Click"></asp:LinkButton>
                                                </td>
                                                <td>
                                        <asp:LinkButton ID="lbl_RPM" runat="server" onclick="lbl_RPM_Click"></asp:LinkButton>
                                                </td>
                                                <td>
                                        <asp:LinkButton ID="lbl_RNM" runat="server" onclick="lbl_RNM_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                                        </tr>
                                <tr>
                                    <td align="center" class="style22" style="color: #FFFFFF">
                                        <asp:Label ID="lbl_home" runat="server" Visible="False"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td align="center" class="style29" style="color: #FFFFFF">
                                        <asp:GridView ID="GDV" runat="server" AutoGenerateColumns="False">
                                        <Columns>
                                        <asp:BoundField DataField="Emp_id" HeaderText="Id" />
                                        <asp:BoundField DataField="Type" HeaderText="Type" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" />
                                        
                                        </Columns>
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style21">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style21">
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

