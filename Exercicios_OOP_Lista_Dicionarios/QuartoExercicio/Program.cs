using QuartoExercicio.Classe;

namespace QuartoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4) Crie uma classe para representar um item de cenário, com os atributos privados de:
                * descrição (string), 
                * data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
                * altura (float). 

                Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
                todos dados de um item de cenário. 
                Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
                a classe criada.
            */

            Cenario cenario = new Cenario();

            cenario.setDescricao("cenario futurama");
            cenario.setAltura(3.4f);
            cenario.setData(new DateTime(year: 2022, month: 10, day: 12));

            cenario.ImprimeItensDoCenario();

            cenario.AhQuantoTempoOItemFoiCriado();

            Console.ReadKey();
        }
    }
}