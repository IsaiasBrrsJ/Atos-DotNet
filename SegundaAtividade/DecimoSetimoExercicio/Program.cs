namespace DecimoSetimoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c),
                 e então diga se esses lados podem ou não formar um triangulo. Para que os lados
                formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros
                  dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
                os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
  
             
             */

            int A, B, C;


            string resultado = "Nao pode formar um triangulo";



            Console.Write("A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("C: ");
            C = int.Parse(Console.ReadLine());




            if (((A + B) > C) && ((A + C) > B) && ((B + C) > A)) {
                resultado = "Pode Formar um triangulo, tipo: ";

                if ((A == B) && B == C) {

                    resultado += " Equilatero";
                }
                else if ((A == B) || (B == C) | (C == A)) {

                    resultado += " Isoceles";
                }
                else {
                    resultado += " Escaleno";
                }

            }

            Console.WriteLine(resultado);

            Console.ReadKey();

        }
    }
}