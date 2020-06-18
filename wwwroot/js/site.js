"use strict";

//import { signalR } from "./signalr/dist/browser/signalr";

$(document).ready(function _shred() {
    let connection = new signalR
        .HubConnectionBuilder()
        .withUrl("/shredHub")
        .build();
    connection.start().catch(function _connectionStartError(err) {
        console.error(err.toString());
    });

    connection.on("ShredUpdated", function _shredUpdated(message) {
        let tokens = message.split(':');
        let command = tokens[0];
        let params = tokens[1];
        if (command === "SHRED-ADDED") {
            
        }
    })
});