using System.Runtime.ConstrainedExecution;

namespace DecimoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
                Número de pessoas do sexo masculino.
                Número de pessoas do sexo feminino.
                Número de pessoas com idade inferior a 30 anos.
                Número de pessoas com idade superior a 60 anos.
                Média de idade das mulheres.
             
             */

            string nome = "";
            string sexo = "";
            double mediaIdadeMulheres =0;
            int qtdDeMulheresCadastradas = 0;
            int qtdDeHomensCadastrados = 0;
            int qtdPessoasComMaisDeSessentaAnos = 0;
            int qtdPessoasComIdadeInferiorATrintaAnos = 0;
            int idade = 0;
            bool idadeOk = true;
           
            for (int i = 0; i < 50; i++) {

                do {
                    Console.WriteLine($"Ler nome, sexo e idade de 50 pessoas, restam: {50 - i } Pessoas\n");

                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();

                    Console.Write("Digite seu sexo (F)feminino ou (M)masculino: ");
                    sexo = Console.ReadLine().ToUpper();

                    Console.WriteLine("Digite sua Idade: ");
                    idadeOk = int.TryParse(Console.ReadLine(), out idade);

                    if (( (nome is "" && nome is " ") || (sexo != "F" && sexo != "M") ) && ( idade <= 0 || idadeOk is false) ) {

                        Console.WriteLine("\nPreencha os dados corretamente...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else {
                        break;
                    }

                } while (true);

                if (sexo is "F") {

                    qtdDeMulheresCadastradas++;
                    mediaIdadeMulheres += idade;
                }
                else {
                    qtdDeHomensCadastrados++;
                }

                if (idade > 60) {
                    qtdPessoasComMaisDeSessentaAnos++;
                }
                else {
                    if (idade < 30) {
                        qtdPessoasComIdadeInferiorATrintaAnos++;
                    }
                }
             }
            Console.WriteLine($"\n\nNúmero de pessoas do sexo masculino: {qtdDeHomensCadastrados}\n" +
                $"Número de pessoas do sexo feminino: {qtdDeMulheresCadastradas}\n" +
                $"Número de pessoas com idade inferior a 30 anos: {qtdPessoasComIdadeInferiorATrintaAnos}\n" +
                $"Número de pessoas com idade superior a 60 anos: {qtdPessoasComMaisDeSessentaAnos}\n" +
                $"Média de idade das mulheres: {(mediaIdadeMulheres / qtdDeMulheresCadastradas).ToString("0.0")}");

            Console.ReadKey();
        }
    }
}