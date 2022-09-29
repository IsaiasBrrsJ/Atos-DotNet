namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;

            int op;

            Console.WriteLine("Digite dois numeros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha a operacao:\n1. Soma\n2. Subtracao\n3. Multiplicacao\n4. Divisao\n5. Potencia\n\nEscolha: ");
             op = int.Parse(Console.ReadLine());


            if(op == 1) {
                resultado = num1 + num2;
                Console.WriteLine("Soma = " + resultado);
            }
            else if(op == 2) {
                resultado =  (num1 - num2);
                Console.WriteLine("Subtracao = " + resultado);
            }
            else if(op == 3) {
                resultado = num1 * num2;
                Console.WriteLine("Multiplicacao = " + resultado);
            }
            else if(op == 4) { 
                resultado = num1 / num2;
                Console.WriteLine("Divisao = " + resultado);
            }
            else if(op == 5) { 
                resultado = Math.Pow(num1, num2);
                Console.WriteLine("Potencia = " + resultado);
            }

            Console.ReadKey();
        }
    }
}