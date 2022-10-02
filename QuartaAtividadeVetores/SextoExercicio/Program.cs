namespace SextoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*

              6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à
                  ordem de leitura. Exemplo:
                  a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
                  b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|
           */

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.Write("Digite o {0} valor: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++) {
                Console.Write("|{0}|", vetor[i]);
            }
            Console.WriteLine("");
            for (int i = 9; i >= 0; i--) {
                Console.Write("|{0}|", vetor[i]);
            }


            Console.ReadKey();
        }
    }
}