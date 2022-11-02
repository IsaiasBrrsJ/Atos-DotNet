//1-Escreva um código que mostre os números ímapres entre 1 e 10.

// for(let i =2; i < 10; i++){

//     (i % 2 != 0) ? alert(i) : null;
//    }
   
//    //2-Escreva um código que calcule a soma de 1 até 100 (PS: a resposta é 5050)
//    var soma = 0;
//    for (let i = 1; i <= 100; i++) {
//        soma+= i;
//    }
//    alert(soma);


// let teste ="teste"
// let valor = 1;

// // if(valor > 0){
// //     let teste = "testeeee"; 
// // }

// // alert(teste);

// var numero = 1;

// if(numero == "1"){
//     alert("== compara apenas os valores");
// }

// var mensagem;

//  if(numero === "1"){ //resultado false
//     mensagem ="Nunca executa";
// }else{
//     mensagem ="Number é diferente de String com o ===";
// }

// /*
// Operador ternario (Versao reduzida do IF)
// condicao ? se_verdadeiro : se_falso;
// */

// var x =(numero == "1") ?"Nunca Executa" : "Number é diferente de String com O ===" ;

// var laranja =6;

// switch(laranja){
//     case 3:
//         alert('Fazer um cop ode suco');
//         break;
//      case 6:
//         alert('Fazer dois copos de suco');
//         break;
//      case 9:
//        alert('Fazer uma jarra de suco');           break;
//      default:
//         alert('Fazer quanto suco for possível');
// }

// Lacos de repeticao
// var pessoas =["João", "José", "Maria", "Sebastião", "Antônio"];

// for(let i = 0; i <pessoas.length; i++){
//     alert(pessoas[i]);
// }

// var nome ="";

// var pessoa ={nome: "Iara", sobrenome: "Almeida"};

// for(x in pessoa){
//     nome += pessoa[x]+" ";
// }

// alert(nome);

function func(){
    alert(1+2);
}

function minhaFuncao(){
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
}

function mostraNomeIdade(){
    var nome = document.getElementById("nome");
    var idade = document.getElementById("idade");
    
    if(idade.value >= 18){
     alert(nome.value + " é maior de idade"); 
    }
    else{
        alert(nome.value+" tem "+ idade.value +" anos.");
    }
}

function funcSomaValores(){
  var n1 = document.getElementById("primeiroValor");
  var n2 =document.getElementById("segundoValor");
 var button = document.getElementById("buttonEnviar");
 var soma = parseInt(n1.value)+ parseInt(n2.value);


 if(soma % 2 == 0){
    button.style.backgroundColor ="blue";
 }
 else{
    button.style.backgroundColor ="green";
 }

}