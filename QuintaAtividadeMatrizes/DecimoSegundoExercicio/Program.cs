namespace DecimoSegundoExercicio {
    internal class Program {
        static void Main(string[] args) {


            //12) Leia uma matriz A de tipo double de dimenção 3x3,
            //crie uma nova matriz resultante da divisão dos elementos
            //da matriz A pela soma dos seus indices.

            double[,] matrizA = new double[3, 3];
            double[,] matrizResultanteA = new double[3, 3];
            int somaIndices = 0;


            Console.WriteLine("Preencha a MATRIZ A\n");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write($"Digite [{i + 1},{j + 1}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {

                   matrizResultanteA[i, j] = (matrizA[i, j] / (i + j)); //Elementos da matriz A dividido pelos seus indices (i + j)
                }
            }

            Console.WriteLine("\nMatriz Resultante\n");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {

                    Console.Write($"[{(matrizResultanteA[i, j]).ToString("0.0")}]");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}