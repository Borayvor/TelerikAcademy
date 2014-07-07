
var GameCanvas = (function () {
    'use strict';
    var CIRCLE_RADIUS = 5;

    var canvas = document.getElementById('canvas');
    var context = canvas.getContext('2d');    

    function drawCircle(x, y, strokeColor, fillColor) {
        context.beginPath();
        context.arc(x, y, CIRCLE_RADIUS, 0, 2 * Math.PI);

        if (fillColor) {
            context.fillStyle = fillColor;
            context.fill();
        }

        if (strokeColor) {
            context.strokeStyle = strokeColor;
            context.stroke();
        }
    }

    function drawText(x, y, text, fontSize, fontStyle, fillColor) {
        var font = fontSize.toString() + "px " + fontStyle;
        context.fillStyle = fillColor;
        context.font = font;
        context.fillText(text, x, y);
    }

    function getHeight() {
        return canvas.height;
    }

    function getWidth() {
        return canvas.width;
    }

    function clear() {
        context.clearRect(0, 0, canvas.width, canvas.height);
    }

    return {
        drawCircle: drawCircle,
        drawText: drawText,
        clear: clear,
        height: getHeight,
        width: getWidth
    };

}());