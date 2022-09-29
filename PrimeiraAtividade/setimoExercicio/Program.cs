namespace setimoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
                o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
                Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
            */

            int numVendedor = 0;
            decimal salarioFixoDoVendedor = 0.0m;
            int totalDeVendasEfetuadas = 0;
            double percentualDeGanhosSobreTotalDeVendas = 0;

            Console.Write("Digite o número do vendedor: ");
             numVendedor = int.Parse(Console.ReadLine());

            Console.Write($"Salário Fixo do vendedor {numVendedor}: ");
             salarioFixoDoVendedor = decimal.Parse(Console.ReadLine());

            Console.Write($"Total de vendas realizadas pelo vendedor {numVendedor}: ");
             totalDeVendasEfetuadas = int.Parse(Console.ReadLine());

            Console.Write("Percentual Ganho por cada venda realizada: ");
             percentualDeGanhosSobreTotalDeVendas = int.Parse(Console.ReadLine());


            double percentualTotal = (totalDeVendasEfetuadas * percentualDeGanhosSobreTotalDeVendas)/ 100;
           
            decimal salarioTotal = salarioFixoDoVendedor + (salarioFixoDoVendedor * (decimal)percentualTotal);

            Console.WriteLine("Numero Vendedor {0}, Salario total do vendedor: {1}", numVendedor, salarioTotal.ToString("C"));//toString("C") converte pra valor monetario BR;

            Console.ReadKey();







        }
    }
}