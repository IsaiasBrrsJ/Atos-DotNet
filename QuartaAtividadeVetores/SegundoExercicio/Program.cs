namespace SegundoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //Escreva um algoritmo que leia valores para dois vetores de 20 elementos e
            //então realize a soma dos elementos da mesma posição, armazenando o resultado
            //em um outro vetor.

            int[] primeiroVetor = new int[20], segundoVetor = new int[20];
            int[] vetorDeSoma = new int[20];

            for (int i = 0; i < 20; i++) {
                Console.Write("Informe um valor pro primeiro vetor na posicao {0}: ", i + 1);
                primeiroVetor[i] = int.Parse(Console.ReadLine());

                Console.Write("Informe um valor pro segundo vetor na posicao {0}: ", i + 1);
                segundoVetor[i] = int.Parse(Console.ReadLine());


                vetorDeSoma[i] = (primeiroVetor[i] + segundoVetor[i]);

            }

            Console.WriteLine("\n------Resutado----\n");
            for (int i = 0; i < 20; i++) {
                Console.WriteLine($"{primeiroVetor[i]} + {segundoVetor[i]} = {vetorDeSoma[i]}");
            }

            Console.ReadKey();
        }
    }
}