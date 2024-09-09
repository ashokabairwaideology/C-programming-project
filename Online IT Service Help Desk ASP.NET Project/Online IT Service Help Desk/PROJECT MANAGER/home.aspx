<%@ Page Language="C#" MasterPageFile="~/PROJECT MANAGER/Project_manager.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="PROJECT_MANAGER_home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style18
        {
            height: 276px;
            width: 775px;
            margin-left: 0px;
            margin-right: 0px;
        }
        .style19
        {
            width: 42px;
            margin-left: 204px;
        }
        .style21
        {
            width: 438px;
        }
        .style23
        {
            width: 512px;
        }
        .style24
        {
            height: 98px;
            width: 512px;
        }
        .style25
        {
            width: 100%;
        }
        .style26
        {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
&nbsp;&nbsp;&nbsp;
<table align="center" cellpadding="0" cellspacing="0" class="style18">
        <tr>
            <td>
                <table align="center" cellpadding="0" cellspacing="0" class="style19">
                    <tr>
                        <td>
                            <table align="center" cellpadding="0" cellspacing="0" class="style18">
                                <tr>
                                    <td align="center" class="style23">
                                        <asp:Label ID="lbl_home" runat="server" Visible="False" ForeColor="White"></asp:Label>
                                    </td>
                                    <td align="center" class="style21">
                                        <table border="1" class="style25" style="color: #FFFFFF">
                                            <tr>
                                                <td class="style26" colspan="2">
                                                    SERVICE REQUESTS</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Requests Completed</td>
                                                <td>
                                        <asp:LinkButton ID="lbl_CMPLTD" runat="server" onclick="lbl_CMPLTD_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" colspan="2" style="color: #00FF00">
                                                    Pending Request</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    Approved by N.M</td>
                                                <td>
                                                    Rejected by N.M</td>
                                            </tr>
                                            <tr>
                                                <td>
                                        <asp:LinkButton ID="lbl_ANM" runat="server" onclick="lbl_ANM_Click"></asp:LinkButton>
                                                </td>
                                                <td>
                                        <asp:LinkButton ID="lbl_RNM" runat="server" onclick="lbl_RNM_Click"></asp:LinkButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style24">
                                        <asp:GridView ID="GDV" runat="server" Visible="False" 
                                            AutoGenerateColumns="False" ForeColor="White">
                                        <Columns>
                                        <asp:BoundField DataField="Emp_id" HeaderText="Id" />
                                        <asp:BoundField DataField="Type" HeaderText="Type" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" />
                                        
                                        </Columns>
                                        </asp:GridView>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style23">
                                        </td>
                                </tr>
                                <tr>
                                    <td align="center" class="style23">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center" class="style23">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center" class="style23">
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

