
var whitekey = "#FF0000";
var blackkey = "#000000"
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");
ctx.beginPath();
ctx.fillStyle = whitekey;

var counter = 0;

for (i = 0; i < 14; i++) {
    counter += 20;
    ctx.rect(0, 0, counter, 75);
}

ctx.fillStyle = blackkey;
ctx.fillRect(12, 0, 15, 43);
ctx.fillRect(34, 0, 15, 43);
ctx.fillRect(72, 0, 15, 43);
ctx.fillRect(92, 0, 15, 43);
ctx.fillRect(112, 0, 15, 43);
ctx.fillRect(154, 0, 15, 43);
ctx.fillRect(174, 0, 15, 43);
ctx.fillRect(214, 0, 15, 43);
ctx.fillRect(234, 0, 15, 43);
ctx.fillRect(254, 0, 15, 43);
ctx.stroke();

