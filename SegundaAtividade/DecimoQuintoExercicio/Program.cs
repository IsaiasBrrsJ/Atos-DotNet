using System.Reflection.Metadata.Ecma335;

namespace DecimoQuintoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             15 - Faça um programa para uma loja de tintas.
                  O programa deverá pedir o tamanho em metros quadrados 
                  da área a ser pintada. Considere que a cobertura da
                  tinta é de 1 litro para cada 3 metros quadrados 
                  e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
                  Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
             */


            int metros = 0;
            int calc = 0;
            int qtdLatas = 0;
            double preco = 0;
            Console.Write("Informe o tamanho em metro quadrado: ");
            metros = int.Parse(Console.ReadLine());

            calc = metros / 3;
            qtdLatas = calc / 18;

            if (qtdLatas < 2) {
                preco = 80.00;
                qtdLatas = 1;
            }
            else {
                preco = qtdLatas * 80;

            }



            Console.WriteLine($"É necessários comprar {qtdLatas.ToString("0")} Litro(s) de tinta será gasto um total de: {preco.ToString("C")}");

            Console.ReadKey();



        }
    }
}