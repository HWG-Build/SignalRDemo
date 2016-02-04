$(function () {
    $.connection.hub.logging = true;
    var myhub = $.connection.myHub;




    myhub.client.addUserIcon = function (name) {
        $('#panelHead').append('<div><strong>' + name + '</strong> has joined the page. <div>');
    };

    myhub.client.removeUserIcon = function(name) {
        $('#panelHead').append('<div><strong>' + name + '</strong> has left the page. <div>');
    };

    myhub.client.loadReferrals = function(count) {
        $('#counter').text(count);
    };

    $.connection.hub.start().done(function () {
        $('#Submit').on("click", function (e) {
            e.preventDefault();
            myhub.server.addReferral(
                $('#FirstNameTextBox').val(),
                $('#LastNameTextBox').val(),
                $('#GenderDropDown').selected,
                $('#DOBDateTime').val()
                );
            $('#FirstNameTextBox').val('').focus();
            $('#LastNameTextBox').val('');
            $('#GenderDropDown').val("");
            $('#DOBDateTime').val("");
        });
        $('#Remove').on("click", function (e) {
            e.preventDefault();
            myhub.server.removeReferral(
                );
        });


    });


});

$(document).ready(function () {
    
});

