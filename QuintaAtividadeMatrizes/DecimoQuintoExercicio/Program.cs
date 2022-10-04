namespace DecimoQuintoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             15) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da
               diagonal principal (da esquerda para a direita) são os mesmos da diagonal 
                secundária (direita pra esquerda).
             */

            int[,] matriz = new int[2, 2];
            string principal = "";
            string secundaria = "";
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {

                    Console.Write($"Digite {i},{j}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            

            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {

                    if (i == j) {
                        principal += $"{matriz[i, j]} ";
                    }

                    if ((i + j) == 1) {
                        secundaria += $"{matriz[i, j]} ";
                    }
  
                }
            }

            if (principal.Contains(secundaria)) {
                Console.WriteLine("São os mesmos da diagonal secundária");
            }
            else {
                Console.WriteLine("Diagona e principal, não são iguais");
            }


            Console.ReadKey();

            Console.ReadKey();
        }
    }
}