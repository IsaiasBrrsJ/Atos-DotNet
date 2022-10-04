namespace SextoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9.
                 Após isso determine o maior número da matriz.
                Random random = new Random();
                int randomNumber = random.Next(0, 100);
             */

            int[,] M = new int[4, 4];
            int maiorNumero = 0;

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {

                    M[i, j] = new Random().Next(0, 10);
                    Console.Write($"[ {M[i, j]} ]");
                    if (M[i, j] > maiorNumero) {
                        maiorNumero = M[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMaior numero da matriz: "+maiorNumero);
            Console.ReadKey();


        }
    }
}