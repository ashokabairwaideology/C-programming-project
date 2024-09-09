<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPublicDocument.aspx.cs" Inherits="LiveDocs.pages.pub.ViewPublicDocument" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LiveDocs 1.0 Beta - Public document #DOC TITLE#</title>
    <script src="../res/scripts/JQuery/jquery-1.4.4.js" type="text/javascript"></script>
    <script src="../res/scripts/JQuery/jquery-ui-1.8.18.js" type="text/javascript"></script>
    <link href="../res/jquerythemes/ui-lightness/jquery-ui-1.8.18.custom.css" rel="stylesheet"
        type="text/css" />
</head>
<script type="text/javascript">
    $(document).ready(function () {
        $("#PublicDocumentDialog").dialog({
            autoOpen: false
        });
        PageMethods.IsFullPublic(ShowPasswordDialog, ActionFailed);
    });

    function ShowPasswordDialog(isFullyPublic) {
        if (!isFullyPublic) {
            $("#PublicDocumentDialog").dialog({
                buttons: {
                    "Submit": function() {
                        SubmitPublicPassword();
                    },
                    Cancel: function() {
                        $(this).dialog("close");
                    }
                }
            });

            $("#PublicDocumentDialog").html("Publically shared password: <input id=\"PublicPassword\" type=\"password\" \>");
            $("#PublicDocumentDialog").dialog("open");
        } else {
            PageMethods.FetchPublicContent("", DocumentFetchSuccess, ActionFailed);

        }
    }

    function ActionFailed(ex) {
        alert("Exception: "+ex.toString());
    }
    
    function SubmitPublicPassword() {
        PageMethods.FetchPublicContent($("#PublicPassword").val(), DocumentFetchSuccess, ActionFailed);
    }

    function DocumentFetchSuccess(Content) {
        
        $("#DocumentPlaceHolder").html(Content);
        $("#PublicDocumentDialog").dialog("close");
    }
</script>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" EnablePageMethods="True" runat="server">
        <Scripts>
            
                </Scripts>
                </asp:ScriptManager>
    <div id="DocumentPlaceHolder">
    </div>
    <div id="PublicDocumentDialog" title="Public document"></div>
    </form>
</body>
</html>
