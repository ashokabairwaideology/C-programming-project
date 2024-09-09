<%@ Page Language="C#" MasterPageFile="~/Network Engineer/Network engineer.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Network_Engineer_home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
    {
        margin-left: 71px;
        margin-top: 2px;
    }
    .style19
    {
        width: 615px;
            height: 272px;
            margin-left: 230px;
        }
    .style20
    {
        width: 217px;
            height: 270px;
        }
        .style21
        {
            width: 553px;
        }
        .style23
        {
            width: 101%;
            height: 245px;
            margin-left: 0px;
            margin-right: 0px;
        }
        .style28
        {
            height: 270px;
            width: 276px;
        }
        .style30
        {
            height: 15px;
        }
        .style32
        {
            width: 100%;
        }
        .style33
        {
            width: 102px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td class="style21">
                            <table align="center" cellpadding="0" cellspacing="0" class="style18">
                                <tr>
                                    <td align="center" class="style28">
                                        <table cellpadding="0" cellspacing="0" class="style32">
                                            <tr>
                                                <td>
                                        <asp:Label ID="lbl_home" runat="server" ForeColor="White"></asp:Label>
                                                &nbsp;<asp:LinkButton ID="lbl_PNDNG0" runat="server" onclick="lbl_PNDNG_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;<asp:GridView ID="GDV" runat="server" Width="197px" 
                                                        AutoGenerateColumns="False" ForeColor="White" style="margin-left: 0px">
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
                                    <td align="center" class="style20">
                                        <table cellpadding="0" cellspacing="0" class="style23" border="1" 
                                            style="color: #FFFFFF; margin-top: 0px;">
                                            <tr>
                                                <td colspan="2" class="style30" valign="top">
                                                    SERVICE REQUEST</td>
                                            </tr>
                                            <tr>
                                                <td class="style33">
                                                    Open Requests</td>
                                                <td>
                                        <asp:LinkButton ID="lbl_PNDNG" runat="server" onclick="lbl_PNDNG_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style33">
                                                    Closed Request</td>
                                                <td>
                                        <asp:LinkButton ID="lbl_CMPLTD" runat="server" onclick="lbl_CMPLTD_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            </table>
                                    </td>
                                </tr>
                                </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

