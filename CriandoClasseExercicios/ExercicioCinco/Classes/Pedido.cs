using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCinco.Classes {
    internal class Pedido {

        private int codPedido;
        private decimal valorTotal;
        private int qtdItens;
        private Pagamento pagamento;
        private Produto itens;

        public Pedido(int codPedido,int qtdItens, Produto produto) {
            this.codPedido = codPedido;;
            this.qtdItens = qtdItens;
            this.itens = produto;
            codPedido = new Random().Next(0, 1000);
        }
        public Pagamento getPagamento() {
            return pagamento;
        }

        public Produto getProduto(){
            return itens;
        }

        public decimal getValorTotal() {
           valorTotal += itens.getPrecoProduto() * qtdItens;

            return valorTotal;
        }
    }
}
