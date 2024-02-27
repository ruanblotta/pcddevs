//função Dark Mode
function swapColorBlack() {
    if (document.body.style.backgroundColor == 'black') {
        dicument.body.style.backgroundColor = 'white';
        document.body.style.color = 'black';
    } else {
        document.body.style.backgroundColor = 'black';
        document.body.style.color = 'white';
    }
}

//função Light Mode
function swapColorWhite() {
    if (document.body.style.backgroundColor == 'white') {
        dicument.body.style.backgroundColor = 'black';
        document.body.style.color = 'white';
    } else {
        document.body.style.backgroundColor = 'white';
        document.body.style.color = 'black';
    }
}

function addText() {
    var newParagraphy = document.createElement("p")
    var text = "O Mágico de OZ - 20:00 - Hoje"

    newParagraphy.textContent = text;

    document.body.appendChild(newParagraphy);
}

addText();

// document.querySelectorAll('h2').forEach(function(h2)){
//     h2.style.color = "#fcb000";   
// });