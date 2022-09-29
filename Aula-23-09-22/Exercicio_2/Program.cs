namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
 

            string resultado = "Nao pode formar um triangulo";

  

             Console.Write("A: ");
              A = int.Parse(Console.ReadLine());

             Console.Write("B: ");
              B = int.Parse(Console.ReadLine());

             Console.Write("C: ");
              C = int.Parse(Console.ReadLine());

           


            if (((A + B) > C) && ((A + C) > B) && ((B + C) > A))
            {
                resultado = "Pode Formar um triangulo, tipo: ";

                if ((A == B) && B == C)
                {

                    resultado += " Equilatero";
                }
                else if ((A == B) || (B == C) | (C == A))
                {

                    resultado += " Isoceles";
                }
                else
                {
                    resultado += " Escaleno";
                }

            }

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}