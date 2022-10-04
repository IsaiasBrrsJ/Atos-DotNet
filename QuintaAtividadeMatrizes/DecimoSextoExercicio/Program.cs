namespace DecimoSextoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //17) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
            //Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

            int[,] matriz = new int[3, 4];
            int[,] matrizTranposta = new int[4, 3];

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {

                    Console.Write($"Digite [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 3; j++) {
                    matrizTranposta[i, j] = matriz[j, i];
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    Console.Write($"[{matriz[i, j]}]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz transposta\n");
            for (int i = 0; i < matrizTranposta.GetLength(0); i++) {
                for (int j = 0; j < matrizTranposta.GetLength(1); j++) {
                    Console.Write($"[{matrizTranposta[i, j]}]");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}