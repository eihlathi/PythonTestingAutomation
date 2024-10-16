console.log("Starting the HTML5 Canvas demo...");

const canvas = document.getElementById("mycanvas");
const ctx = canvas.getContext("2d");

// ctx.fillStyle = "green";
// ctx.fillRect(10, 10, 150, 100);

// Ball properties
let x = canvas.width / 2;
let y = canvas.height / 2;
let dx = 2;
let dy = -2;
const ballRadius = 20;
const ballColor = '#0095DD';

// Function to draw the ball
function drawBall() {
    ctx.beginPath();
    ctx.arc(x, y, ballRadius, 0, Math.PI * 2);
    ctx.fillStyle = ballColor;
    ctx.fill();
    ctx.closePath();
}

// Function to update the canvas
function updateCanvas() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    drawBall();

    // Check for collisions with the walls
    if(x + dx > canvas.width - ballRadius || x + dx < ballRadius) {
        dx = -dx;
    }
    if(y + dy > canvas.height - ballRadius || y + dy < ballRadius) {
        dy = -dy;
    }

    // Update ball position
    x += dx;
    y += dy;

    requestAnimationFrame(updateCanvas);
}

// Start the animation
updateCanvas();
