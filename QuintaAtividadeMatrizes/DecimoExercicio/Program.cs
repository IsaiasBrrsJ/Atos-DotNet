namespace DecimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             10) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e
                 pesquise na matriz se o número existe.  
                 Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , 
                 caso contrário “Número inexistente”.
             */

            int[,] matriz = new int[3, 3];
            int numPesquisa = -1;
            string resultado = "Número inexistente";
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write($"Digite  [{i+1},{j+1}]: ");
                     matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Digite um número que deseja pesquisar: ");
             numPesquisa = int.Parse(Console.ReadLine());


            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (numPesquisa == matriz[i, j]) {
                        resultado = "O número existe no vetor";
                        break;
                    }
                }
            }

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}