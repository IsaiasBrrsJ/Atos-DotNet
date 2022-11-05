
var radioChk = document.querySelectorAll('input[name="formClientes"]');
var cpf = document.getElementById("CPF");
var cnpj = document.getElementById("CNJP");

var dtNasc = document.getElementById("dtNasc");
for(let i = 0; i < radioChk.length; i++){
  radioChk[i].addEventListener('change', (eventArgs)=>{

    if(radioChk[i].value == 'pFisica'){
      cpf.removeAttribute('disabled');
      dtNasc.removeAttribute('disabled');
     
      cnpj.setAttribute('disabled', 'disabled');

    }
    else{

      cpf.setAttribute('disabled', 'disabled');
      dtNasc.setAttribute('disabled', 'disabled');
       cnpj.removeAttribute('disabled');
    }


  })
}
