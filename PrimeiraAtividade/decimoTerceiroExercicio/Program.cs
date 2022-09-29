namespace decimoTerceiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.
                 Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
                 preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor 
                 do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
                 vendidas pelo vendedor, calcule e mostre: o salário do empregado
             */

            int acrescimoSobreOPrecoDeCusto = 50;
            int comissaoSobrePrecoCustoDaBicicleta = 15;
            int quantidadeDeBicicletasVendidas;
            double valorDoSalarioMinimo;
            double precoBicicletaSemAcrescimo;
            double precoBicicletaComAcrescimo;
            double salarioDoEmpregado;

            Console.Write("Informe o valor do salário mínimo: ");
            valorDoSalarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Informe o preço da bicicleta: ");
            precoBicicletaSemAcrescimo = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de bicicletas vendidas: ");
            quantidadeDeBicicletasVendidas = int.Parse(Console.ReadLine());

            precoBicicletaComAcrescimo = precoBicicletaSemAcrescimo + ((precoBicicletaSemAcrescimo * acrescimoSobreOPrecoDeCusto) / 100);
           
            valorDoSalarioMinimo = valorDoSalarioMinimo * 2;

            salarioDoEmpregado = valorDoSalarioMinimo + ( ((precoBicicletaSemAcrescimo * comissaoSobrePrecoCustoDaBicicleta) / 100) * quantidadeDeBicicletasVendidas);

            Console.WriteLine("\n\nSalário do colaborador: "+salarioDoEmpregado.ToString("C"));
            Console.ReadKey();









        }
    }
}