function validarCadastro(){
    var login = document.getElementById("login");
    var senha = document.getElementById("password");
    var confirmaSenha = document.getElementById("confirmaPassword");
    var senhaSplit= senha.value.split('');
    var confirmaSenhaSplit = confirmaSenha.value.split('');

   if(login.value == ""){
     alert("Preencha todos os campos")
     login.focus();
   }
   else if(senha.value == "" ){
    alert("Preencha todos os campos")
    senha.focus();
   }
   else if(confirmaSenha.value == ""){
    alert("Preencha todos os campos")
    confirmaSenha.focus();
   }else{

    if((confirmaSenha.value != senha.value)){
        alert("Senhas Não coincidem");
        return;
     }
    
     if((senhaSplit.length < 6 || senhaSplit.length > 10) || (confirmaSenhaSplit.length < 6 || confirmaSenhaSplit.length > 10)){
        alert("Senha deve ter entre 6 e 10 caracteres");
        return;
     }
     else{
        alert("Cadastro realizado com sucesso");
     }
    


   }
}