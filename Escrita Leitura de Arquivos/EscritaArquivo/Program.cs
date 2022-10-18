namespace EscritaArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //System.io imput and output escrita leitura arquivos
            //Escrita de arquivos

            StreamWriter writer = new StreamWriter(@"D:\Atos-Codigos\Escrita Leitura de Arquivos\EscritaArquivo\AtosUfn.txt");
            //@ ignora escape \\ duas contrabarra interpreta como uma

            writer.WriteLine("Hoje é segunda-feira"); // escreve em um arquivo
            writer.WriteLine("Aula Atos-UFN");
            writer.WriteLine("17-10-2022");

            writer.WriteLine("Isaias");
            writer.Close();
        }
    }
}