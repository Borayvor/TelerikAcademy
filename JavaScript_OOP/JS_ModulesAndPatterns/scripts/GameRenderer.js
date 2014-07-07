
var GameRenderer = (function () {
    'use strict';

    function drawGame() {
        GameCanvas.clear();       
        drawSnake();
        drawApple();
    }
        
    function drawSnake() {
        var snakeCell, x, y;
        var coordinates = Snake.getCoordinates();
        var coordLength = coordinates.length;

        for (snakeCell = 0; snakeCell < coordLength; snakeCell += 1) {
            x = coordinates[snakeCell].x;
            y = coordinates[snakeCell].y;

            if (snakeCell == 0) {
                GameCanvas.drawCircle(x, y, 'white', "blue");
            }
            else {
                GameCanvas.drawCircle(x, y, 'white', "green");
            }
        }
    }

    function drawApple() {
        var appleCoordinate = Apple.getCoordinate();        
        GameCanvas.drawCircle(appleCoordinate.x, appleCoordinate.y, 'white', 'red');
    }

    return {
        drawGame: drawGame
    }
}());