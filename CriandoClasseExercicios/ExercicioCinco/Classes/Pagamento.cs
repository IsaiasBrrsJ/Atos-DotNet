using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCinco.Classes {
    internal class Pagamento {

        private string cheque = "Pagamento com cheque";
        private string cartao = "Pagamento com cartão";
        private string dinheiro = "Pagamento com dinheiro";

        public string getCheque() {
            return cheque;
        }
        public string getCartao() {
            return cartao;
        }

        public string getDinheiro() {
            return dinheiro;
        }

    }
}
