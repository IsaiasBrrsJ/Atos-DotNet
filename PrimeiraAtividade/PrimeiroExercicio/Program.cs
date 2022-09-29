namespace PrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            int primeiroValor = 0;
            int segundoValor = 0;
            double media = 0;


            Console.Write("Digite o primeiro valor: ");
             primeiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
             segundoValor = int.Parse(Console.ReadLine());

            media = (primeiroValor + segundoValor) / 2;

            Console.WriteLine($"A média aritmética entre o primeiro e o segundo valor lido resultam em: {media}");

        }
    }
}