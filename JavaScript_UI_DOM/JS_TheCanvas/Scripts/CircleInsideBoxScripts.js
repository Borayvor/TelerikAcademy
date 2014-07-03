

function drawCircleInsideBox() {

    var canvas = document.getElementById('the-canvas');
    var canvasCtx = canvas.getContext('2d');        
    
    drawCircle(canvasCtx, 100, 100);
}

function drawCircle(ctx, x, y) {

    ctx.save();
    ctx.fillStyle = 'rgb(0, 0, 0)';

    ctx.strokeRect(0, 0, 800, 600);

    var moveX = 1;
    var moveY = 1;

    setInterval(function () {
        ctx.clearRect(1, 1, 798, 598);
        
        ctx.beginPath();
        ctx.arc(x, y, 50, 0, 2 * Math.PI);
        ctx.fill();

        if (x <= 51 || x >= 749) {
            moveX *= -1
        }        

        if (y <= 51 || y >= 549) {
            moveY *= -1;
        }

        x += moveX;
        y += moveY;

    }, 5);
    ctx.restore();
}