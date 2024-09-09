$(document).ready(function () {
    $("#DocumentListDialog").dialog({
        autoOpen: false,
        show: "blind",
        hide: "blind",
        minWidth: 400
    });
});


/*
String array
0 - ID
1 - Title
2 - isPublished (Sent as 1 for true, 0 for false)
3 - Published Permalink (if isPublished is false, this is null. May cause index out of bounds exception)
*/

function ResetDialog() {
    $("#DocumentListDialog").dialog('option', 'buttons', {

});
}
var DocumentInfo = null;


function DocumentListGetDocInfo(docID, successFunc) {
    
    $("#DocumentListDialog").html("Fetching document info...");
    $("#DocumentListDialog").dialog('open');
    
    PageMethods.GetDocumentInfo(docID, successFunc, DocInfoFail);
}

function DocInfoSuccessTest(Result) {
    if (Result == null) {
        $("#DocumentListDialog").html("Document does not exist, or you do not have access to it.");
    }
}

function DocInfoFail(ex) {
    DocumentInfo = null;
}

function DocActionFail(ex) {
    $("#DocumentListDialog").html("Action failed. Please contact support.");
}


function DocumentListEditPermissions(docID) {
    ResetDialog();
    $("#DocumentListDialog").html("Loading sharing settings...");
//    $("#DocumentListDialog").title("Document sharing settings");
    $("#DocumentListDialog").dialog("open");
    $('#DocumentListDialog').load('DocumentSharing.aspx?docID=' + docID);
    $('#DocumentListDialog').load('DocumentSharing.aspx?docID=' + docID);
   
}

function DocumentListPublishSettings(DocumentInfo) {
    if (DocumentInfo != null) {
        if (DocumentInfo[2] == 0) {
            $("#DocumentListDialog").dialog('option', 'buttons', {
                "Publish": function () {
                        DocumentListConfirmPublish(DocumentInfo[0]);
                    },
                    Cancel: function () {
                        $(this).dialog("close");
                    }
            });
            

            $("#DocumentListDialog").html("The document <b>" + DocumentInfo[1] + "</b> has not yet been published.<br>"
                + "Do you wish to add a shared password? Leave blank for public access<br>" +
                "<input type=\"text\" id=\"DocListPublishPassword\" /><br><br>" +
                "<input type=\"button\" onclick=\"DocumentListConfirmPublish(" + DocumentInfo[0] + ")\" value=\"Publish\"");
        } else if (DocumentInfo[2] == 1) {
           $("#DocumentListDialog").dialog('option', 'buttons', {
                    "Unpublish": function () {
                        DocumentListConfirmRemovePublish(DocumentInfo[0]);
                    },
                    Cancel: function () {
                        $(this).dialog("close");
                    }
            });
            $("#DocumentListDialog").html("The following document is published: <b>" + DocumentInfo[1] + "</b><br><br>" +
            "Permalink: " + DocumentInfo[3] + "<br><br>" +
            "<input type=\"button\" onclick=\"DocumentListConfirmRemovePublish(" + DocumentInfo[0] + ")\" value=\"Remove public viewing\"");
        }
    }
}


function DocumentSharingAddUser() {
    var username = $("#AddUserTextbox").val();
    var level = $("#SharingAddUserLevel").val();
    PageMethods.SharingAddUser(username, $("#SharingAddUserDocID").val(),level,  DocumentSharingUserAdded, DocumentSharingUserFailed);
}

function DocumentSharingUserAdded(docID) {
    if (docID == -1)
        DocumentSharingUserFailed();
    else {
        DocumentListEditPermissions(docID); //UpdateList
        $("#DocumentListDialog").html($("#DocumentListDialog").html()+"<br>User added!");
    }
}

function DocumentSharingUserFailed(ex) {
    $("#DocumentListDialog").html("Action failed. Contact support");
}
function DocumentListConfirmPublish(docID) {
    PageMethods.PublishDocument(docID, $("#DocListPublishPassword").val(), true, DocumentPublishSuccess, DocActionFail);
    $("#DocumentListDialog").html("Publishing document...");
    $("#DocumentListDialog").dialog({
        buttons: {}
    });
    
}

