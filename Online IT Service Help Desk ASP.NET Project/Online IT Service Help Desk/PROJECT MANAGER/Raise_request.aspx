<%@ Page Language="C#" MasterPageFile="~/PROJECT MANAGER/Project_manager.master" AutoEventWireup="true" CodeFile="Raise_request.aspx.cs" Inherits="PROJECT_MANAGER_Raise_request" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style13
        {
            width: 59%;
        }
    .style18
    {
        width: 50%;
        height: 246px;
            margin-left: 0px;
            margin-right: 0px;
        }
        .style20
        {
            height: 38px;
        }
    .style19
    {
        width: 98px;
    }
        .style21
        {
            width: 168px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style13">
        <tr>
            <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style18">
                <tr>
                    <td align="center" colspan="3" 
                        
                        style="font-family: Rockwell; font-size: x-large; color: #FF9933; text-decoration: overline" 
                        class="style20">
                        Raise Request</td>
                </tr>
                <tr>
                    <td class="style21">
                        Emp ID</td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_empid" runat="server" 
                            ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        Request for</td>
                    <td colspan="2">
                        <asp:DropDownList ID="Dr_requestfor" runat="server">
                            <asp:ListItem>Software</asp:ListItem>
                            <asp:ListItem>Hardware</asp:ListItem>
                            <asp:ListItem>Network</asp:ListItem>
                            <asp:ListItem>Operating System</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        Request Description</td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_rqstdscrptn" runat="server" TextMode="MultiLine" 
                            Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        &nbsp;</td>
                    <td colspan="2">
                        <asp:Label ID="lb_rqst" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        &nbsp;</td>
                    <td class="style19">
                        <asp:Button ID="snd_rqst" runat="server" onclick="snd_rqst_Click" 
                            Text="Send Request" Width="99px" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style21">
                        &nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
            </table>
            </td>
        </tr>
    </table>
</asp:Content>

