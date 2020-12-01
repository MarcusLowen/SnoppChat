var express = require('express');
var router = express.Router();

/* GET users listing. */
router.get('/', function (req, res, next) {
  res.send('respond with a resource');
});

router.get('/imt', function (req, res, next) {
  res.send('Heja Soltorg');
});

module.exports = router;
