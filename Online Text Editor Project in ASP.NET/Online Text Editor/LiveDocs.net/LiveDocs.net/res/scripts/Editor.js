
var firstRequest = true;
$(document).ready(function () {
    $("#MainContentPlaceHolder_InnerWrapperRevisions").css("visibility", "hidden");
    $("#DocumentListDialog").dialog({
        autoOpen: false,
        show: "blind",
        hide: "blind",
        minWidth: 400
    });
    
    PageMethods.CurrentDocumentInfo(DocumentInfoSuccess, DocumentInfoFail);
    PageMethods.CheckPageQuery(CheckPageQuerySuccess, CheckPageQueryFail);

    if (firstRequest) { //Load content on first document visit
        PageMethods.FetchPageContent(insertMarkup);
        firstRequest = false;
    }
    /*
    DDMenu
    */
    $("#top-nav li").hover(function () {
        $("ul", this).show();
        $("a.top-nav-list", this).addClass('selected');

    }, function () {
        $("ul", this).hide();
        $("a.top-nav-list", this).removeClass('selected');
    });

    
});

var docID;
var revID;
var highestRevision;
function DocumentInfoSuccess(Result) {
    docID = Result[0];
    revID = Result[1];
    highestRevision = Result[2];
    EditorPreventEditingOldRevision();
}

function DocumentInfoFail(ex) {
    alert(ex);
}

function EditorCheckoutRevision() {
//    $("#MainContentPlaceHolder_InnerWrapperRevisions").css("visibility", "visible");
    $("#EditorDialog").dialog({
        buttons: {}
    });

    $("#EditorDialog").html($("#MainContentPlaceHolder_InnerWrapperRevisions").html());
    $("#EditorDialog").dialog("open");
}

