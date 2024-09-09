<%@ Page Language="C#" MasterPageFile="~/Employees/Emp_master.master" AutoEventWireup="true" CodeFile="Book_Advt.aspx.cs" Inherits="Employees_Book_Advt" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            width: 72%;
            height: 364px;
        }
        .style11
        {
            font-size: x-large;
            color: #FF00FF;
            text-transform: uppercase;
            font-style: italic;
            font-weight: bold;
        }
        .style12
        {
        }
        .style13
        {
            width: 223px;
            height: 19px;
        }
        .style14
        {
            height: 19px;
        }
        .style18
        {
            font-size: large;
            font-style: italic;
            font-weight: bold;
        }
        .style19
        {
            height: 19px;
            font-style: italic;
            font-weight: bold;
            font-size: large;
        }
        .style20
        {
            height: 18px;
            font-style: italic;
            font-weight: bold;
            font-size: large;
        }
        .style21
        {
            font-size: large;
            font-style: italic;
            font-weight: bold;
            width: 223px;
        }
        .style22
        {
            height: 18px;
            font-style: italic;
            font-weight: bold;
            font-size: large;
            width: 223px;
        }
        .style23
        {
            height: 19px;
            font-style: italic;
            font-weight: bold;
            font-size: large;
            width: 223px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" cellpadding="0" cellspacing="0" class="style10">
        <tr>
            <td align="center" colspan="2" class="style11">
                <br />
                Book Your Advertisement here<br />
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style13">
                <b><i>&nbsp;</i></b><span class="style6"> </span><span class="style18">Select Desired page Code<br />
                </span></td>
            <td align="left" class="style14">
                <asp:DropDownList ID="ddl_addcod" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddl_addcod_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style21">
                PageNo:<asp:TextBox ID="txt_pno" runat="server" Width="145px"></asp:TextBox>
                <br />
            </td>
            <td align="left" class="style18">
                PageLocation:<asp:TextBox ID="txt_plocation" runat="server"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style21">
                Advertisement Description:</td>
            <td align="left" class="style18">
                <br />
                <asp:TextBox ID="txt_advtdesc" runat="server" TextMode="MultiLine"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td  align="center" class="style18" colspan="2">
                <br />
                select the Publishing Date below 
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style22">
                Date of&nbsp;&nbsp; Publish<br />
            </td>
            <td align="left" class="style20">
                <asp:TextBox ID="txt_Dateofpublish" runat="server" Height="36px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style21">
            
                <br />
            </td>
            <td class="style18">
                <asp:RadioButtonList ID="rb_cost" runat="server" Visible="False">
                </asp:RadioButtonList>
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style23">
                Enter total cost sq/cm:<br />
            </td>
            <td  align="left" class="style19">
                <asp:TextBox ID="txt_totalcost" runat="server"></asp:TextBox>
                <br />
                <br />
                </td>
        </tr>
        <tr>
            <td align="center" class="style18" colspan="2">
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Clicl here to get totalcost</asp:LinkButton>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style21">
                Total Advt Cost in Rs/-:<br />
            </td>
            <td align="left" class="style18">
                <asp:TextBox ID="txt_totalAdvtCost" runat="server" Height="22px"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td align="right" class="style12" colspan="2">
                <asp:Button ID="Button1" runat="server"  
                    style="font-size: large; font-weight: 700; font-style: italic" 
                    Text="Book Advertisement" onclick="Button1_Click" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style12" colspan="2">
                <asp:LinkButton ID="LinkButton2" runat="server">Show Advt Details</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>

