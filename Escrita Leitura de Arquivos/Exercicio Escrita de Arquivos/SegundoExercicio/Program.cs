using System.Text;

namespace SegundoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Fazer um programa em VS que popule uma lista e um arquivo .csv de nomes,
                com nomes completos obrigatoriamente.
                Ao cadastrar o nome na lista e no arquivo, o nome deve ser validado para que 
                tenha no mínimo duas palavras e 
                que não esteja na lista. Ao final, caso o nome não esteja na lista e arquivo, 
                cadastra-lo em maiúsculo e 
                exibir a lista ordenada.
             */
            string caminho = @"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\SegundoExercicio\Nomes.csv";
            List<string> nomes = new List<string>();
            PopularLista(ref nomes, caminho);

            while (true)
            {

                Console.Write("Digite seu nome completo: ");
                string nome = ValidarNome(Console.ReadLine());

                if(nome != "" && (ExisteNaLista(ref nomes, nome) == false))
                {
                    nomes.Add(nome);
                    EscreveNoArquivo(nome, caminho);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if(nome == "")
                     Console.WriteLine("Nome Precisa ser completo");
                    else
                    {
                        Console.WriteLine("Nome já está cadastrado na lista");
                    }

                    Console.ResetColor();
                }
            }
        }
        static string ValidarNome(string nome)
        {
            string[] nomeSplit = nome.Split(" ");

            if (nomeSplit.Length >= 2 && (!String.IsNullOrWhiteSpace(nomeSplit[1])))
            {
                return nome.ToLower();
            }

            return "";
        }
        static bool ExisteNaLista(ref List<string> nomes, string nome)
        {
            foreach (var item in nomes)
            {
                if(item == nome){
                    return true;
                }
            }

            return false;
        }
        static void EscreveNoArquivo(string nomeCompleto, string caminho)
        {
            try
            {
                StreamWriter writer = new StreamWriter(caminho, append: true, encoding: Encoding.UTF8);

                writer.WriteLine(nomeCompleto);
                writer.Close();
                writer.Dispose();
            }
            catch(Exception ex)
            {
               
            }
           
        }
        static void PopularLista(ref List<String> lista, string caminho)
        {
            try
            {
                StreamReader reader = new StreamReader(caminho);

                while (!reader.EndOfStream)
                {
                    lista.Add(reader.ReadLine());
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }

        }
    }
}