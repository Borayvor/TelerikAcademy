﻿
var Snake = (function () {
    'use strict';

    var INITIAL_DIRECTION = "down";

    var coordinates = [
        new ObjectCoordinate(100, 60),
        new ObjectCoordinate(110, 60),
        new ObjectCoordinate(120, 60),
        new ObjectCoordinate(130, 60),
        new ObjectCoordinate(140, 60)
    ];

    var speed = 10;
    var direction = INITIAL_DIRECTION;
    var isKeyPressed = false;
    var isDead = false;
    var hasApple = false;

    function updateDirection(keyCode) {
        switch (keyCode) {
            case 37:
                if (direction !== "right") {
                    direction = "left";
                    isKeyPressed = true;
                }
                break;
            case 38:
                if (direction !== "down") {
                    direction = "up";
                    isKeyPressed = true;
                }
                break;
            case 39:
                if (direction !== "left") {
                    direction = "right";
                    isKeyPressed = true;
                }
                break;
            case 40:
                if (direction !== "up") {
                    direction = "down";
                    isKeyPressed = true;
                }
                break;
        }
    }

    function getCoordinates() {
        return coordinates;
    }

    function update() {
        if (isKeyPressed) {
            isKeyPressed = false;
        }
        move();

        return isDead;
    }

    function move() {
        var currentPosition = coordinates[0];
        var newX, newY;

        if (direction === "down") {
            newX = currentPosition.x;
            newY = currentPosition.y + speed;
        } else if (direction === "up") {
            newX = currentPosition.x;
            newY = currentPosition.y - speed;
        } else if (direction === "left") {
            newX = currentPosition.x - speed;
            newY = currentPosition.y;
        } else if (direction === "right") {
            newX = currentPosition.x + speed;
            newY = currentPosition.y;
        }

        var newPosition = new ObjectCoordinate(newX, newY);
        checkCollision(newPosition);
        coordinates.unshift(newPosition);

        if (hasApple) {
            hasApple = false;
        } else {
            coordinates.pop();
        }
    }

    function checkCollision(position) {
        if (coordinates.contains(position) || position.x <= 0 || position.x >= GameCanvas.width() - 1
            || position.y >= GameCanvas.height() - 1 || position.y <= 0) {
            isDead = true;
        }
    }

    function eat() {
        hasApple = true;
    }

    return {
        updateDirection: updateDirection,
        isKeyPressed: isKeyPressed,
        getCoordinates: getCoordinates,
        update: update,
        eat: eat
    };
}());

