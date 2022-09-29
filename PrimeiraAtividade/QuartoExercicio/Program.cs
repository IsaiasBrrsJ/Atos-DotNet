using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace QuartoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            int dia;
            int mes;
            int ano;

            Console.WriteLine("Informe uma data DD/MM/AAAA\n");
            Console.Write("Dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            ano = int.Parse(Console.ReadLine());

            
            string anoMesDia = new DateTime(ano, mes, dia).ToString("yyyy/MM/dd");
            Console.WriteLine(anoMesDia);

            anoMesDia = $"{(ano % 100)}/{mes}/{dia}";

            Console.WriteLine(anoMesDia);

            





            Console.ReadKey();
        }
    }
}