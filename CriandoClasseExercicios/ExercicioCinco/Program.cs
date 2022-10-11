using ExercicioCinco.Classes;
using System.ComponentModel;

namespace ExercicioCinco {
    internal class Program {
        static void Main(string[] args) {


            /*
             5 - Identifique	 as	 classes	 e	 implemente	 um	 programa	 para	 a	 seguinte 
             especificação:
             "O	supermercado vende diferentes tipos de produtos.	 
             Cada produto tem um preço e uma quantidade	em estoque.
             Um	pedido	de	um	cliente	é composto de itens,
             onde cada item especifica o produto que o cliente deseja e a 
             respectiva	quantidade. Esse pedido pode ser pago em dinheiro, cheque ou cartão."

           */
            List<Produto> produtos = new() {

              new Produto(nomeProduto: "Arroz Tio Urbano 10Kg",quantidadeEmEstoque: 30,precoProduto: 22.50m),
              new Produto(nomeProduto: "Refrigerante 2lts",quantidadeEmEstoque: 50,precoProduto: 5.50m),
              new Produto(nomeProduto: "Água Sanitária 1lt",quantidadeEmEstoque: 100,precoProduto: 3.40m),
              new Produto(nomeProduto: "Feijão 2kg", quantidadeEmEstoque: 30,precoProduto: 6.75m),
              new Produto(nomeProduto: "Açucar 2kg", quantidadeEmEstoque: 80, precoProduto: 8.75m),
              new Produto(nomeProduto: "Sal 2kg", quantidadeEmEstoque: 100, precoProduto: 2.50m)
            };
            List<Pedido> pedidos = new List<Pedido>();
            decimal somaTotal = 0m;
            do {
                Console.Clear();
                int contador = 1;
                foreach (var produto in produtos) {

                    Console.WriteLine("[ " + contador + " ]" + produto.getNomeProduto() + "\nPreço: " + produto.getPrecoProduto() + "\n");
                    contador++;

                }

                Console.Write("Escolha uma opção, 0 para sair: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao < 0 || opcao > 6) {
                    continue;
                }
                else if (opcao == 0) {
                    break;
                }
                else {
                    int gerarId = new Random().Next(0, 1000);
                    Pedido pedido = new Pedido(gerarId, 1, produtos[opcao - 1]);
                    pedidos.Add(pedido);
                    pedido.getProduto().setQtdEstoque(2);
                    somaTotal += pedido.getValorTotal();
                }

            } while (true);

            Console.WriteLine("Pedidos Adquiridos\n");
            foreach (var item in pedidos) {
                Console.Write(item.getProduto().getNomeProduto());
                Console.Write("  " + item.getProduto().getPrecoProduto()+"\n");
            }
            Console.Write("Valor total: " + somaTotal.ToString("C"));

            Console.ReadKey();
          
        }
    }
}