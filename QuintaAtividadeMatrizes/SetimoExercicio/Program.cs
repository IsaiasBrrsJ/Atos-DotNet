namespace SetimoExercicio {
    internal class Program {
        static void Main(string[] args) {


            //7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C,
            //onde cada elemento de C é a subtração do elemento correspondente de A com B.

            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];

            Console.WriteLine("\nDigite valore pra matriz A");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write($"Digite o valor [{i+1},{j+1}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDigite valore pra matriz B");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write($"Digite o valor [{i + 1},{j + 1}]: ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                 C[i, j] = (A[i, j] - B[i, j]);

                  Console.WriteLine($"{A[i, j]} - {B[i, j]} = {C[i, j]}");
                }
            }

            Console.ReadKey();
        }
    }
}