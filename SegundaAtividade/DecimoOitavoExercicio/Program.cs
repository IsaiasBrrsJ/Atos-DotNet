namespace DecimoOitavoExercicio {
    internal class Program {
        static void Main(string[] args) {
            //18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            int primeiroNumero = -1;
            int segundoNumero = -1;
            int terceiroNumero = -1;
            int maior = 0;

            Console.Write("Digite o primeiro número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            maior = primeiroNumero;


            Console.Write("Digite o segundo número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (segundoNumero > maior) {
                maior = segundoNumero;
            }

            Console.Write("Digite o terceiro número: ");
            terceiroNumero = int.Parse(Console.ReadLine());

            if (terceiroNumero > maior) {
                maior = terceiroNumero;
            }

            Console.WriteLine("Maior número digitado: " + maior);

            Console.ReadKey();
        }
    }
}