namespace DecimoSegundoExercicio {
    internal class Program {
        static void Main(string[] args) {


            //12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
            //      Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".


            int[] vet = new int[10];
            int numPesquisa = -1;
            int count = 0;
            string resultado = "O número fornecido não existe no vetor!";

            while (count < vet.Length) {
                vet[count] = new Random().Next(0 ,22);
                count++;
            }

            Console.Write("Digite o numero que deseja procurar: ");
             numPesquisa = int.Parse(Console.ReadLine());

            for (int i = 0; i < vet.Length; i++) {

                if (numPesquisa == vet[i]) {
                    resultado += $"\nO número se encotra na posição(ões): {i}\n";
                }
               
            }

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}