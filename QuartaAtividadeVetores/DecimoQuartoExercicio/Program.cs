namespace DecimoQuartoExercicio {
    internal class Program {
        static void Main(string[] args) {


            //14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números.
            //Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido.
            //Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

            int[] vet = new int[10];
            int count = 0;
            string resultado = "";
            string tipoDeExibicao = "";
           
            while (count < vet.Length) {

                Console.Write("Digite o {0} valor: ", count + 1);
                 vet[count] = int.Parse(Console.ReadLine());
                count++;
            }


            while (true) {

                Console.Write("\n0- Encerrar\n1- Exibir Vetor\n2- Exibir Vetor Inverso\nEscolha: ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha is 0 || escolha > 2) {
                    Environment.Exit(0);
                }
                else if ((escolha <= 0 || escolha > 2)) {
                    Environment.Exit(0);
                }
                else if (escolha == 1) {
                    tipoDeExibicao = "\n---- Valores no vetor ------";

                    for (int i = 0; i < vet.Length; i++) {
                        resultado += $"{vet[i]} |";
                    }
                }
                else {
                    tipoDeExibicao = "\n---- Valores na ordem inversa do vetor ------";

                    for (int i = vet.Length - 1; i >= 0; i--) {
                        resultado += $"{vet[i]} |";
                    }
                }

                Console.WriteLine(tipoDeExibicao + "\n" + resultado);
                Console.ReadKey();
                resultado = "";
            }

         
        }
    }
}