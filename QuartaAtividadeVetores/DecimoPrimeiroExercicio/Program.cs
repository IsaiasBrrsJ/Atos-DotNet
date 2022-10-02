namespace DecimoPrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            //11. Escreva um programa que leia valores em um vetor de 5 posições.
            //    Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            int[] vet = new int[5];

            for (int i = 0; i < vet.Length; i++) {


                Console.Write("Digite o {0} valor: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n---- Ordem Inversa -----\n");
            for (int i = vet.Length-1; i >= 0; i--) {

                Console.Write($"{vet[i]} |");

            }

            

            Console.ReadKey();
        }
    }
}