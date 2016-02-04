$(function () {
    $.connection.hub.logging = true;
    var myhub = $.connection.myHub;

    myhub.client.hello = function () {

    };

    myhub.client.addUserIcon = function (name) {
        setTimeout(function ()
        {
            $('#panelHead').append('<div><strong>' + name + '</strong> has joined the page. <div>')
        }, 1000)
    };

    myhub.client.removeUserIcon = function(name) {
        setTimeout(function ()
        {
            $('#panelHead').append('<div><strong>' + name + '</strong> has left the page. <div>')
        }, 1000)
    };

    myhub.client.LoadReferral = function (count) {
        $('#counter').text(count);
    }

    $.connection.hub.start().done(function () {
        $('#Submit').on("click", function () {
            myhub.server.addReferral(
                $('#FirstNameTextBox').val(),
                $('#LastNameTextBox').val(),
                $('#GenderDropDown').selected,
                $('#DOBDateTime').val()
                );
        });
    });


});

$(document).ready(function () {
    
});

