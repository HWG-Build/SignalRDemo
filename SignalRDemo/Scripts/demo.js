$(function () {
    $.connection.hub.logging = true;
    var myhub = $.connection.myHub;
    myhub.client.hello = function () {

    };

    myhub.client.addUserIcon = function (name) {
        
        $('#panelHead').append('<div><strong>' + name + '</strong> has joined the page. <div>')
    }

    myhub.client.removeUserIcon = function(name) {
        $('#panelHead').append('<div><strong>' + name + '</strong> has left the page. <div>')
    }

    $.connection.hub.start().done(function() {
        //myhub.server.OnConnected();
       
    });

    //$.connection.hub.stop(function() {
    //   myhub.server.OnDisconnected();
    //});
});

$(document).ready(function () {
    
});

