namespace DecimoQuartoExercicio {
    internal class Program {
        static void Main(string[] args) {

            //14) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5)
            //e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
            //diagonal secundária.

            int[,] matriz = new int[4, 4];
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            Console.WriteLine("Preencha a matriz \n");
            for (int i = 0; i < matriz.GetLength(0); i++) {

                for (int j = 0; j < matriz.GetLength(1); j++) {

                    Console.Write($"Digite [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            }
            
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {

                    if (i == j) {
                        somaDiagonalPrincipal += matriz[i,j];
 ;
                    }
                    if ((i + j) == 3 ){
                                
                        somaDiagonalSecundaria += matriz[j, i];
                    }
                }
            }

         
            if (somaDiagonalPrincipal == somaDiagonalSecundaria) {
                Console.WriteLine("A soma da diagonal princiapl e diagonal secundária são iguais");
            }
            else {
                Console.WriteLine("A soma da diagonal principal e diagonal secundária não são iguais");
            }

            Console.ReadKey();
        }
    }
}