using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSete.Classes {
    internal class Elevador {

         private int andarAtual;
         private int totalDeAndares;
         private int capacidadeElevador;
         private int qtdPessoasNoElevador;

        public void Inicializa(int capacidadeElevador, int totalAndares) {

            this.capacidadeElevador = capacidadeElevador;
            this.totalDeAndares = totalAndares;
        }

        public string Entrar() {
            if (qtdPessoasNoElevador < 5) {
                qtdPessoasNoElevador++;

                return "\nEntrou, pesoas no elevador: "+qtdPessoasNoElevador;
            }
            else {

                return "\nElevador Cheio";
            }
        }

        public string Sair() {

            if (qtdPessoasNoElevador > 0) {
                qtdPessoasNoElevador--;
                return "\nSaiu, pesoas no elevador: "+ qtdPessoasNoElevador;
            }
            else {
                return "\nElevador Vazio";
            }
        }

        public string Sobe() {
            if ((andarAtual < totalDeAndares)) {
                andarAtual++;
                return "\nSubindo Para: "+ andarAtual;
            }
            else {
                return "\nVc chegou no ultimo andar";
            }
        }

        public string Desce() {

            if (andarAtual > 0) {
                andarAtual--;
                return "\n Descendo para "+ andarAtual;
            }
            else {

                return "\nChegou ao térreo";
            }
            
    
    
    
    }
}
