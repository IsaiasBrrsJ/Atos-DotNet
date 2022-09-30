namespace OitavoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             
             8 - Faça um programa no VS que receba o código, nome, salário
                    base e o total de vendas de um funcionário.
                    Caso o total de vendas seja acima de R$ 500,00,
                    adicionar ao seu salário final 5% do total de vendas.
                    Caso o total de vendas seja mais que R$ 1000,00,
                    adicionar ao seu salário final 7% do total de vendas.
                    E por fim, se o total de vendas seja maior que
                    R$ 5000,00, adicionar ao seu salário final 10% do 
                    total de vendas.
             */

            int codFunc = -1;
            string nomeFunc = "";
            double salarioBaseFunc = 0;
            double ValorTotalVendasFunc = 0;
            double salarioFinal = 0;
            string resultado = "";

            Console.Write("Cod funcionario: ");
            codFunc = int.Parse(Console.ReadLine());

            Console.Write("Nome do funcionario: ");
            nomeFunc = Console.ReadLine();

            Console.Write("Salario do {0}: ", nomeFunc);
            salarioBaseFunc = double.Parse(Console.ReadLine());

            Console.Write("Total de vendas do {0}: ", nomeFunc);
             ValorTotalVendasFunc = double.Parse(Console.ReadLine());


            if (ValorTotalVendasFunc > 5000.00) {
                salarioFinal = salarioBaseFunc + (ValorTotalVendasFunc * 0.10);
                
            }
            else if (ValorTotalVendasFunc > 1000.00) {
                salarioFinal = salarioBaseFunc + (ValorTotalVendasFunc * 0.07);
                
            }
            else {
                if (ValorTotalVendasFunc > 500.00) {
                    salarioFinal = salarioBaseFunc + (ValorTotalVendasFunc * 0.05);
                 
                }
            }

            Console.WriteLine($"\nSalario final do {nomeFunc} = {salarioFinal.ToString("C")}");
            Console.ReadKey();
        }
    }
}