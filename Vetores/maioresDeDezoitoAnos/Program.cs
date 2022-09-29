namespace maioresDeDezoitoAnos {
    internal class Program {
        static void Main(string[] args) {
            int[] idade = new int[40];

            int i, conta = 0;

            Console.WriteLine("Informe as idades dos alunos da turma:");
            for (i = 0; i < 40; i++) {
                idade[i] = int.Parse(Console.ReadLine());
                if (idade[i] >= 18) {
                    conta++;
                }
            }

            Console.WriteLine("Existem "+conta+" alunos com idade maior ou igual a 18 anos");
            for (i = 0; i < 40; i++) {
                if (idade[i] > 18) {
                    Console.WriteLine("Aluno " + i + " tem " + idade[i] + " anos");
                }
            }

            Console.ReadKey();
        }
    }
}