namespace Exercicio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5, c = 9, d = 1;


            if((a != 0) && b == 5) { Console.WriteLine("1 Verdade"); }

            if (a > 3 || d == 1) { Console.WriteLine("2 Verdade"); }

            if(!((a > 3 || d < 3) && (b < c && b > c))){ Console.WriteLine("3 Verdade"); }

            if((b != 0 || a > 4 ) || (d < 3 && c >= 8)) { Console.WriteLine("4 Verdade"); }

            if (((a > d || a < d) || a == 4 ) || (!(b == 5) && b > c)) { Console.WriteLine("5 Verdade"); }

            Console.ReadKey();
        }
    }
}