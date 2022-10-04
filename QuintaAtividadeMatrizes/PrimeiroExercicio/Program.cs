using System.Globalization;

namespace PrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            //1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
            //A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.



            int[,] matriz = new int[5, 3];

            for (int i = 0; i < 5; i++) {
                Console.Write($"Informe o valor da {i + 1} linha: ");
                matriz[i, 0] = int.Parse(Console.ReadLine()); // valores primeria coluna

                matriz[i, 1] = matriz[i, 0] + 10; // valores segunda coluna
                matriz[i, 2] = matriz[i, 0] * 2; // valores terceira coluna
            }


            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();


    }   }
}