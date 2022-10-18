using System.Security.Cryptography.X509Certificates;

namespace LeituraDeArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"D:\Atos-Codigos\Escrita Leitura de Arquivos\AtosUfn.txt");

            string linha = "";
            Console.WriteLine("--------------------------------------------");
            linha = reader.ReadLine();

            while(linha != null)
            {   
                if(linha != "")
                 Console.WriteLine(linha);
                
                linha = reader.ReadLine();
            }
            Console.WriteLine("--------------------------------------------");
            reader.Close();

            Console.ReadKey();
        }
    }
}