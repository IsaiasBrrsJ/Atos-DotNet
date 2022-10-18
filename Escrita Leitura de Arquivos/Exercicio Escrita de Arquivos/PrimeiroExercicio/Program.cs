using System.Diagnostics.SymbolStore;

namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //escrita de arquivos
            //StreamWriter writer = new StreamWrite();

            /* Nome, idade, sexo, email, telefone, estado civil, casa propria ou não, valor aluguel;
               Gerar um arquivo, utilizando o ; como caractere delimitador para cada uma dessas informações.
               Todas as informações, ficam na mesma linha - cada linha é uma pessoa.
               apenas nome, idade e casa propria sao campos obrigatórios

               Exemplo Fabrício;21;;;;;sim;0

            new==========
                verificar se o arquivo existe

                ler o arquivo, caso exista, para criar um novo com os dados anteriores e os novos inseridos


            */
            string nome;
            int idade;
            string sexo;
            string email;
            string telefone;
            string estadoCivil ;
            bool casaPropria;
            double valorAluguel;
            string linha = "";
            string novoArquivo = @"D:\Atos-Codigos\Exercicio Escrita de Arquivos\PrimeiroExercicio\NovoArquivo.txt";
            string caminho = @"D:\Atos-Codigos\Exercicio Escrita de Arquivos\PrimeiroExercicio\ArquivoGerado.txt";
            StreamReader reader = new StreamReader(caminho);

            List<string> novoArq = new List<string>();
            linha = reader.ReadLine();


            if (File.Exists(caminho))
            {
                linha = reader.ReadLine();
                while (linha != null)
                {   
                    Console.WriteLine(linha);
                    novoArq.Add(linha +";");

                    linha = reader.ReadLine();
                }
                File.Create(novoArquivo).Close();

                reader.Close();
                linha = "";
            }

            do
            {
                Console.Write("Digite seu nome: ");
                 nome = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(nome)) { break; }
            } while (true);

            do
            {
                Console.Write("Digite sua idade: ");
            } while (int.TryParse(Console.ReadLine(), out idade) == false || idade <= 0);

            do
            {
                int opc;
                bool opcCorreto;
                Console.Write("Casa Propria [1]-Sim | [2]-Não: ");
                opcCorreto = int.TryParse(Console.ReadLine(), out opc);
                if(opcCorreto == false || (opc < 1 || opc > 2))
                {
                    continue;
                }
                else
                {
                    if(opc == 1) {
                        casaPropria = true;
                        valorAluguel = 0;
                    }
                    else {
                        casaPropria = false;
                        Console.WriteLine("Informe o valor do aluguel: ");
                        valorAluguel = double.Parse(Console.ReadLine());
                    }

                    break;
                }

            } while (true);

            Console.WriteLine("Seu Sexo: ");
            sexo = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Email: ");
            email = Console.ReadLine();

            Console.WriteLine("Estado Civil: ");
             estadoCivil = Console.ReadLine();


            StreamWriter writer = new StreamWriter(novoArquivo);

            foreach (var item in novoArq)
            {
                writer.Write(item+Environment.NewLine);
            }

            writer.Write(nome+";");
            writer.Write(idade+";");
            writer.Write(sexo+";");
            writer.Write(email + ";"+telefone+";"+estadoCivil+";"+casaPropria+";"+valorAluguel);
            
            writer.Close();

            
            Console.ReadKey();
        }
    }
}