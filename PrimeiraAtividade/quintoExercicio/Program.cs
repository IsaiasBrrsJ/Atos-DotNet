namespace quintoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
             (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
             consumido para percorrê-la (medido em l).
            */

            double distanciaTotalPercorrida = 600.0;
            double combustivelConsumido = 32;

            double consumoMedio = (distanciaTotalPercorrida / combustivelConsumido);

            
            Console.WriteLine($"Distância percorrida: {distanciaTotalPercorrida}Km\nConsumo medio: " + consumoMedio +"Km/l");

            Console.ReadKey();






        }
    }
}