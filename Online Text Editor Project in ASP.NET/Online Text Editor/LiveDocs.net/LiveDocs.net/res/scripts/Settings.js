function SetUsername(input) { //If input is present
    if (!input) {
        $("#ChangeUsernameDialog").attr("title", "Change mail");
        $("#ChangeUsernameDialog").html("Select a new email.<br>(6 characters minimum).<br><input id=\"usernameInput\" type=\"text\"></input>");
        $("#ChangeUsernameDialog").dialog({ show: { effect: 'slide', direction: "up"} });
        $("#ChangeUsernameDialog").dialog({ buttons: {
            "Ok": function () {
                if ($("#usernameInput").val().length < 6) {
                    $("#ChangeUsernameDialog").html("Mail must be atleast 6 characters.<br><input id=\"usernameInput\" type=\"text\"></input>");
                }
                else {
                    PageMethods.SettingsSetUsername($("#usernameInput").val(), SettingsSetUsernameSuccess);
                }

            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
        });
}
else {
    $("#ChangeUsernameDialog").attr("title", "Change mail");
    $("#ChangeUsernameDialog").html("Select mail<br>(6 characters minimum).<br><input id=\"usernameInput\" type=\"text\"></input>");
    $("#ChangeUsernameDialog").dialog({ show: { effect: 'slide', direction: "up"} });
    $("#ChangeUsernameDialog").dialog({ buttons: {
        "Ok": function () {
            if ($("#usernameInput").val().length < 6) {
                $("#ChangeUsernameDialog").html("Mail must be atleast 6 characters.<br><input id=\"usernameInput\" type=\"text\"></input>");
            }
            else {
               
               PageMethods.SettingsAdminSetUsername($("#usernameInput").val(), input,SettingsSetUsernameSuccess)
            }

        },
        "Cancel": function () {
            $(this).dialog("close");
        }
    }
    });
        
    }

}
function SetUserNick(input) { //If input is present
    if (!input) {
        $("#ChangeUsernameDialog").attr("title", "Change nick");
        $("#ChangeUsernameDialog").html("Select a new nick.<br>(4 characters minimum).<br><input id=\"usernameInput\" type=\"text\"></input>");
        $("#ChangeUsernameDialog").dialog({ show: { effect: 'slide', direction: "up"} });
        $("#ChangeUsernameDialog").dialog({ buttons: {
            "Ok": function () {
                if ($("#usernameInput").val().length < 4) {
                    $("#ChangeUsernameDialog").html("Nick must be atleast 4 characters.<br><input id=\"usernameInput\" type=\"text\"></input>");
                }
                else {
                    PageMethods.SettingsSetUserNick($("#usernameInput").val(),false, SettingsSetUsernameSuccess);
                }

            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
        });
    }
    else {
        $("#ChangeUsernameDialog").attr("title", "Change nick");
        $("#ChangeUsernameDialog").html("Select a new nick<br>(4 characters minimum).<br><input id=\"usernameInput\" type=\"text\"></input>");
        $("#ChangeUsernameDialog").dialog({ show: { effect: 'slide', direction: "up"} });
        $("#ChangeUsernameDialog").dialog({ buttons: {
            "Ok": function () {
                if ($("#usernameInput").val().length < 4) {
                    $("#ChangeUsernameDialog").html("Nick must be atleast 4 characters.<br><input id=\"usernameInput\" type=\"text\"></input>");
                }
                else {
                    PageMethods.SettingsSetUserNick($("#usernameInput").val(), true, SettingsSetUsernameSuccess);
                }

            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
        });

    }

}

function SettingsSetUsernameSuccess(value) {
     if (value) {
                    $(this).dialog("close");
                    location.reload();
                }
                else {
                    $("#ChangeUsernameDialog").html("Could not complete request, is the name a valid email?.<br> If the problem persists contact support.");
                    $("#ChangeUsernameDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
                }
}

function SetUserPassword(value) {
    if(!value) {
        $("#ChangeUsernameDialog").attr("title", "Change password");
        $("#ChangeUsernameDialog").html("Select a new password<br>(6 characters minimum).<br><input id=\"passInput1\" type=\"password\"></input><br>"+
        "<input id=\"passInput2\" type=\"password\"></input>");
        $("#ChangeUsernameDialog").dialog({ show: { effect: 'slide', direction: "up"} });
        $("#ChangeUsernameDialog").dialog({ buttons: {
            "Ok": function () {
            if(($("#passInput1").val())!=($("#passInput2").val())){
                $("#ChangeUsernameDialog").html("Password fields did not match!<br><br><input id=\"passInput1\" type=\"password\"></input><br>" +
        "<input id=\"passInput2\" type=\"password\"></input>");
            }
                else if ($("#passInput1").val().length < 6) {
                    $("#ChangeUsernameDialog").html("Password must be atleast 6 characters long.<br><input id=\"passInput1\" type=\"password\"></input><br>" +
        "<input id=\"passInput2\" type=\"password\"></input>");
                }
                else {
                    PageMethods.SettingsSetPassword($("#passInput1").val(), SetUserPasswordSuccess);
                    
                }

            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
        });
}
    else {
        $("#ChangeUsernameDialog").attr("title", "Send password mail");
        $("#ChangeUsernameDialog").html("Send mail to user to confirm password change?");
        $("#ChangeUsernameDialog").dialog({ show: { effect: 'slide', direction: "up"} });
        $("#ChangeUsernameDialog").dialog({ buttons: {
            "Ok": function () {
                LiveDocs.services.ResetPassword.SendResetPasswordMail(value, PasswordChangedByMailSuccess);
            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
        });
    }
   
}

function SetUserPasswordSuccess(value) {
    if (value) {
        $("#ChangeUsernameDialog").html("Password was changed.<br>Use the new password on next login.");
    }
    else {
        $("#ChangeUsernameDialog").html("Could not complete request, contact support.");
    }
    $("#ChangeUsernameDialog").dialog({ buttons: { "Ok": function () { $(this).dialog("close"); } } });
}

function PasswordChangedByMailSuccess(value) {
    if(value) {
        $("#ChangeUsernameDialog").html("Password mail sent");
        $("#ChangeUsernameDialog").dialog({ buttons: {
            "Ok": function () {
                $(this).dialog("close");
            }
        }
        });
    }
    else {
        $("#ChangeUsernameDialog").html("Error sending mail, check site logs");
    }
   
}