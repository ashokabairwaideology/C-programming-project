
$(document).ready(function () {
    $("#forgottenPasswordDialog").dialog({
        autoOpen: false,
        show: "blind",
        hide: "blind"
    });


});

function openForgottenPasswordDialog() {
    $("#forgottenPasswordDialog").dialog("open");
}
function ResetPassword() {
    LiveDocs.services.ResetPassword.SendResetPasswordMail($('#ResetPasswordEmailTextbox').val(),ResetPasswordSuccess);
}

function ResetPasswordSuccess(Result) {
    
    if (Result == true)
        $("#forgottenPasswordDialog").html("Password has been sent to " + $('#ResetPasswordEmailTextbox').val());
    else {
        $("#forgottenPasswordDialog").html("Invalid email, or email does not exist in database");
    }
}