using SetimoExercicio.Classes;

namespace SetimoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              7) Crie um dicionário que faça o armazenamento de Livros. Os dados para serem armazenados serão
                o nome do livro e a quantidade de páginas. Em um menu inicial, possibilite que o usuário do
                sistema possa cadastrar, consultar todos livros cadastrados ou pesquisar pelo nome do livro.
             
             */
            Livro livro = new Livro();
            Menu(); 
        }
       public static void LogoLivraria()
        {
            Console.Clear();

            Console.WriteLine("\t=============================");
            Console.WriteLine("\t      Livraria Trindade");
            Console.WriteLine("\t=============================\n");
        }
        static void Menu()
        {
            Livro livro = new Livro();
            do
            {
                Console.Clear();

                LogoLivraria();
                Console.WriteLine("\t[1]-Cadastrar Livro\n\t[2]-Consultar todos o livros cadastrados\n\t[3]-Consultar pelo nome do livro\n\t[4]-Sair\n");
                Console.Write("\tOpção: ");
                string opc = Console.ReadLine();


                switch (opc)
                {   
                    case "1":
                        CadastrarLivro(ref livro);
                        break;
                    case "2":
                        livro.ConsultarTodosOsLivrosCadastrados();
                        break;
                    case "3":
                        livro.ConsultarLivroPeloNome();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n\tOpção incorreta, pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }


            } while (true);
        }
        static void CadastrarLivro(ref Livro livro)
        {
           

            while (true)
            {
                Console.Clear();
                LogoLivraria();

                Console.Write("\tNome do livro: ");
                livro.NomeLivro = Console.ReadLine();

                bool entrouNoCatch = false;
                while(true)
                {
                    Console.Write("\tQuantidade de páginas: ");
                    try
                    {
                        livro.qtdPaginas = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        entrouNoCatch = true;
                        Console.WriteLine("\tDigite um número de páginas... Pressione para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    if(entrouNoCatch is true) { entrouNoCatch = false; continue; }
                    else { break; }
                }

                livro.adcionarLivros();

                CONTINUAR:
                Console.Write("\n\tContinuar Cadastrando [1]-Sim/[2]-Não\n\tDigite: ");
                string continuar = Console.ReadLine();
                if (continuar != "2" && continuar != "1")
                {
                    goto CONTINUAR;
                }
                else if (continuar == "2") { break; }
                else { }
            }

        }

    }
}