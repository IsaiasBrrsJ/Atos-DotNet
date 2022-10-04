namespace DecimoPrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            //11) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos,
            //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média

            int[,] A = new int[4, 4];
            int[,] B = new int[4, 4];
            double media = 0;
            int abaixoMedia = 0;
            int acimaMedia = 0;
            int naMedia = 0;

            Console.WriteLine("\nMatriz A\n");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    Console.Write($"Preencha [{i + 1},{j + 1}]: ");
                     A[i, j] = int.Parse(Console.ReadLine());
                    media += A[i, j];
                }
            }

            Console.WriteLine("\nMatriz B\n");
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    Console.Write($"Preencha [{i + 1},{j + 1}]: ");
                     A[i, j] = int.Parse(Console.ReadLine());
                    media += B[i, j];
                }
            }

             media = Math.Ceiling(media / 32);
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {


                    if ((A[i, j] == media || B[i, j] == media)) {
                        naMedia++;
                    }
                    
                    if ((A[i, j] < media || B[i, j] < media)) {
                        abaixoMedia++;
                    }
                    
                    if (((A[i, j] > media || B[i, j] > media))) {
                            acimaMedia++;
                    }
                   
                }
            }

            Console.WriteLine("Elementos abaixo da média: " + abaixoMedia);
            Console.WriteLine("Elementos acima da média: " + acimaMedia);
            Console.WriteLine("Na média: " + naMedia);

            Console.ReadKey();
            

        }
    }
}