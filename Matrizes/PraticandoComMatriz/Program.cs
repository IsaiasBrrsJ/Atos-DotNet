using System.Transactions;

namespace PraticandoComMatriz {
    internal class Program {
        static void Main(string[] args) {

            int[,] matriz = new int[2, 3];

            // matriz.GetLength(0) obtém o tamanho de elementos da linha;
            // matriz.GetLength(1) obtém o tamanho de elementos da coluna

            //for (int i = 0; i < matriz.GetLength(0); i++) {
            //    for (int j = 0; j < matriz.GetLength(1); j++) { 
            //      Console.Write($"Digite [{i + 1}, {j + 1}]: ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());

            //    }  
            //}
            
            /*
    
            Console.ReadKey();
        }
    }
}