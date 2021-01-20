var fs = require('fs');
var express = require('express');
const { time } = require('console');
let data = fs.readFileSync('serverdata.json');

var document = JSON.parse(data);

var userdata = fs.readFileSync('users.json');
var users = JSON.parse(userdata);

var app = express();
var server = app.listen(3000, listening);

function listening() {
    console.log("listening. . . ");
}

app.get('/send/:user/:message', sendMessage);

function sendMessage(req, res) {
    var data = req.params;
    var user = data.user;
    var message = data.message;
    var date = new Date();
    var reply;
    if (!user || !message) {
        var reply = {
            msg: "failed."
        }
        console.log("fel!")
        res.send(reply);
    } else {
        document.Messages.push({time: date, user: user, message: message});
        var data = JSON.stringify(document, null, 2);
        fs.writeFile('serverdata.json', data, finished);

        function finished(err) {
            console.log('all set.')
            reply = {
                user: user,
                message: message,
                status: "success"
            }
            res.send(reply);
        }
    } 
} 


app.get('/add/:user/:password', addUser)
 
function addUser(req, res) {
    let user = req.params.user;
    let password = req.params.password;
    let reply;
    if (users[user]) {
        reply = {
            status: "user already exists",
            user: user
        }
        res.send(reply);
    } else {
        users[user] = password;
        let data = JSON.stringify(users, null, 2);
        fs.writeFile('users.json', data, function() {
            reply = {
                status: "sucess"
            }
            res.send(reply);
        });
    }
}
 
app.get('/login/:user/:password', login)
 
function login(req, res) {
    let user = req.params.user;
    let password = req.params.password;
    let reply;
    if (users[user] === password) {
        reply = {
            status: "sucess"
        }
    } else {
        reply = {
            status: "failed"
        }
    }
    res.send(reply);
}

app.get('/all', sendAll);

function sendAll(req, res) {
    res.send(document);
    console.log('data sent.');
}