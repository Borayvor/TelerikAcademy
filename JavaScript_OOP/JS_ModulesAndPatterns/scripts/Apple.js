var Apple = (function () {
    'use strict';

    var coordinate = ObjectCoordinate.getRandomCoordinate();
        
    var getCoordinate = function () {
        return coordinate;
    }

    var setCoordinate = function (position) {
        coordinate = position;
    }

    return {
        getCoordinate: getCoordinate,
        setCoordinate: setCoordinate
    };
}());

