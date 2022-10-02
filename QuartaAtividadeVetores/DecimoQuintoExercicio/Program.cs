namespace DecimoQuintoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*

             15.	Faça um programa em C# que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor,
                    e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim,
                    o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo.
                    Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
             */
            int[] vet = new int[20];
            int[] vetDois = new int[vet.Length];


            for (int i = 0; i < vet.Length; i++) {

                Console.Write($"Digite o  {i + 1} valor: ");
                 vet[i] = int.Parse(Console.ReadLine());

                vetDois[i] = vet[i];
            }

            Console.WriteLine("\n---- Primeiro Vetor ----");
            for (int i = vet.Length-1; i > 0; i--) {

                Console.Write($"{vet[i]} |");

            }

            Console.WriteLine("\n---- Segundo Vetor ----");
            for (int i = 0; i < vetDois.Length; i++) {

                Console.Write($"{vet[i]} |");

            }


            Console.ReadKey();



        }
    }
}