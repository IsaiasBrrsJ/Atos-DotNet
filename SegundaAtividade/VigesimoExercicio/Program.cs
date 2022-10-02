namespace VigesimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
              20 - Escreva um algoritmo para o jogo de adivinhação do número secreto.
                   O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
                    plus: você pode gerar o número de forma randomica (função random c#).
             */

            int numGerado = new Random().Next(0, 16);
            int tentativa = 0;
            int chances = 3;
            int num = -1;

            Console.Write("Tente Advinhar o número sorteado você tem 3 chances.");

            Console.Write("\nInforme um número: ");
            num = int.Parse(Console.ReadLine());
            tentativa++;
            chances--;

            if (num == numGerado) {
                Console.WriteLine($"Você acertou na {tentativa} tentativa");
            }
            else {

                if (num > numGerado) {
                    Console.WriteLine("É menor");
                }
                else {
                    Console.WriteLine("É maior");
                }

                Console.Write("\nInforme um número: ");
                 num = int.Parse(Console.ReadLine());

                tentativa++;
                chances--;

                if (num == numGerado) {
                    Console.WriteLine($"Você acertou na {tentativa} tentativa");
                   
                }

                if (num > numGerado) {
                    Console.WriteLine("É menor");
                }
                else {
                    Console.WriteLine("É maior");
                }


                Console.Write("\nInforme um número: ");
                num = int.Parse(Console.ReadLine());

                tentativa++;
                chances--;

                if (num == numGerado) {
                    Console.WriteLine($"Você acertou na {tentativa} tentativa");

                }

                if (num > numGerado) {
                    Console.WriteLine("É menor");
                }
                else {
                    Console.WriteLine("É maior");
                    
                }

            }

            Console.WriteLine("Você perdeu");
            Console.ReadKey();
                
        }
    }
}