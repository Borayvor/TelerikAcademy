
window.onload = function () {
    'use strict';

    function getRandomValueInRange(startRange, endRange) {

        return Math.floor(Math.random() * (endRange - startRange + 1)) + startRange;
    }

    function getRandomValueInRangeInStringPx(startRange, endRange) {

        return getRandomValueInRange(startRange, endRange) + "px";
    }

    function getRandomColorInString() {

        var red = getRandomValueInRange(0, 255);
        var green = getRandomValueInRange(0, 255);
        var blue = getRandomValueInRange(0, 255);
        var rgb = 'rgb(' + red + ',' + green + ',' + blue + ')';

        return rgb;
    }

    function createDiv(x, y) {
                
        var size = 40;
        var width = size + 'px';
        var height = size + 'px';
        var backgroundColor = getRandomColorInString();
        var fontColor = getRandomColorInString();
        var borderColor = getRandomColorInString();
        var borderRadius = '10px';
        var borderWidth = '2px';
        var positionX = x + 'px';
        var positionY = y + 'px';

        var div = document.createElement("div");

        div.style.width = width;
        div.style.height = height;
        div.style.backgroundColor = backgroundColor;
        div.style.color = fontColor;
        div.style.borderColor = borderColor;
        div.style.borderRadius = borderRadius;
        div.style.borderWidth = borderWidth;
        div.style.left = positionX;
        div.style.top = positionY;
        div.style.position = 'absolute';
        div.style.textAlign = 'center';

        var divTitle = document.createElement("strong");
        divTitle.innerHTML = 'Div';

        div.appendChild(divTitle);

        return div;
    }
        
    var docFragment;
       
    function createRandomDivs(angle) {

        var nuberOfDivs = 5;        
        var increaseAngle = (Math.PI * 2) / nuberOfDivs;
        
        docFragment = document.createDocumentFragment();

        for (var i = 0; i < nuberOfDivs; i += 1) {

            var x = 100 * Math.cos(angle) + 200;
            var y = 100 * Math.sin(angle) + 200;

            docFragment.appendChild(createDiv(x, y));

            angle += increaseAngle;
        }

        document.body.appendChild(docFragment);
    }

    function clearAllDivs() {

        while (document.body.firstChild) {

            document.body.removeChild(document.body.firstChild);
        }
    }


    function rotateDivs() {
        var angle = 0;
        var increaseAngle = (Math.PI * 2) / 360;

        setInterval(function () {

            clearAllDivs();

            createRandomDivs(angle);

            angle += increaseAngle;
        }, 100);
    }
    
    rotateDivs();
}