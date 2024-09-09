<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Documents.aspx.cs" Inherits="LiveDocs.pages.livedocs.Documents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/res/scripts/DocumentList.js" type="text/javascript"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MenuContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h1>Documents</h1>
    
    <script>
        $(function() {
            $("input:button, a, button", ".demo").button();
            $("a", ".demo").click(function() { return false; });
        });
    </script>

    <div class="demo">
        <input type="button" onclick=" DocumentListCreateDocument() " value="Create new document">
    </div>
        
    <asp:Panel ID="DocumentListControl" runat="server">
    </asp:Panel>
    <div id="DocumentListDialog" title="Document Action"></div>
</asp:Content>