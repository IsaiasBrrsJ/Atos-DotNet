using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SetimoExercicio.Classes
{
    class Livro
    {
        private string _nomeLivro;
        private int _qtdPaginas;
        private Dictionary<string, int> livro = new Dictionary<string, int>();
        public string NomeLivro
        {
            get => _nomeLivro; 
            set { _nomeLivro = value; }
        }
        public int qtdPaginas{
            get => _qtdPaginas;
            set { _qtdPaginas = value; }
        }

        public bool adcionarLivros()
        {
            
            if (!livro.Keys.Contains(_nomeLivro))
            {
                livro.Add(_nomeLivro, _qtdPaginas);
                return true;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tLivro já cadastrado\n");
                Console.ResetColor();

                return false;
            }
        }
        public void ConsultarTodosOsLivrosCadastrados()
        {
            Program.LogoLivraria();

            if (livro.Count > 0)
            {
                int count = 1;
                foreach (KeyValuePair<string, int> livros in livro)
                {
                    Console.WriteLine("\n\t============= Livros =============\n"+"\t"+count++ +"º");
                    Console.WriteLine("\tNome do livro: " + livros.Key);
                    Console.WriteLine("\tQuantidade de páginas: " + livros.Value);
                    Console.WriteLine("\t==================================\n");
                }
            }
            else
            {
                Console.WriteLine("\tNão foram encontrados livros cadastrados");
            }

            Console.ReadKey();
        }
        public void ConsultarLivroPeloNome()
        {
           
            Program.LogoLivraria();
            
            Console.Write("\tDigite o nome do livro que deseja encontrar: ");
            string nomeLivro = Console.ReadLine();

            var resultado = livro.FirstOrDefault((livro) => (livro.Key.Equals(nomeLivro)));
            if (resultado.Key != null){

                Console.WriteLine("\tNome: " + resultado.Key + "\n\tQuantidade de páginas: " + resultado.Value);
            }
            else{
                Console.WriteLine("\tLivro Não encontrado");
            }

            Console.ReadKey();
        }
    }
}
    