function EditorCommitRevision() {
    $("#EditorDialog").dialog({
        buttons: {
            "Commit": function () {
                EditorConfirmCommitRevision();
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });
    $("#EditorDialog").html("Do you wish to commit this revision?" +
    "<table><tr><td>Commit name</td><td><input id=\"EditorCommitName\" type=\"text\" value=\"r" + highestRevision + "\" /></td></tr>" +
    "<tr><td>Commit message</td><td><input id=\"EditorCommitMessage\" type=\"text\" /></td></tr></table>");
    $("#EditorDialog").dialog("open");
}


function EditorCommitBasedOnOldRevision() {
    $("#EditorDialog").dialog({
        buttons: {
            "Commit": function () {
                EditorConfirmCommitBasedOnOldRevision();
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        }
    });
    var newRevNameSuggestion = parseInt(highestRevision) + 1;
    $("#EditorDialog").html("How do you wish to save the new revision?" +
    "<table><tr><td>Commit name</td><td><input id=\"EditorCommitName\" type=\"text\" value=\"r" + newRevNameSuggestion + "\" /></td></tr>" +
    "<tr><td>Commit message</td><td><input id=\"EditorCommitMessage\" type=\"text\" /></td></tr></table>");
    $("#EditorDialog").dialog("open");
}

function EditorConfirmCommitRevision() {
    PageMethods.CommitRevision(revID, $("#EditorCommitName").val().toString(), $("#EditorCommitMessage").val().toString(), false,EditorRevisionCommited, EditorRevisionCommitFail);
    $("#EditorDialog").html("Commiting revision...");
    $("#EditorDialog").dialog({
        buttons: {}
    });
}
function EditorConfirmCommitBasedOnOldRevision() {
    PageMethods.CommitRevision(revID, $("#EditorCommitName").val().toString(), $("#EditorCommitMessage").val().toString(),true, EditorRevisionCommited, EditorRevisionCommitFail);
    $("#EditorDialog").html("Commiting revision...");
    $("#EditorDialog").dialog({
        buttons: {}
    });
}

function EditorRevisionCommited(Result) {
    var newRevisionID = Result;
    $("#EditorDialog").html("Revision commited");
    if (sendToLatestRevision == true) //This occurs when a user has commited an old revision to create a new based on the old. This will send the user to the latest revision
        window.location.href = "/livedocs/edit/Editor.aspx?docID=" + docID;
    else
        window.location.href = "/livedocs/edit/Editor.aspx?revID=" + newRevisionID;
}

function EditorRevisionCommitFail(ex) {
    $("#EditorDialog").html("Revision commit failed. Contact support");
}


function CheckPageQuerySuccess(params)
{
    if (params) 
    {
        doTimer();
    }
}

function CheckPageQueryFail() {
    $("#EditorDialog").dialog("Connection error");
}

//Timer event for document fetching and storing
var c = 0;
var t;
var timer_is_on = false;
var markupBeforeUpdate;
var markupAfterUpdate;
var isUpdatingServer = false; //Determines if server should be written to or read from.
function timedCount() {
    markupBeforeUpdate = $("#MarkupText").val();
    PageMethods.UpdateRevision($("#MarkupText").val(), isUpdatingServer, updateSuccess);
    PageMethods.FetchChatContent(UpdateChatPanel);
    c = c + 1;
    isUpdatingServer = false;
}

function doTimer() {
    if (!timer_is_on) {
        timer_is_on = true;
        timedCount();
    }
}

function updateSuccess(value) {
    markupAfterUpdate = $("#MarkupText").val();
    if (markupAfterUpdate == markupBeforeUpdate) {
        var date = new Date();
        var hours = date.getHours();
        if (hours < 10)
            hours = "0" + hours;
        var minutes = date.getMinutes();
        if (minutes < 10)
            minutes = "0" + minutes;
        var seconds = date.getSeconds();
        if (seconds < 10)
            seconds = "0" + seconds;
        $("#updateRevisionStatus").html("Last updated : " + hours + ":" + minutes + ":<span style=\"color:royalblue\">" + seconds + "</span>");
        t = setTimeout("timedCount()", 500);
        insertMarkup(value);
        updateOutput();
    }
}

//Fired onkeyup on editor to update view
function markupChanged() {
    clearTimeout(t);
    isUpdatingServer = true;
    updateOutput();
    t = setTimeout("timedCount()", 500);
}

function updateOutput() {
    PageMethods.ParseMarkup($("#MarkupText").val(), insertHtml);
}
function insertHtml(value) {
    $("#HtmlText").html(value);
}

function insertMarkup(value) {
    var textarea = document.getElementById("MarkupText");
    if(textarea==null) {
        return;
    }
    $("#MarkupText").val(value);
}


function buttonClick(command) {
    switch (command) {
        case 'Bold':
            insertTag('<b>', '</b>');
            break;
        case 'Italic':
            insertTag('<i>', '</i>');
            break;
        case 'Underline':
            insertTag('<u>', '</u>');
            break;
        case 'Subscript':
            insertTag('<sub>', '</sub>');
            break;
        case 'Superscript':
            insertTag('<sup>', '</sup>');
            break;
        case 'Strikethrough':
            insertTag('<del>', '</del>');
            break;
        case '1':
            insertTag('<1>', '</1>');
            break;
        case '2':
            insertTag('<2>', '</2>');
            break;
        case '3':
            insertTag('<3>', '</3>');
            break;
        case '4':
            insertTag('<4>', '</4>');
            break;
        case '5':
            insertTag('<5>', '</5>');
            break;
        case '6':
            insertTag('<6>', '</6>');
            break;
        case '7':
            insertTag('<7>', '</7>');
            break;
        case '8':
            insertTag('<8>', '</8>');
            break;
        case '9':
            insertTag('<9>', '</9>');
            break;
        case '10':
            insertTag('<10>', '</10>');
            break;
        case 'Arial':
            insertTag('<arial>', '</arial>');
            break;
        case 'Comic Sans MS':
            insertTag('<comic>', '</comic>');
            break;
        case 'Courier':
            insertTag('<courier>', '</courier>');
            break;

        default:
    }
}

function insertTag(startTag, endTag) {
    var textarea = document.getElementById("MarkupText");
    if (document.selection) { //IE
        textarea.focus();
        var sel = document.selection.createRange();
        sel.text = startTag + sel.text + endTag;
    }
    else { //Mozilla
        var len = textarea.value.length;
        var start = textarea.selectionStart;
        var end = textarea.selectionEnd;


        var sel = textarea.value.substring(start, end);
        var replace = startTag + sel + endTag;
        textarea.value = textarea.value.substr(0, start) + replace + textarea.value.substr(end, len);

        if (start == end) { //Placement of caret on empty selection.

            var pos = textarea.value.substr(0, start).length + startTag.length;
            setCaretPosition("MarkupText", pos);
        }
    }
    markupChanged();
}

//Code from http://stackoverflow.com/questions/512528/set-cursor-position-in-html-textbox
function setCaretPosition(elemId, caretPos) {
    var elem = document.getElementById(elemId);

    if (elem != null) {
        if (elem.createTextRange) {
            var range = elem.createTextRange();
            range.move('character', caretPos);
            range.select();

        }
        else {
            if (elem.selectionStart) {
                elem.focus();
                elem.setSelectionRange(caretPos, caretPos);
            }
            else
                elem.focus();
        }
    }
}

var sendToLatestRevision = false;
function EditorOpenModalOldRevisionDialog() {
    $("#EditorDialog").html("You are about to edit an old revision. Doing this will create a new revision based on the old one. Do you wish to proceed?");
    $("#EditorDialog").dialog({
        buttons: {
            "Create new revision": function () {
                $(this).dialog("close");
                sendToLatestRevision = true;
                EditorCommitBasedOnOldRevision();
            },
            "Open read-only": function () {
                $("#MarkupText").attr("disabled", "disabled");
                $(this).dialog("close");
            }
        },
        modal: true
    });
    $("#EditorDialog").dialog("open");

}

function EditorPreventEditingOldRevision() {
    if(highestRevision > revID) {
        //Old revision. Prevent craziness!
        EditorOpenModalOldRevisionDialog();
    }
}

//Open dialog on file save that prompts for document name

function saveAsFile(requestID) {
    $("#EditorDialog").html("Type in filename.<br><input id=\"documentInput\" value=\"Document.doc\"></input>");
    $("#EditorDialog").dialog({
        show: "slide",
        title: "Save to File",
        buttons: { 
                "Ok": function () {
                    window.location.href = "/livedocs/ExportDocument.aspx?revID=" + requestID + "&docName=" + $("#documentInput").val();
                    $(this).dialog("close");
                }
            }
    });
}
function UpdateChatPanel(chatContent) {
    var prevContent = $("#MainContentPlaceHolder_ChatLog").html();

    if (prevContent != chatContent) {
     $("#MainContentPlaceHolder_ChatLog").html(chatContent);
    ScrollChatToBottomAction();
    }
}
function ScrollChatToBottom() {
    
    setTimeout(function () { ScrollChatToBottomAction(); }, 250);
}
function ScrollChatToBottomAction() {
    
    $("#ChatScrollContainer").attr({ scrollTop: $("#ChatScrollContainer").attr("scrollHeight") });
}
