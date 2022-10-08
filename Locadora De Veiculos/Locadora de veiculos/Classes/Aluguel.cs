using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_veiculos.Classes {
    internal class Aluguel {

        public Cliente cliente;
        public Carro carro;
        private DateTime diaAluguel = DateTime.Now;
        private DateTime? devolverCarro = null;
        private bool devolucao = false;

        public bool getDevolucaoCarro() {
            return devolucao;
        }

        public void setDevolucaoCarro() {
            this.devolucao = true;
        }
        public DateTime getData() {
            return diaAluguel;
        }

        public void setDevolucao() {
            devolverCarro = DateTime.Now;
        }

        public DateTime? getDevolucao() {
            return devolverCarro;
        }
    }
}
