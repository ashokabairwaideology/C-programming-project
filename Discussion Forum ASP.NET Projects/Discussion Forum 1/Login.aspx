<%@ Page Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="home" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        height: 100%;
        width:100%;
        
    }
        .style12
        {
            font-size: xx-large;
            font-weight: bold;
            font-family: Playbill;
        }
        .style13
        {
            height: 50px;
        }
        .style27
        {
            width: 325px;
        }
        .style28
        {
            height: 51px;
        }
        .style29
        {
            height: 53px;
        }
        .style31
        {
            height: 165px;
        }
        .style32
        {
            height: 53px;
            width: 132px;
        }
        .style33
        {
            height: 50px;
            width: 132px;
        }
        .style34
        {
            height: 51px;
            width: 132px;
        }
        .style35
        {
            height: 165px;
            width: 132px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table 
        class="style1" bgcolor="#FF66FF">
        <tr>
            <td align="center" class="style13" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style27" valign="top">
                <asp:Image ID="Image2" runat="server" Height="342px" 
                    ImageUrl="~/Images/flipboard_discussion_pc_image_500_clr.png" 
                    Width="320px" />
            </td>
            <td>
                <table class="style1">
                    <tr>
                        <td class="style32">
            <asp:Label ID="Label3" runat="server" Text="UserName" 
                style="font-size: large; font-weight: 700"></asp:Label>
                        &nbsp;<b>:</b></td>
                        <td class="style29">
            <asp:TextBox ID="txt_login" runat="server" Height="32px" Width="154px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style33">
            <asp:Label ID="Label4" runat="server" Text="Password" 
                style="font-size: large; font-weight: 700"></asp:Label>
                        &nbsp;<b>:</b></td>
                        <td class="style13">
            <asp:TextBox ID="txt_pswd" runat="server" TextMode="Password" Height="30px" 
                Width="154px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style34">
                            </td>
                        <td class="style28">
            <asp:Button ID="Button2" runat="server" onclick="Button1_Click" Text="LOGIN" 
                Height="41px" style="font-weight: 700; font-size: x-large" Width="117px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style35">
                            </td>
                        <td class="style31" valign="top">
                            <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/forget.aspx">Forget 
                            Password?</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

