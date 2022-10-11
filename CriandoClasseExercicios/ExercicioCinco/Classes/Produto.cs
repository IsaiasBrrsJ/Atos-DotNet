using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCinco.Classes {
    internal class Produto {

        private int codProduto;
        private string nomeProduto;
        private int quantidadeEmEstoque;
        private decimal precoProduto;
      
        public Produto(string nomeProduto, int quantidadeEmEstoque, decimal precoProduto) {
            this.nomeProduto = nomeProduto;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.precoProduto = precoProduto;
            codProduto = new Random().Next(0, 1000);
        }

        public int getQtdEstoque() {
            return quantidadeEmEstoque;
        }
        public decimal getPrecoProduto() {
            return precoProduto;
        }

        public void setQtdEstoque(int qtdEstoque) {
            quantidadeEmEstoque -= qtdEstoque;
        }
        public string getNomeProduto() {
            return nomeProduto;
        }
    }
}