function DocumentPublishSuccess(docID) {
    $("#DocumentListDialog").html("The document has been published! Copy and share the following link: <a href=\"/public/ViewPublicDocument.aspx?id=" + docID + "\">livedocs.net/public/ViewPublicDocument.aspx?id=" + docID + "</a>");
    ResetDialog();
    $("#DocumentListDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
}

function DocumentListConfirmRemovePublish(docID) {
    $("#DocumentListDialog").html("Making document private again...");
    ResetDialog();
    $("#DocumentListDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
    PageMethods.PublishDocument(docID, "", false,DocumentRemovePublishSuccess, DocActionFail);
}
function DocumentRemovePublishSuccess() {
    $("#DocumentListDialog").html("The document is no longer public");
    ResetDialog();
    $("#DocumentListDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
}
function DocumentListRevokeMyPermissions(DocumentInfo) {
    $("#DocumentListDialog").html("Are you sure you wish to revoke your rights to this document?<br/>" +
        "This will not delete the document itself. Only remove it from your list.");
    $("#DocumentListDialog").dialog('option', 'buttons', {
                    "Yes": function () {
                        DocumentListConfirmRevokeMyPermissions(DocumentInfo[0]);
                        $(this).dialog("close");
                    },
                    Cancel: function () {
                        $(this).dialog("close");
                    }
                });
            }

function DocumentListConfirmRevokeMyPermissions(docID) {
    PageMethods.RevokePermissions(docID, DocRevokeMyPermissionsSuccess, DocActionFail);
}

function DocRevokeMyPermissionsSuccess() {
    $("#DocumentListDialog").html("Permissions have been revoked");
    location.reload(true);
    ResetDialog();
    $("#DocumentListDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
}
function DocumentListDelete(DocumentInfo) {
     $("#DocumentListDialog").dialog('option', 'buttons', {
                    "Yes": function () {
                        DocumentListConfirmDelete(DocumentInfo[0]);
                        $(this).dialog("close");
                    },
                    Cancel: function () {
                        $(this).dialog("close");
                    }
                });
    $("#DocumentListDialog").html("Are you sure you wish to delete document: <b>" + DocumentInfo[1] + "</b>?<br><br>");
}

function DocumentListConfirmDelete(docID) {
    PageMethods.DeleteDocument(docID, DocDeleteSuccess, DocActionFail);
}

function DocDeleteSuccess() {
    $("#DocumentListDialog").html("Document has been deleted");
    location.reload(true);
    ResetDialog();
    $("#DocumentListDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
}

function DocumentListCreateDocument() {
    $("#DocumentListDialog").dialog({
        buttons: {
            "Create": function () {
                if ($("#DocListDocumentTitle").val() == "") {
                    PageMethods.CreateDocument("Default", DocumentListDocumentCreated, DocActionFail);
                }
                else {
                    PageMethods.CreateDocument($("#DocListDocumentTitle").val(), DocumentListDocumentCreated, DocActionFail);
                }
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });
        $("#DocumentListDialog").html("Document title: " +
            "<input type=\"text\" id=\"DocListDocumentTitle\" />");
        $("#DocumentListDialog").dialog("open");
}

function DocumentListDocumentCreated(docID) {
    $("#DocumentListDialog").html("The document has been created!");
       $("#DocumentListDialog").dialog('option', 'buttons', {
                    "Back to documents": function () {
                        window.location.reload();
                    },
                    "Open document": function () {
                        window.location.href = "/livedocs/edit/Editor.aspx?id=" + docID;
                    }
    });
            }
function DocumentRename(docID) {
    PageMethods.GetDocumentInfo(docID, function(value) {
        $("#DocumentListDialog").html("Rename document<br><input id=\"documentName\" value=\"" + value[1] + "\" type=\"text\"/><br>");
        $("#DocumentListDialog").dialog({
            buttons: {
                "Ok": function() {
                    if ($("#documentName").val() != value[1]) {
                        PageMethods.RenameDocument($("#documentName").val(), docID, function () { location.reload(); });
                    }
                    $(this).dialog("close");
                },
                "Cancel": function() { $(this).dialog("close"); }
            }
        });
        $("#DocumentListDialog").dialog("open");
    });
}


