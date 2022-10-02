namespace DecimoNonoExercicio {
    internal class Program {
        static void Main(string[] args) {

            //19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            int primeiroNumero = -1;
            int segundoNumero = -1;
            int terceiroNumero = -1;
         
            string resultado = "";
            Console.Write("Digite o primeiro número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            terceiroNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero) {
                int aux = primeiroNumero;
                primeiroNumero = segundoNumero;
                segundoNumero = aux;
            }
            if (primeiroNumero > terceiroNumero) {

                int aux = primeiroNumero;
                primeiroNumero = terceiroNumero;
                terceiroNumero = aux;
            }
            if (segundoNumero > terceiroNumero) {
                int aux = segundoNumero;
                segundoNumero = terceiroNumero;
                terceiroNumero = aux;
            }
            Console.WriteLine("Ordem Crescente\n");
            Console.WriteLine($"{primeiroNumero} {segundoNumero} {terceiroNumero}");

            Console.ReadKey();
        }
    }
}