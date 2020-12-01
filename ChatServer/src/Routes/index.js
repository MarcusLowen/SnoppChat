var express = require("express");
var router = express.Router();
let fs = require("fs");

const fetch = require('node-fetch');

/* GET home page. */
router.get("/", function (req, res, next) {
  //  res.render('index', { title: 'Express' });
  res.send("Hello IMT");
});

router.get("/imt", function (req, res, next) {
  //  res.render('index', { title: 'Express' });
  res.send("Top Secret");
});

let nameList = [];

fs.readFile("namedata", function (err, data) {
  if (err !== null) {
    console.log("Fel fel fel" + err);
  } else {
    nameList = JSON.parse(data);
  }
})

router.get("/test", function (req, res, next) {
  let text = "";

  for (let i = 0; i < 10; i++) {
    text += `${i} `;
  }

  let name = req.query.name;
  let address = req.query.address;

  let item = { name: name, address: address };

  nameList.push(item);

  let data = JSON.stringify(nameList);

  fs.writeFile("namedata", data, x => x);

  res.send(data);
});

router.get("/read", function (req, res, next) {
  let data = JSON.stringify(nameList);

  res.send(data);
});

router.get("/time", function (req, res, next) {
  let date = new Date();

  let hours = date.getHours();
  let minutes = date.getMinutes();
  let seconds = date.getSeconds();

  let time = { hours: hours, minutes: minutes, seconds: seconds };

  res.send(JSON.stringify(time));
});

router.get("/trafik", function (req, res, next) {
  let data = [];

  fetch("http://api.sr.se/api/v2/traffic/messages?format=json").
    then(d => d.json().
      then(showData));

  function showData(d) {
    res.send(JSON.stringify(d));
  }
});

module.exports = router;

let names = ["Nisse","Stig","Göran"]
let message = ["Yo", "Ey", "Tjena"]

fs.writeFile('serverdata.txt', names, (err) => {
    if (err) throw err;
})