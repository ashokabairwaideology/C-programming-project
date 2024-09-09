<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="viewans.aspx.cs" Inherits="Admin_viewans" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server">
   
    <Columns>
        <asp:HyperLinkField Text="Abused" HeaderText="Abused Reports" DataNavigateUrlFields="ans_id" DataNavigateUrlFormatString="abused.aspx?ans_id={0}" />
            
        </Columns>
        
    </asp:GridView>
</asp:Content>

