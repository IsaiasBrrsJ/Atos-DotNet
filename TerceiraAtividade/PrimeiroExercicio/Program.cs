using System.Drawing;

namespace PrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
             (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
             Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

             Exemplo:
             Digite um número inteiro positivo: -8
             Valor incorreto!
             Digite um número inteiro positivo: 8
             Numero digitado: 8
             Números inteiros pares entre 1 e 8: 2, 4, 6.

             */
            int numeroDigitado = 0;
            string resultado = "";

            while (true) {

                Console.Write("Informe um número inteiro positivo: ");
                numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado < 0) {
                    Console.WriteLine("\nValor incorreto!");
                }
                else {

                    for (int i = 1; i < numeroDigitado; i++) {
                        if(i % 2 == 0) {

                            resultado += $" {i}";
                        }
                        
                    }

                    break;
                }
            }

            Console.WriteLine($"Números inteiros pares entre 1 e {numeroDigitado}: {resultado}");

            Console.ReadKey();

        }
    }
}