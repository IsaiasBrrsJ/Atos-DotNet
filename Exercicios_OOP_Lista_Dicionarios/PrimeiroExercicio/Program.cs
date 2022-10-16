using PrimeiroExercicio.Classes;

namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
            //   O programa deverá informar o nome do personagem que possuir o maior poder.
            //   Regras que deverão ser seguidas para a implementação do algoritmo:
            //   É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como
            //   propriedades(características) um nome e um poder.
            //   A classe também deverá possuir um método chamado ExibirDados.
            //   Esse método deverá exibir o nome e o poder do personagem em questão.
            //   Ao implementar a classe é obrigatório implementar dois construtores(Sobrecarga),
            //   um que não recebe parâmetro algum e outro que
            //   irá receber o nome e o poder de um personagem
          
            Personagem p = new Personagem("Madara", 12);
            for (int i = 1; i < 3; i++)
            {
                int poder = -1;
                Console.Write("Informe o nome Do Personagem: ");
                string nomePersonagem = Console.ReadLine();

                do
                {
                    Console.Write("Informe o poder do Personagem: ");

                } while ((int.TryParse(Console.ReadLine(), out poder) == false) || (poder < 0 || poder > 10));

                p.AddPersonagens(nomePersonagem, poder);
            }


            p.ExibirDados();

            Console.ReadKey();

        }
    }
}