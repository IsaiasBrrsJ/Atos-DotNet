namespace DecimoSetimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //18) Desafio: Fazer um algoritmo que leia uma matriz de 10
            //linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da
            //linha onde se encontra o 
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

            int[,] matrizA = new int[10, 10];
            int minimax = 0;
            int coluna = 0;
            string resultado = "";

            for (int i = 0; i < matrizA.GetLength(0); i++) {

                for (int j = 0; j < matrizA.GetLength(1); j++) {
                    Console.Write($"Digite: [{i},{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());

                    if (matrizA[i, j] > minimax) {

                        minimax = matrizA[i, j];
                        coluna = j;
                    }
                }
            }

            for (int i = 0; i < matrizA.GetLength(0); i++) {
                for (int j = 0; j < matrizA.GetLength(1); j++) {
                    if (j == coluna && matrizA[i, j] < minimax) {
                        minimax = matrizA[i, j];
                        resultado = $"\nMenor elemento {minimax} se encontra na Linha {i}, Coluna: {j}";
                    }
                }
            }

            Console.WriteLine(resultado);
            Console.ReadKey();


        }
    }
}