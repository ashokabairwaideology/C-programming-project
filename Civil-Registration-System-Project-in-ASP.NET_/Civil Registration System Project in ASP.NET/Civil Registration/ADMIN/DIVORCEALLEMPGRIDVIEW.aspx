﻿<%@ Page Language="C#" MasterPageFile="~/ADMIN/ADMINMasterPage.master" AutoEventWireup="true" CodeFile="DIVORCEALLEMPGRIDVIEW.aspx.cs" Inherits="ADMIN_DIVORCEALLEMPGRIDVIEW" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:HyperLinkField HeaderText="Action" Text="edit" DataNavigateUrlFields="SINO" DataNavigateUrlFormatString="DIVORCEeditPROFILE.aspx?SINO={0}" />
                <asp:HyperLinkField HeaderText="Action" Text="delete" DataNavigateUrlFields="SINO" DataNavigateUrlFormatString="Divdelectprofilet.aspx?SINO={0}" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

