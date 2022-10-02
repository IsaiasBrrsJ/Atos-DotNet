namespace TerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na
             tela o índice da posição dos valores correspondentes a números primos.
             */

            int[] vet = new int[5];
            int contador = 0;
            string resultado = "";
            for (int i = 0; i < 5; i++) {
                Console.Write("Digite o {0}° valor: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());

               
            }

            for (int i = 0; i < 5; i++) {
                int count = 0;


                for (int x = 1; x <= vet[i]; x++) {

                    if (vet[i] % x == 0) {

                        count++;
                    }
                }

                if (count is 2) {

                    resultado += $"{vet[i]} ";
                }
            }
         

            Console.WriteLine("Posição dos valores correspondentes a números primos: "+ resultado);

            Console.ReadKey();
        }
    }
}