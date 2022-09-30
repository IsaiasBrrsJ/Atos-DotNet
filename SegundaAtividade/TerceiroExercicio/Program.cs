namespace TerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,
                e escrever na tela os que são superiores à média.
             */

            int primeiroValor = 0;
            int segundoValor = 0;
            int terceiroValor = 0;
            int quartoValor = 0;
            string resultado = "";
            double media = 0;

            Console.Write("Digite o primeiro valor inteiro: ");
             primeiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o seungo valor inteiro: ");
             segundoValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor inteiro: ");
             terceiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto valor inteiro: ");
             quartoValor = int.Parse(Console.ReadLine());

            media = (primeiroValor + segundoValor + terceiroValor + quartoValor) /4;

            if (primeiroValor > media) {

                resultado += $"\nPrimeiro Valor: {primeiroValor} ";
            }
            if (segundoValor > media) {
                resultado += $"\nSegundo Valor: {segundoValor} ";
            }
            if (terceiroValor > media) {
                resultado += $"\nTerceiro Valor: {terceiroValor} ";
            }
            if (quartoValor > media) {
                resultado += $"\nQuarto Valor: {quartoValor} ";
            }

            Console.WriteLine($"Media {media}, valores que sao superiores a media: {resultado}");

            Console.ReadKey();

        }
    }
}