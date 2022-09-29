namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string resultado = "Nao divisivel";

            Console.WriteLine("Digite um numero: ");
             num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) { resultado = "Divisivel por 2"; }
            if (num % 4 == 0) { resultado = "Divisivel por 4"; }
            if (num % 8 == 0) { resultado = "Divisivel por 8"; }

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}