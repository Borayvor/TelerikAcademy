
var ObjectCoordinate = (function () {
    'use strict'

    function ObjectCoordinate(x, y) {
        this.x = x;
        this.y = y;
    }

    ObjectCoordinate.prototype.equal = function (other) {
        return this.x === other.x && this.y === other.y;
    };

    ObjectCoordinate.prototype.toString = function () {
        return this.x + "/" + this.x;
    };
       
    ObjectCoordinate.getRandomCoordinate = function () {
        var x = getRandomNumber(0, GameCanvas.width() / 10) * 10;
        var y = getRandomNumber(0, GameCanvas.height() / 10) * 10;
        return new ObjectCoordinate(x, y);
    };

    function getRandomNumber(min, max) {
        return parseInt(Math.random() * (max - min) + min);
    }

    return ObjectCoordinate;
}());

