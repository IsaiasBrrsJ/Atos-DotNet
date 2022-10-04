namespace DecimoTerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            //13) Escreva um programa que leia os valores de uma matriz 4x3, e
            //em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

            int[,] matriz = new int[4, 3];

            
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 3; j++) {

                    Console.Write($"Digite [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 3; j++) {

                    if (( (i + j) % 2 == 0)) {
                        Console.Write($"[{matriz[i, j]}]");
                    }

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}