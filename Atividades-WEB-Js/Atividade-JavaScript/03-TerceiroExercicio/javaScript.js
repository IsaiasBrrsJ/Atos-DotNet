function mudaCorFundo(){
    // body                            // Aqui pega o checked selecinado;
 document.body.style.backgroundColor = document.querySelector('input[name="cores"]:checked').value;
}
