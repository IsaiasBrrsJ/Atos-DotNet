namespace TerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na
             tela o índice da posição dos valores correspondentes a números primos.
             */

            int[] vet = new int[20];
            string resultado = "";
            for (int i = 0; i < 20; i++) {
                Console.Write("Digite o {0}° valor: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());

            }// falta concluir

            Console.WriteLine();
        }
    }
}