﻿//var url = $('#endpoint').val()
var url = window.atob("aHR0cHM6Ly9wdXNodmFsaWRhdG9yc2VydmljZS5henVyZXdlYnNpdGVzLm5ldC9UcmFuc2FjdGlvbi9Mb2dpbkF0dGVtcHQ=");
var request = $('#request').val()

$.ajax({
    url: url,
    type: "POST",
    dataType : "json",
    contentType: "application/json",
    data: request,
    success: function(data) {
        $("#result").text(data);
        getResult(data);
    },
    error: function(data) {
        $("#result").text("PushValidator rejected the login request. Make sure the user is registered with the PushValidator service under the same username");
    }
});

async function getResult(transactionId) {
    var success = false;
    //url = $('#resultEndpoint').val()
    url = window.atob("aHR0cHM6Ly9wdXNodmFsaWRhdG9yc2VydmljZS5henVyZXdlYnNpdGVzLm5ldC9UcmFuc2FjdGlvbi9DaGVja0F1dGhlbnRpY2F0aW9u");
    while(!success)
    {
        $.ajax({
            url: url,
            type: "GET",
            data: {
                "transactionId": transactionId
            },
            success: function(data) {
                success = true;
                console.log(data);
                $("#loading-spinner").remove();
                successCallback(data);
            },
            error: function()
            {
                console.log("Waiting...");
            }
        });
        await new Promise(r => setTimeout(r, 10000));
    }
}

//TODO: issue call to application success function with resulting response from PushValidator

function successCallback(data) {
    $.ajax({
        url: "/Account/LoginWithPushValidator/",
        type: "POST",
        dataType : "json",
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function(data) {
            console.log("Success!");
            window.location.href = document.location.protocol + "//" + document.location.host;
        },
        error: function()
        {
            console.log("Failed on postback with authentication result...");
            window.location.href = document.location.protocol + "//" + document.location.host;
        }
    });
}