namespace PrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            //1.	Escreva um algoritmo que leia os valores
            //para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int[] vet = new int[10];
            int qtdPares = 0;
            int qtdImpares = 0;

            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0) {
                    qtdPares++;
                }
                else {
                    qtdImpares++;
                }
            }

            Console.WriteLine("\nQuantidade de numeros pares: " + qtdPares);
            Console.WriteLine("\nQuantidade de numeros impares: " + qtdImpares);

            Console.ReadKey();
;        }
    }
}