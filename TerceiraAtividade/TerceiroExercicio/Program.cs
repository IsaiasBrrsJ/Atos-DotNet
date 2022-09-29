using System;

namespace TerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
                Se o usuário digitar 0 o programa em VS deve parar. 
                Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. 

             */

            int numeroDigitado = -1;

            while (true) {
            
                string resultado = "";

                Console.Write("Digite um números (ZERO Para finalizar): ");
                numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado is 0) {
                    break;
                }
                else {
                    int contador = 0;
                    for (int i = 2; i <= numeroDigitado / 2; i++) {
                        if (numeroDigitado % i == 0) {
                            contador++;
                            break;
                        }
                    }

                    if (contador == 0) {
                        resultado += "É primo";
                    }
                    else {
                        resultado += "Não é primo";
                    }

                    if (numeroDigitado % 2 == 0) {
                        resultado += " e é par";
                    }
                    else {
                        resultado += " e é ímpar";
                    }

                }

                Console.WriteLine("\n=== Resultado ===\n"+resultado+"\n");

                resultado = "";

            }

        }
    }
}