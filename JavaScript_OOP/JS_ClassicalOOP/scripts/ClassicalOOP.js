////Create a module for drawing shapes using Canvas. Implement the following shapes:
////Rect, by given position (X, Y) and size (Width, Height)
////Circle, by given center position (X, Y) and radius (R)
////Line, by given from (X1, Y1) and to (X2, Y2) positions

var DrawShapes = (function () {
    'use strict';

    var ctx;

    function DrawShapes(selector) {

        if (selector !== '#container') {
            throw new ReferenceError('Container selector is not defined!');
        }

        var container = document.querySelector(selector);
        var canvas = document.createElement('canvas');

        canvas.setAttribute('width', 800);
        canvas.setAttribute('height', 600);
        canvas.style.border = '1px solid black';
        container.appendChild(canvas);
        ctx = canvas.getContext('2d');
    }

    function fill(color) {
        if (color !== 'none' && typeof color !== 'undefined') {
            ctx.fillStyle = color;
            ctx.fill();
        }
    }

    function stroke(color) {
        if (color !== 'none' && typeof color !== 'undefined') {
            ctx.strokeStyle = color;
            ctx.stroke();
        }        
    }

    DrawShapes.prototype = {
        drawRect: function drawRect(startX, startY, width, height, fillColor, strokeColor) {            
            ctx.beginPath();
            ctx.rect(startX, startY, width, height);
            ctx.closePath();            
            fill(fillColor);
            stroke(strokeColor);            
        },
        drawCircle: function drawCircle(startX, startY, radius, fillColor, strokeColor) {
           
            ctx.beginPath();
            ctx.arc(startX, startY, radius, 0, 2 * Math.PI);
            ctx.closePath();            
            fill(fillColor);
            stroke(strokeColor);           
        },
        drawLine: function drawLine(startX, startY, endX, endY, strokeColor) {
           
            ctx.beginPath();
            ctx.moveTo(startX, startY);
            ctx.lineTo(endX, endY);
            stroke(strokeColor);            
        }
    };

    return DrawShapes;    
}())