<%@ Page Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="admin_Home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
    {
        height: 503px;
        width: 711px;
            margin-right: 0px;
        }
    .style19
    {
        width: 865px;
        color: #FF0066;
        font-size: large;
        font-weight: bold;
        height: 79px;
        margin-right: 0px;
            margin-left: 0px;
        }
    .style21
    {
        width: 414px;
        color: #FF0066;
        font-size: large;
        font-weight: bold;
        height: 64px;
    }
        .style23
        {
            width: 101%;
            height: 245px;
            margin-left: 0px;
            margin-right: 0px;
        }
        .style26
        {
            height: 31px;
        }
        .style27
        {
        }
        .style28
        {
            width: 912px;
        }
        .style29
        {
            width: 99%;
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" 
    style="height: 383px; width: 891px" >
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td>
                            <table align="center" cellpadding="0" cellspacing="0" class="style18">
                                <tr>
                                     <td valign="top" align="center" rowspan="4" class="style28">
                                        <table cellpadding="0" cellspacing="0" class="style29">
                                            <tr>
                                                <td>
                                        <asp:Label ID="lbl_home" runat="server" ForeColor="White"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:GridView ID="GDV" runat="server" AutoGenerateColumns="False" 
                                            ForeColor="White">
                                        <Columns>
                                        <asp:BoundField DataField="Emp_id" HeaderText="Id" />
                                        <asp:BoundField DataField="Type" HeaderText="Type" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" />
                                        
                                        </Columns>
                                        </asp:GridView>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style21" style="color: #FFFFFF">
                                        <table cellpadding="0" cellspacing="0" class="style23" border="1" 
                                            style="color: #FFFFFF; margin-top: 0px;">
                                            <tr>
                                                <td colspan="4" class="style26" valign="top">
                                                    SERVICE REQUESTS</td>
                                            </tr>
                                            <tr>
                                                <td class="style26" colspan="2">
                                                    Open Requests</td>
                                                <td colspan="2" class="style26">
                                        <asp:LinkButton ID="lbl_POST" runat="server" onclick="lbl_POST_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style27" colspan="2">
                                                    Closed Request</td>
                                                <td colspan="2">
                                        <asp:LinkButton ID="lbl_CMPLTD" runat="server" onclick="lbl_CMPLTD_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style27" colspan="4" 
                                                    style="font-size: medium; color: #00FF00;">
                                                    Pending Requests</td>
                                            </tr>
                                            <tr>
                                                <td align="center" class="style27" colspan="2" style="font-size: medium">
                                                    Approved By</td>
                                                <td align="center" class="style27" colspan="2" style="font-size: medium">
                                                    Rejected By</td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style27" style="font-size: medium">
                                                    P.M</td>
                                                <td align="left" class="style27" style="font-size: medium">
                                                    N.M</td>
                                                <td align="left" class="style27" style="font-size: medium">
                                                    P.M</td>
                                                <td align="left" class="style27" style="font-size: medium">
                                                    N.M</td>
                                            </tr>
                                            <tr>
                                                <td align="left" class="style27" style="font-size: medium">
                                        <asp:LinkButton ID="lbl_PNM" runat="server" onclick="lbl_PNM_Click"></asp:LinkButton>
                                                </td>
                                                <td align="left" class="style27" style="font-size: medium">
                                        <asp:LinkButton ID="lbl_ANM" runat="server" onclick="lbl_ANM_Click"></asp:LinkButton>
                                                </td>
                                                <td align="left" class="style27" style="font-size: medium">
                                        <asp:LinkButton ID="lbl_RPM" runat="server" onclick="lbl_RPM_Click"></asp:LinkButton>
                                                </td>
                                                <td align="left" class="style27" style="font-size: medium">
                                        <asp:LinkButton ID="lbl_RNM" runat="server" onclick="lbl_RNM_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
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

