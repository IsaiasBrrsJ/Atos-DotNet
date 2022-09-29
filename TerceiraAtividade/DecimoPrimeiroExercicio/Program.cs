namespace DecimoPrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             
             11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
                 a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
             */

            double notas = 0;
            double media = 0;
            double maiorNota = 0;
            double menorNota = 0;
            int qtdAlunosTurma = 0;

            for (int i = 0; i >= 0; i++) {

                Console.WriteLine("\nDigite -1 para encerrar..\n");
                Console.Write($"Informe a {i + 1}º Nota: ");
                if (double.TryParse(Console.ReadLine(), out notas) is false || (notas < -1 || notas > 10)){
                    i--;                 
                    Console.Clear();
                    continue;
                }
                else if (notas >= 0.0) {
                    qtdAlunosTurma++;
                    media += notas;
                }
                else {
                    break;
                }


                if (notas > maiorNota) {
                    maiorNota = notas;
                }

                if (menorNota == 0) {
                    menorNota = notas;
                }
                else {
                    if(menorNota > notas) {
                        menorNota = notas;
                    }
                }
            }


            Console.WriteLine($"\nMaior nota: {maiorNota}\nNota mais baixa: {menorNota}\n" +
                $"Média aritmética da turma: {(media / qtdAlunosTurma).ToString("0.00")}\n" +
                $"Quantidade de alunos da turma: {qtdAlunosTurma}");

            Console.ReadKey();
        }
    }
}