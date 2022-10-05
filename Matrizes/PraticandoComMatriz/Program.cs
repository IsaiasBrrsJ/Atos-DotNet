using System.Transactions;

namespace PraticandoComMatriz {
    internal class Program {
        static void Main(string[] args) {

            //int[,] matriz = new int[2, 2];

            // matriz.GetLength(0) obtém o tamanho de elementos da linha;
            // matriz.GetLength(1) obtém o tamanho de elementos da coluna

            //for (int i = 0; i < matriz.GetLength(0); i++) {
            //    for (int j = 0; j < matriz.GetLength(1); j++) { 
            //      Console.Write($"Digite [{i + 1}, {j + 1}]: ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());

            /*
             14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os
                 elementos da diagonal principal (da esquerda para a direita)
                são os mesmos da diagonal 
                secundária (direita pra esquerda).
             */

            int[,] matrizB = new int[4, 4];

            for (int i = 0; i < 4; i++) {

                for (int j = 0; j < 4; j++) {
                    Console.Write($"Digite [{i},{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    Console.Write($"[{matrizB[i, j]}]");
                    if (i + j == 2) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"[{matrizB[i, j]}]");
                        Console.ResetColor();
                    }
                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}