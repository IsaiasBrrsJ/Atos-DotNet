namespace maiorValorDoVetor {
    internal class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];

            int i, maior = 0, menor = 0, pos =-1, posMenorValor = -1;

            //laco para leitura dos elementos;
            for (i = 0; i < 10; i++) {

                Console.Write("Digite o valor do {0} elemento: ", i+1);
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] > maior) {// verifica maior elemento
                    pos = i;
                    maior = vetor[i];
                }

                if (menor == 0) {
                    menor = vetor[i];
                }// verifica menor elemento do vetor;
                else {
                    if (menor > vetor[i]) {
                        posMenorValor = i;
                        menor = vetor[i];
                    }
                }
            }

            Console.WriteLine("\nMaior " + maior+" e está na posição "+pos);
            Console.WriteLine("Menor valor do vetor é: " + menor+" e está na posição "+posMenorValor);
            Console.ReadKey();
        }
    }
}