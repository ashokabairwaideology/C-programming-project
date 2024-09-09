$(document).ready(function () {
    
});
//Fired onkeyup on editor to update view
function updateOutput() {
    $('#output').html($('#editor').val());
}

//Inserts complete HTML Tag at editor Caret position
function insertCompleteHtmlTagAtCaret(input)
{
    var selStart = $('#editor').prop("selectionStart");
    var selEnd = $('#editor').prop("selectionEnd");
    console.log(selStart);
    var content = $('#editor').val();
    var beforeSel = content.substring(0, selStart);
    var sel = content.substring(selStart, selEnd);
    var afterSel = content.substring(selEnd, content.length);
    $('#editor').val(beforeSel + '<' + input + '>' + sel + '</' + input + '>' + afterSel);
    updateOutput();
}
//Menubar button clicked

function buttonClick(text) {
    var isBold, isItalic, isUnderline;
    var buttonId = document.getElementById(text).value;

    if (!isBold) {
        $('#' + text).css('border-color', 'Black');
        isBold = true;
    }
    else  {
        $('#' + text).css('border-color', '#00FF00');
        isBold = false;
    }
    switch (buttonId) {
        case "Bold":
            insertCompleteHtmlTagAtCaret('b');
            break;
        case "Italic":
            insertCompleteHtmlTagAtCaret('i');
            break;
        case "Underline":
            insertCompleteHtmlTagAtCaret('u');
            break;
        default:
            alert("Error in buttonClick()");
    }
}