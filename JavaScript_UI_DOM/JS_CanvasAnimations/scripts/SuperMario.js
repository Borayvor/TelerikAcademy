
window.onload = function () {
    "use strict"

    var stage = new Kinetic.Stage({
        container: 'canvas-stage',
        width: 800,
        height: 600
    });

    var layer = new Kinetic.Layer();

    var imageObj = new Image();

    imageObj.onload = function () {
        var superMario = new Kinetic.Sprite({
            x: 250,
            y: 405,
            image: imageObj,
            animation: 'idle',
            animations: {
                idle: [
                  40, 102, 26, 36,
                  13, 102, 26, 36,
                ],
                moveRight: [
                  7, 12, 26, 36,
                  36, 12, 26, 36,
                  62, 12, 26, 36,
                  94, 12, 26, 36,
                  121, 12, 26, 36,
                  151, 12, 26, 36,
                ],
                moveLeft: [
                  9, 55, 26, 36,
                  34, 55, 26, 36,
                  63, 55, 26, 36,
                  92, 55, 26, 36,
                  117, 55, 26, 36,
                  144, 55, 26, 36,
                ]
            },
            frameRate: 7,
            frameIndex: 0
        });

        layer.add(superMario);

        stage.add(layer);

        superMario.start();

        var frameCount = 0;

        superMario.on('frameIndexChange', function (evt) {

            superMario.scale({ x: 4, y: 4 });

            if ((superMario.animation() === 'moveRight' || superMario.animation() === 'moveLeft') && ++frameCount > 4) {
                superMario.animation('idle');
                frameCount = 0;
            }

        });

        function onKeyDown(evt) {
            switch (evt.keyCode) {
                case 39: // left arrow
                    {
                        superMario.setX(superMario.attrs.x += 10);
                        superMario.attrs.animation = "moveRight";
                        break;
                    }
                case 37: // right arrow
                    {
                        superMario.setX(superMario.attrs.x -= 10);
                        superMario.attrs.animation = "moveLeft";
                        break;
                    }
            }
        }

        window.addEventListener('keydown', onKeyDown);
    }

    imageObj.src = 'images/SuperMario.png';

   
}