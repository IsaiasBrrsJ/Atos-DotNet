﻿namespace DecimoSegundoExercicio {
    internal class Program {
        static void Main(string[] args) {


            //12. Apresentar o total da soma dos cem primeiros números inteiros.

            int soma = 0;

            for (int i = 1; i <= 100; i++) {

                soma += i;
            
            }

            Console.WriteLine("soma dos cem primeiros números inteiros: " + soma);
            Console.ReadKey();
        }
    }
}