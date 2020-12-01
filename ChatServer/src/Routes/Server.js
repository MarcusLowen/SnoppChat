var express = require("express");
var router = express.Router();
const fs = require('fs')

let names = ["Nisse","Stig","Göran"]
let message = ["Yo", "Ey", "Tjena"]

fs.writeFile('serverdata.txt', names, (err) => {
    if (err) throw err;
})