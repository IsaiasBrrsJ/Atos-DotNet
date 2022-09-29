namespace SegundoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.


            int primeiroValor = 0;
            int segundoValor = 0;
            int terceiroValor = 0;
            int quartoValor = 0;
            double media = 0;


            Console.Write("Digite o primeiro valor: ");
            primeiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            segundoValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o Terceiro valor: ");
            terceiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor: ");
            quartoValor = int.Parse(Console.ReadLine());

            media = (double)((primeiroValor + segundoValor) + (terceiroValor + quartoValor)) / 4;

            Console.WriteLine($"A média aritmética entre os valores lidos resultam em: {media.ToString("0.0")}");//ToString("0.0) exibir o resultado em duas casas decimais

            Console.ReadKey();
        }
    }
}