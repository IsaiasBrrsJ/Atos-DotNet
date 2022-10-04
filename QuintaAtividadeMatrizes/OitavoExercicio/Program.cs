using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;

namespace OitavoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //9) Ler uma matriz com 4x4 de inteiros e mostrar os números na
            //ordem direta e inversa a que foram lidos.

            //ainda concluindo

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++) {

                for (int j = 0; j < 4; j++) {

                    Console.Write($"Digite os valores [{i + 1},{j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("\n--------- Ordem Direta ----------");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"[{matriz[i, j]}]");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine("\n-------- Ordem Inversa ------------");

            for (int i = 3; i >= 0; i--) {

                for (int j = 3; j >= 0; j--) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"[{matriz[i, j]}]");
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}