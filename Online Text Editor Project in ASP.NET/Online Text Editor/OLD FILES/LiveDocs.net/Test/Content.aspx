<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="LiveDocs.net.Test.Content" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing purposes only!</title>
    <link rel="stylesheet" type="text/css" href="~/Styles.css"/>
    
    <script src="jquery-1.7.1.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="LiveDocs.js"></script>
</head>

<body>
    <form id="form1" runat="server">
     <!-- <asp:Menubar ID="Menubar" runat="server" /> -->
    <ajaxToolkit:HtmlEditorExtender runat="server" TargetControlID="TextBox1">
    </ajaxToolkit:HtmlEditorExtender>
    
        <asp:TextBox ID="TextBox1" runat="server" Columns="100" Height="500px" 
         Rows="50" Width="800px"></asp:TextBox>
    <asp:ScriptManager ID="Scriptmanager1" runat="server" EnablePageMethods="True"></asp:ScriptManager>
    
    </form>
</body>
</html>
