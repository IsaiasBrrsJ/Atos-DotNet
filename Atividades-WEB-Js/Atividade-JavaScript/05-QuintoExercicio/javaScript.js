const checkbox = document.querySelectorAll('input[name="animais"]');
const btn = document.querySelector("#Enviar");

for (let i = 0; i < checkbox.length; i++) {
   
   checkbox[i].addEventListener('click', (eventArgs) =>{
   var marcouCheckbox = document.querySelectorAll('input[name="animais"]:checked').length;
      
   btn.disabled = (marcouCheckbox >= 2 )? false : true;

 });
}