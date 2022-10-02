namespace QuintoExercicio {
    internal class Program {
        static void Main(string[] args) {



            //5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros.
            //Encontre e mostre o menor elemento e a sua posição.


            int[] vet = new int[5];
            int pos = 0;
            int menorElemento = 0;

            for (int i = 0; i < 5; i++) {
               
                Console.Write("Informe o {0} valor: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());

                if (menorElemento == 0) {
                    menorElemento = vet[i];
                }
                else {
                    if (menorElemento > vet[i]) {
                        menorElemento = vet[i];
                        pos = i;
                    }
                }

            }

            Console.WriteLine("Menor elemento: {0}, sua posicao: {1}", menorElemento, pos);

            Console.ReadKey();
        }
    }
}