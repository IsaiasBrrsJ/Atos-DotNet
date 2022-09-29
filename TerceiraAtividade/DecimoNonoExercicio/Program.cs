namespace DecimoNonoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
                coletando dados sobre o salário e número de filhos. A prefeitura deseja saber:
                    a) média do
                        salário da população;
                    b) média do
                        número de filhos;
                    c) maior salário;
                    d) percentual de pessoas com salário até R$ 100,00.
             O final da leitura de dados se dará com a entrada de um salário negativo.

                         */


            double salario = 0;
            int numeroDeFilhos = 0;
            double mediaDoSalario = 0;
            double mediaDoNumeroDeFilhos = 0;
            double maiorSalario = 0;
            double percentualPessoasComSalarioAteCemReais = 0;
            int qtdDePessoasInseridas = 0;
            int numFilho = 0;
            int pessoasComSalarioAteCem = 0;

            while (true) {

                Console.WriteLine("Digite uma saldo negativo para encerrar..\n");

                Console.Write("Digite seu salário: ");
                 salario = double.Parse(Console.ReadLine());

                if (salario <= 0.0) {
                    break;
                }

                Console.Write("Informe quantos filhos você possui: ");
                numeroDeFilhos = int.Parse(Console.ReadLine());

                if (numeroDeFilhos > 0) {
                    numFilho++;
                }

                qtdDePessoasInseridas++;
                


                mediaDoSalario += salario;
                mediaDoNumeroDeFilhos += numeroDeFilhos;

                if (salario > maiorSalario) {
                    maiorSalario = salario;
                }

                if (salario <= 100) {
                    percentualPessoasComSalarioAteCemReais++;
                }
            
            }

            Console.WriteLine($"\nMédia de salário da população: {(mediaDoSalario / qtdDePessoasInseridas).ToString("C")}\n" +
                $"Média número de filhos: {(mediaDoNumeroDeFilhos / numFilho).ToString("0.0")}\n" +
                $"Maior Salario: {maiorSalario.ToString("C")}\n" +
                $"Percentual de pessoas com salário de até 100.00 R$: {((percentualPessoasComSalarioAteCemReais * 100) / 100).ToString("0.0")}");

            Console.ReadKey();
        }
    }
}