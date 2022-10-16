using QuintoExercicio.Classes;

namespace QuintoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5) Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
                tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
                um método para exibir um objeto (x,y).
                Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
                os objetos da lista.
             */

            PlanoCartesiano cartesiano = new PlanoCartesiano();

            int cont = 0;

            while(cont < 10)
            {
                cartesiano.X = new Random().NextDouble();
                cartesiano.Y = new Random().NextDouble();
                cartesiano.AdcionarNaLista();
                cont++;
            }
            cartesiano.ExibirLista();

            Console.ReadKey();
        }
    }
}