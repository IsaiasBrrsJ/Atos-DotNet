namespace decimoSegundoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.
               Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
               marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no 
               final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
               dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

               Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

               Média do consumo = Total quilometragem/ quantidade de combustível gasto

               Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
             */

            double precoCombustivel = 6.90;
            double odometroInicioDoDia;
            double odometroFinalDoDia;
            double quantidadeDeCombustivelGasto;
            double valorTotalRecebidoDosPassageiros;
            double totalQuilometragem;
            double mediaConsumo;
            double lucroDoDia;

            Console.Write("Informe o odômetro do Inicio do dia: ");
             odometroInicioDoDia = double.Parse(Console.ReadLine());

            Console.Write("Informe o odômetro do Final do dia: ");
             odometroFinalDoDia = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de combustível gasto: ");
             quantidadeDeCombustivelGasto = double.Parse(Console.ReadLine());

            Console.Write("Valor total recebido dos passageiros: ");
             valorTotalRecebidoDosPassageiros = double.Parse(Console.ReadLine());

            totalQuilometragem = odometroFinalDoDia - odometroInicioDoDia;

            mediaConsumo = totalQuilometragem / quantidadeDeCombustivelGasto;

            lucroDoDia = valorTotalRecebidoDosPassageiros - (quantidadeDeCombustivelGasto * precoCombustivel);


            Console.WriteLine("\nMédia do consumo de gasolina: " + mediaConsumo.ToString("0.0") + "Km/l" + "\nLucro liquido do dia: " + lucroDoDia.ToString("C"));


            Console.ReadKey();




        }
    }
}