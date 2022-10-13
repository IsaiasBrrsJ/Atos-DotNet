using Listas.classe;
using System.Security.Cryptography;

namespace Listas
{
    internal class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(40, "Ricardo"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));

            ListaInserirItemPosicao();
            Console.WriteLine("=====");
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " "+ p.Idade);
            }
            Console.WriteLine("=====");
            ListaNaoOrdenada();
            Console.WriteLine("=====");
            ListaOrdenadaPorNome();
            Console.WriteLine("=====");
            ListaOrdenadaPorIdade();
            Console.WriteLine("=====");
            ListaLocalizaPessoaMaisJovem();



        }
        static void ListaNaoOrdenada()
        {
            Console.WriteLine("Lista não Ordenada");

            pessoas.ForEach((p) =>
            {
                Console.WriteLine(p.Idade + " "+ p.Nome);
            });
        }
        static void ListaOrdenadaPorNome()
        {   
            // ordenando por nome
            Console.WriteLine("Lista Ordenada por Nome");
            pessoas.Sort((p1, p2) =>
            {
                return p1.Nome.CompareTo(p2.Nome);
            });

            pessoas.ForEach((p) =>
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
        }

        static void ListaOrdenadaPorIdade()
        {   
            //ordenando por idade
            Console.WriteLine("Lista Ordenada por idade");

            pessoas.Sort((p1, p2) =>
            {
                return p1.Idade.CompareTo(p2.Idade);
            });

            pessoas.ForEach((p1) =>
            {
                Console.WriteLine(p1.Idade + " " + p1.Nome);
            });
        }
        static void ListaInserirItemPosicao()
        {   // inserir em uma posição especifica da lista
            Console.WriteLine("Inserindo uma pessoa na posição 1 e outra na posição 3");
            pessoas.Insert(1, new(idade: 78, nome: "Bob Dylan"));
            pessoas.Insert(3, new(idade: 81, nome: "Jimmi Page"));
        }

        static void ListaLocalizaPessoaMaisJovem()
        {
            // vair adcionar na lista jovem todos pessoas que tem menos que 45 anos;
            List<Pessoa> jovem = pessoas.FindAll((p) =>
            {
                return p.Idade < 45;
            });

            Console.WriteLine("Idade é menor que 45");
            jovem.ForEach((p) =>
            {
                Console.WriteLine(p.Nome + " "+p.Idade);
            });
        }
    }
}