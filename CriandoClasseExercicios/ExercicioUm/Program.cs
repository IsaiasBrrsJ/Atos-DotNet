namespace ExercicioUm {
    internal class Program {
        static void Main(string[] args) {

            /*
              1 - Crie uma classe Livro que represente os dados básicos de um livro.
               Faça a leitura pelo teclado dos atributos e crie um construtor para fazer o instanciamento.  
            */
 
            Console.Write("Titulo Livro: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Editora: ");
            string editora = Console.ReadLine();

            Console.Write("Ano de Lançamento: ");
            string anoLancamento = Console.ReadLine();

            Console.Write("Tipo de capa: ");
            string tipoCapa = Console.ReadLine();

            Console.Write("Valor do livro: ");
            decimal valorLivro = decimal.Parse(Console.ReadLine());


            Livro livro = new Livro(titulo, autor, editora, anoLancamento, tipoCapa, valorLivro);
               
        }
    }
}