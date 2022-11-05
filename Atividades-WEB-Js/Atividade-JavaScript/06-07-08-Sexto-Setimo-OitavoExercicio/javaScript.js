function corFonte(cor){
    document.getElementById("paragrafo").style.color = cor;
}
function backgFonte(cor){
    document.getElementById("paragrafo").style.backgroundColor = cor;
}
var font = 20;
function aumentaFont(){
    font+= 5;
    document.getElementById("paragrafo").style.fontSize = font+"px";
}

function diminuiFont(){
    font-= 5;
     document.getElementById("paragrafo").style.fontSize = font+"px";
}

function maiscula(){
    document.getElementById("paragrafo").style.textTransform = "uppercase";
}

function minuscula(){
    document.getElementById("paragrafo").style.textTransform = "lowercase";
}