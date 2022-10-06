using static System.Net.Mime.MediaTypeNames;

namespace ExercicioDois {
    internal class Program {
        static void Main(string[] args) {

            /*
             2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa.
                 Faça métodos para apresentar os dados
                 Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.  
             */

            //Nome = nome;
            //Altura = altura;
            //Idade = idade;
            //CorDosOlhos = corDosOlhos;
            //TipoCabelo = tipoDeCabelo;
            //CorDoCabelo = corDoCabelo;
            //CorDaPele = corDaPele;

            string nome, corOlhos, tipoCabelo, corCabelo, corPele;
            float altura;
            int idade;
            Pessoa pessoa;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe sua altura: ");
             altura = float.Parse(Console.ReadLine());

            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Informe a cor dos seus olhos: ");
            corOlhos = Console.ReadLine();

            Console.Write("Informe o tipo do seu cabelo: ");
             tipoCabelo = Console.ReadLine();

            Console.Write("Informe a cor dos seus cabelos: ");
            corCabelo = Console.ReadLine();

            Console.Write("Informe sua cor de pele: ");
            corPele = Console.ReadLine();

            pessoa = new Pessoa(nome, altura, idade, corOlhos, tipoCabelo, corCabelo, corPele);

            Console.WriteLine("\nInformações\n");
            pessoa.ExibirAtributos();


            Console.ReadKey();
        }
    }
}