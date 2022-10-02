namespace QuartoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos
             elementos de mesmo índice,
             colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
             */

            int[] primeiroVetor = new int[10], segundoVetor = new int[10];
            int[] vetorDeSoma = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.Write("Informe um valor pro primeiro vetor na posicao {0}: ", i + 1);
                primeiroVetor[i] = int.Parse(Console.ReadLine());

                Console.Write("Informe um valor pro segundo vetor na posicao {0}: ", i + 1);
                segundoVetor[i] = int.Parse(Console.ReadLine());


                vetorDeSoma[i] = (primeiroVetor[i] * segundoVetor[i]);

            }

            Console.WriteLine("\n------Resutado----\n");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{primeiroVetor[i]} * {segundoVetor[i]} = {vetorDeSoma[i]}");
            }

            Console.ReadKey();
        }
    }
}