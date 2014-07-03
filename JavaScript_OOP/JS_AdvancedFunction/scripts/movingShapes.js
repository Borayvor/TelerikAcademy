
////Create a module that works with moving div nodes. Implement functionality for:
////Add new moving div element to the DOM
////The module should generate random background, font and border colors for the div element
////All the div elements are with the same width and height
////The movements of the div nodes can be either circular or rectangular
////The elements should be moving all the time


var movingShapes = (function () {

    var div = document.createElement('div'),
        circularTemplate = {           
            xCenter: 0,
            yCenter: 0,
            radiusVertical: 0,
            radiusHorizontal: 0,
            angle: 0            
        };

    function setDivStyle(div) {
        var DIV_WIDTH = 40;
        var DIV_HEIGHT = 40;
        var BORDER_SIZE = 3;
        var positionX = getRandomNumber(100, 700);
        var positionY = getRandomNumber(100, 500);
        

        div.style.width = DIV_WIDTH + 'px';
        div.style.height = DIV_HEIGHT + 'px';
        div.style.borderWidth = BORDER_SIZE + 'px';
        div.style.borderStyle = 'solid';
        div.style.borderColor = getRandomColor();
        div.style.backgroundColor = getRandomColor();
        div.style.position = 'absolute';
        div.textContent = 'DIV';
        
    }

    function getRandomNumber(fromMinNumber, toMaxNumber) {
        return Math.floor(Math.random() * (toMaxNumber - fromMinNumber + 1)) + fromMinNumber;
    }

    function getRandomColor() {
        var red = getRandomNumber(0, 255),
            green = getRandomNumber(0, 255),
            blue = getRandomNumber(0, 255);

        var color = 'rgb(' + red + ',' + green + ',' + blue + ')';

        return color;
    }
    
    function addDivToContainer() {
        var container = document.getElementById('container');
        var currentDiv = div.cloneNode(true);

        setDivStyle(currentDiv);

        container.appendChild(currentDiv);
               
        return currentDiv;
    }

    function moveEllipseDiv(angle, currentDiv) {

        var radiusVertical = 70,
            radiusHorizontal = 140,
            xCenter = 200,
            yCenter = 200,
            xPos = Math.floor(xCenter + (radiusVertical * Math.cos(angle))),
            yPos = Math.floor(yCenter + (radiusHorizontal * Math.sin(angle)));

        angle = angle - 0.01;

        currentDiv.style.top = xPos + "px";
        currentDiv.style.left = yPos + "px";

        setTimeout(function () {
            moveEllipseDiv(angle, currentDiv);
        }, 5);
    }

    function moveRectDiv(dir, offset, singleDiv) {
        var xStart = 400, 
            yStart = 300, 
            rectSideA = 200, 
            rectSideB = 200,
            x,
            y;

        offset += 1;

        if ((offset === rectSideA && dir % 2 === 0) || (offset === rectSideB && dir % 2 === 1)) {
            dir++;
            dir %= 4;
            offset = 0;
        }

        switch (dir) {
            case 0:
                y = yStart + offset;
                x = xStart;
                break;
            case 1:
                x = xStart + offset;
                y = yStart + rectSideA;
                break;
            case 2:
                y = yStart + rectSideA - offset;
                x = xStart + rectSideB;
                break;
            case 3:
                x = xStart + rectSideB - offset;
                y = yStart;
                break;
        }
        singleDiv.style.top = y + "px"; 
        singleDiv.style.left = x + "px"; 

        setTimeout(function () { 
            moveRectDiv(dir, offset, singleDiv);
        }, 5);
    }

    var add = function (moveName) {

        if (moveName === 'rect') {
            moveRectDiv(0, 0, addDivToContainer());
        }
        else if (moveName === 'ellipse') {
            moveEllipseDiv( 0, addDivToContainer());
        }
        else {
            throw { message: 'Invalid moving type !' }
        }

    }

    return {
        add: add
    }
}());