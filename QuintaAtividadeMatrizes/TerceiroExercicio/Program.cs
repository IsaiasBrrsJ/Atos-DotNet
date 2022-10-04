namespace TerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
             */

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write($"Linha {i + 1} Coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("\nDiagonal Principal\n");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    if (i == j) {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"[ {matriz[i, j]} ]");
                    }
                    else {
                        Console.ResetColor();
                        Console.Write($"[ {matriz[i, j]} ]");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}