using System.Diagnostics;

namespace leituraDeValoresVetor {
    internal class Program {
        static void Main(string[] args) {

            int i;
            int[] b = new int[5];

            Console.WriteLine("------ - Leitura dos valores:------");

            for (i = 0; i < 5; i++) {
                Console.Write("Digite o valor " + i + ":");
                b[i] = int.Parse(Console.ReadLine());
            }


            for (i = 0; i < 5; i++) {
                
                Console.WriteLine("Valor índice "+ i + " é igual a "+ b[i]);
            }


            Console.ReadKey();

        }
    }
}