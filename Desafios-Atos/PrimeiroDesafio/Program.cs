using PrimeiroDesafio.Classes;

namespace PrimeiroDesafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"D:\Atos-Codigos\Desafios-Atos\PrimeiroDesafio\Arquivo\10_TXTdesafio10_Arquivo.txt";

            Util.LerArquivoETratar(caminhoArquivo);

            Console.ReadKey();
        }
    }
}