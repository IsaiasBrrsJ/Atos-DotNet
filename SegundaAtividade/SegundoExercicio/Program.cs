namespace SegundoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
             */

            int num = 0;
            Console.Write("Digite um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0) {

                Console.WriteLine("O número {0} é neutro", num);
            }
            else if (num % 2 != 0) {
                Console.WriteLine("O número {0} é Ímpar", num);
            }
            else {
                Console.WriteLine("O número {0} é Par", num);
            }


            Console.ReadKey();
        }
    }
}