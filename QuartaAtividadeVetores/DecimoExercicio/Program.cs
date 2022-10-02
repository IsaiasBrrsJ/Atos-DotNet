using System.Transactions;

namespace DecimoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*  10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.
                Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.
            */


            int[] vet = new int[5];
            int[] vetDois = new int[vet.Length];
            bool eInt = true;


            for (int i = 0; i < vet.Length; i++) {

                Console.Write($"Digite o {i + 1} numero: ");
                 eInt = int.TryParse(Console.ReadLine(), out vet[i]);// verifica se o numero pode ser convertido para inteiro

                if (eInt is false) { // se false, adciona valor 2 no local falso;

                    vetDois[i] = 2;
                }
                else {
                    vetDois[i] = vet[i];
                }
            }

            Console.WriteLine("\n----- Valores Lidos ------\n");

            for (int i = 0; i < vet.Length; i++) {

                if (vet[i] != 0)
                    Console.WriteLine(vet[i]);
                else
                    Console.WriteLine("null");

            }
            Console.WriteLine("\n-----------------------\n");


            Console.WriteLine("\n----- Resultado ------\n");
            for (int i = 0; i < vet.Length; i++) {

                Console.WriteLine(vetDois[i]);
            }
            Console.WriteLine("\n-----------------------\n");



            Console.ReadKey();

        }
    }
}