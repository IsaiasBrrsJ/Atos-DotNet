namespace ExplicacaoMatriz {
    internal class Program {
        static void Main(string[] args) {


            int[,] matriz = new int[3, 3];
            //preencher a matriz            for (int i = 0; i < 3; i++)
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                
            }

            //mostrando o conteúdo da matríz            for (int i = 0; i < 3; i++)

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }

            //diagonal principal 
            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < 3; j++) {

                    if (i == j) {
                        matriz[i, j] = matriz[i, j] * 2;
                    }
                }
            }
            Console.WriteLine();

            //mostrando o conteúdo matriz
            //for (int i = 0; i < 3; i++) {
            //    matriz[i, i] = matriz[i, i] * 2;
            //}
            Console.WriteLine();
            //mostrando o conteúdo da matríz            for (int i = 0; i < 3; i++)

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}