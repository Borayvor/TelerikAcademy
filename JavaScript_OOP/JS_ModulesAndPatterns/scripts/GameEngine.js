var GameEngine = (function () {
    "use strict";
   
    var isEnd = false;
    var initialWaitTime = 1000;
    var updateInterval = 70;


    if (!Array.prototype.contains) {
        Array.prototype.contains = function (obj) {
            var i = this.length;

            while (i--) {
                if (this[i].equal(obj)) {
                    return true;
                }
            }

            return false;
        };
    }

    function init() {
        window.requestAnimFrame = (function () {
            return window.requestAnimationFrame ||
                window.webkitRequestAnimationFrame ||
                window.mozRequestAnimationFrame ||
                function (callback) {
                    window.setTimeout(callback, 1000 / 60);
                };
        })();

        document.addEventListener('keydown', function (event) {
            Snake.updateDirection(event.keyCode);
        });

        GameRenderer.drawGame();

        // wait one second before starting animation
        setTimeout(function () {
            frame();
        }, initialWaitTime);
    }

    function frame() {
        if (isEnd) {           
            return;
        }

        isEnd = Snake.update();

        checkApple();
        GameRenderer.drawGame();

        setTimeout(function () {
            requestAnimFrame(function () {
                frame();
            });
        }, updateInterval);
    }

    function checkApple() {
        var currentPosition = Snake.getCoordinates()[0];
        if (currentPosition.equal(Apple.getCoordinate())) {
            Apple.setCoordinate(ObjectCoordinate.getRandomCoordinate());           
            //player.score += 1;
            Snake.eat();
        }
    }

    return {
        init: init
    }
    
})();

window.onload = function () {
    GameEngine.init();
};