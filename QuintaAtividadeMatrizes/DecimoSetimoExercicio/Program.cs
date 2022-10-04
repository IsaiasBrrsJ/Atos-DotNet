namespace DecimoSetimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //18) Desafio: Fazer um algoritmo que leia uma matriz de 10
            //linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da
            //linha onde se encontra o 
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

            int[,] matriz = new int[2, 2];
            int posLinhaMenor = -1;
            int maiorElemento = 0;
            string posOndeFoiEncontrador = "";
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {

                    Console.Write($"Digite [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (posLinhaMenor == -1) {
                        posLinhaMenor = i;
                    }
                    else {
                        if (posLinhaMenor < matriz[i, j])
                            posLinhaMenor = i;
                    }


                    if (matriz[i, j] > maiorElemento) {
                        posOndeFoiEncontrador = $"O maior foi encontrado na linha {i} Coluna {j}";
                    }
                }

              
            }

            Console.WriteLine("Menor número encontrado está na linha: " + posLinhaMenor);
            Console.WriteLine();
            Console.WriteLine("\n"+posOndeFoiEncontrador);
            Console.ReadKey();
        }
    }
}