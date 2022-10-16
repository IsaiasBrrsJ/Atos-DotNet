using SegundoExercicio.Classes;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SegundoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2) Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
                O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.
                Regras que deverão ser seguidas para a implementação do programa:
                Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
                Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
                É obrigatório criar uma classe para representar o Animal.
                A classe deverá possuir dois dados privados (propriedades) 
                para representar as características do animal.
                A classe deverá possuir métodos de acesso (propriedade getter e setter)
                para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
             */

            Animal animal = new Animal();

            Console.WriteLine("Informe o nome e tipo de animal\n");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("{0}º animal", i);
                Console.Write("Nome: ");
                 animal.Nome = Console.ReadLine();

                do {
                    Console.WriteLine("\nTipos Aceitos, Gato, Cachorro, Peixe");
                    Console.WriteLine("Digite o seu: ");
                     animal.Tipo = Console.ReadLine().ToUpper();

                    if((animal.Tipo != "GATO") && (animal.Tipo != "CACHORRO") && (animal.Tipo != "PEIXE"))
                    {
                        Console.WriteLine("Tipo Inválido, Pressione qualquer tecla para tentar novamente...");
                         Console.ReadKey();
                        Console.Clear();
                    }
                    else { break; }

                } while (true);
                
                animal.AdcionarAnimais();
                Console.Clear();
            }

            animal.ExibirContagemAnimais();
        }
    }
}