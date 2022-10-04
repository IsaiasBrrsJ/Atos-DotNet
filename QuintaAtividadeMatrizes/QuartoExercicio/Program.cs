namespace QuartoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             4) Popule uma matriz 5x5 e informe:
                -Quantos números são pares
                -Quantos números são impares
                -Quantos números são positivos
                -Quantos números são negativos
                -Quantos zeros existem!
             
             */

            int[,] matriz = new int[5, 5];
            int qtdZeros = 0;
            int qtdPares = 0;
            int qtdImpares = 0;
            int qtdPositivos = 0;
            int qtdNegativos = 0;


            for (int i = 0; i < 5; i++) {

                for (int j = 0; j < 5; j++) {

                    Console.Write($"Linha {i + 1} Coluna: {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] == 0) {
                        qtdZeros++;
                    }
                    else if (matriz[i, j] % 2 == 0) {

                         qtdPares++;   
                    }
                   else if (matriz[i,j] % 2 != 0) {
                        qtdImpares++;
                    }


                    if (matriz[i, j] < 0) {
                        qtdNegativos++;
                    }
                    else {
                        qtdPositivos++;
                    }
  
                }
            }
            Console.WriteLine($"Quantidade de pares: {qtdPares}");
            Console.WriteLine($"Quantidade de Ímpares: {qtdImpares} ");
            Console.WriteLine($"Quantidade de zeros: {qtdZeros} ");
            Console.WriteLine($"Quantidade de negativos: {qtdNegativos}");
            Console.WriteLine($"Quantidade de positivos: {qtdPositivos}");

            Console.ReadKey();


        }
    }
}