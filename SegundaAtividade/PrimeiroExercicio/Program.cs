namespace PrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             1 - Faça um algoritmo para calcular e mostrar a área de um triângulo
                 a partir dos valores da base e da altura lidos pelo teclado: 
                Área do triangulo = (base * altura) / 2; 
                Teste se a base ou a altura digitada não foi igual a zero. 
             */

            double baseArea =0, alturaArea = 0, calculoArea = 0;

            Console.Write("Informe a base: ");
            baseArea = double.Parse(Console.ReadLine());

            Console.Write("Informa a altura: ");
             alturaArea = double.Parse(Console.ReadLine());

            if (baseArea != 0 | alturaArea != 0) {
                calculoArea = (baseArea * alturaArea) / 2;

                Console.WriteLine("Área do triangulo: " + calculoArea);
            }
            else {
                Console.WriteLine("Nao foi possivel calcular");
            }

            Console.ReadKey();
        }
    }
}