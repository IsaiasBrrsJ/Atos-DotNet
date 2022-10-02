namespace DecimoTerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            //13.	Escreva um algoritmo para ler um vetor de inteiros e
            //positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições.
            //Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

            int[] vet = new int[100];
            int qtdVezesQueOsNumerosDoisQuatroOitoAparecemNoVetor = 0;
            int count = 0;

            while (count < vet.Length) {
                vet[count] = new Random().Next(-1, 200);
     
                if (vet[count] == -1) {
                    break;
                }

                count++;
            }

            for (int i = 0; i < vet.Length; i++) {
                if (((vet[i] == 2) || (vet[i] == 4)) || vet[i] == 8) {
                    qtdVezesQueOsNumerosDoisQuatroOitoAparecemNoVetor++;
                }
            }

            Console.WriteLine("Os números 2, 4 e 8 aparecem no vetor: " + qtdVezesQueOsNumerosDoisQuatroOitoAparecemNoVetor + " Vez(es)");
            Console.ReadKey();
        }
    }
}