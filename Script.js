var Canvas = document.getElementById("Canvas");
var Context = Canvas.getContext("2d");

Context.lineWidth = 3;
Context.strokeStyle = "#000000";
Context.fillStyle = "#0000ff";

Context.beginPath();
Context.rect(20,20,99,99)
Context.rect(20,120,99,99);
Context.rect(120,20,99,99);
Context.rect(120,120,99,99);
Context.stroke();
Context.fill();
Context.closePath();
