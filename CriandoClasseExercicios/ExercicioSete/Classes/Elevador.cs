using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSete.Classes {
    internal class Elevador {

        
        private int andarAtual = 0;
        private int totalAndares;
        private int capacidadeElevador;
        private int pessoasNoElevador;

        public void setSubir(int andarAtual) {
            this.andarAtual += andarAtual;
        }
        public int getAndarAtual() {
            return andarAtual;
        }

        public void setDescer(int desce) {
            andarAtual -= desce;
        }

        public int getPessoasNoElevador() {
            return pessoasNoElevador;
        }

        public void setRemoverPessoasElevador(int removerPessoasNoElevador) {
            pessoasNoElevador -= removerPessoasNoElevador;
        }
        public void setPessoasNoElevador(int pessoas) {
            pessoasNoElevador += pessoas;
        }
        public int getTotAndares() {
            return totalAndares;
        }

        public void setTotalAndares(int totAndares) {
            totalAndares = totAndares;
        }
        public int getCapacidadeElevador() {
          return  capacidadeElevador;
        }
        public void setCapacidadeElevador(int capacidadeElevador) {
            this.capacidadeElevador = capacidadeElevador;
        }

    }
}
