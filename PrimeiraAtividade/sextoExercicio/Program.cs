namespace sextoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
                isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
                de IPI (única) a ser acrescentada.
            */

            int codParafusoA;
            int codParafusoB;
            int qtdPecasParafusoA;
            int qtdPecasParafusoB;
            decimal valorUnitarioParafusoA;
            decimal valorUnitarioParafusoB;
            double porcentagemIPIa;
            double porcentagemIPIb;

            Console.Write("cod parafuso A: ");
             codParafusoA = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de peças parafuso A: ");
             qtdPecasParafusoA = int.Parse(Console.ReadLine());

            Console.Write("Valor unitário parafuso A: ");
             valorUnitarioParafusoA = decimal.Parse(Console.ReadLine());

            Console.Write("\nIPI parafuso A: ");
             porcentagemIPIa = double.Parse(Console.ReadLine());

            Console.WriteLine("\n========================\n");

            Console.Write("cod parafuso B: ");
             codParafusoB = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de peças parafuso B: ");
             qtdPecasParafusoB = int.Parse(Console.ReadLine());

            Console.Write("Valor unitário parafuso B: ");
             valorUnitarioParafusoB = decimal.Parse(Console.ReadLine());

            Console.Write("\nIPI parafuso B: ");
             porcentagemIPIb = double.Parse(Console.ReadLine());


            Console.ReadKey();















        }
    }
}