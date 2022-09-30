namespace QuartoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*

             4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por
                dois professores e o valor por hora recebido por cada um deles. 
                Mostrar na tela qual dos professores tem o maior salário total.

             */

            double qtdHorasMinistradasPeloProfessorUm = 0;
            double qtdHorasMinistradasPeloProfessorDois = 0;
            double valorHoraRecebidoPeloProfessorUm = 0;
            double valorHoraRecebidoPeloProfessorDois = 0;

            Console.Write("Quantidade de horas ministradas pelo primeiro professor: ");
            qtdHorasMinistradasPeloProfessorUm = double.Parse(Console.ReadLine());

            Console.Write("Valo hora recebido professor um: ");
            valorHoraRecebidoPeloProfessorUm = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de horas ministradas pelo segundo professor: ");
            qtdHorasMinistradasPeloProfessorDois = double.Parse(Console.ReadLine());

            Console.Write("Valo hora recebido professor dois: ");
            valorHoraRecebidoPeloProfessorDois = double.Parse(Console.ReadLine());

            double calcUm = (valorHoraRecebidoPeloProfessorUm * qtdHorasMinistradasPeloProfessorUm);
            double calcDois = (valorHoraRecebidoPeloProfessorDois * qtdHorasMinistradasPeloProfessorDois);
           
            if(calcUm > calcDois) {

                Console.WriteLine("\nProfessor um tem o maior salario: "+calcUm.ToString("C"));
            }
            else {

                Console.WriteLine("\nProfessor dois tem o maior salario: "+calcDois.ToString("0.0"));
            }

            Console.ReadKey();

        }
    }
}