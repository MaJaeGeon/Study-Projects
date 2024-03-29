const canvas = document.getElementById("jsCanvas");
const ctx = canvas.getContext("2d");
const colors = document.getElementsByClassName("jsColor");
const range = document.getElementById("jsRange");
const mode = document.getElementById("jsMode");
const save = document.getElementById("jsSave");

const INITIAL_COLOR = "#2C2C2C";
const CANVAS_WIDTH = 700;
const CANVAS_HEIGHT = 700;

canvas.width = CANVAS_WIDTH;
canvas.height = CANVAS_HEIGHT;

ctx.fillStyle = "#FFFFFF";
ctx.fillRect(0, 0, canvas.width, canvas.height);
 
ctx.strokeStyle = INITIAL_COLOR;
ctx.fillStyle = INITIAL_COLOR;

ctx.lineWidth = 2.5;

let painting = false;
let filling = false;

function startPainting() {
    painting = true;
}

function onMouseMove(event) {
    const x = event.offsetX;
    const y = event.offsetY;

    if(!painting){
        ctx.beginPath();
        ctx.moveTo(x, y);
    } else {
        ctx.lineTo(x, y);
        ctx.stroke();
    }
}

function stopPainting() {
    painting = false;
}

function handleColorClick(event) {
    ctx.strokeStyle = event.target.style.backgroundColor;
    ctx.fillStyle = event.target.style.backgroundColor;
}

function handleRangeChange(event) {
    ctx.lineWidth = event.target.value;
}

function handleModeClick() {
    if(filling === true) {
        filling = false;
        mode.innerText = "FILL";
    }
    else
    {
        filling = true;
        mode.innerText = "PAINT";
    }

}

function handleCanvasClick() {
    if(filling) ctx.fillRect(0, 0, canvas.width, canvas.height);
}

function handleCOntextMenu(event) {
    event.preventDefault();
}

function handleSaveClick() {
    const image = canvas.toDataURL("image/png");
    const link = document.createElement("a");
    link.href = image;
    link.download = "PaintJS[EXPORT]";
    link.click();
}

if(canvas) {
    canvas.addEventListener("mousemove", onMouseMove    );
    canvas.addEventListener("mousedown", startPainting  );
    canvas.addEventListener("mouseup", stopPainting     );
    canvas.addEventListener("mouseleave", stopPainting  );
    canvas.addEventListener("click", handleCanvasClick  );
    canvas.addEventListener("contextmenu", handleCOntextMenu);
}

Array.from(colors).forEach(color => color.addEventListener("click", handleColorClick));

if(range) {
    range.addEventListener("input", handleRangeChange);
}

if(mode) {
    mode.addEventListener("click", handleModeClick);
}

if(save) {
    save.addEventListener("click", handleSaveClick);
}