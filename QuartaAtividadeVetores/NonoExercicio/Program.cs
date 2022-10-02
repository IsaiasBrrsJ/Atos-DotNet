namespace NonoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e
            //em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

            int[] vet = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.Write("Digite o {0} numero: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++) {
                for (int j = i + 1; j < 10; j++) {

                    if (vet[i] > vet[j]) {

                        int pos = vet[i];

                        vet[i] = vet[j];
                        vet[j] = pos;

                    }
                }
            }
            Array.ForEach(vet, arr => Console.WriteLine(arr));
            Console.ReadKey();
        }
    }
}