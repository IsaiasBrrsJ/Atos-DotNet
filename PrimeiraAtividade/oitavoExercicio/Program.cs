namespace oitavoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
                A fórmula da conversão é F=(9*C+160)/5.
            */

       

            Console.Write("Grau celsius: ");
             double grausCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Fahrenheit: " + (9 * grausCelsius + 160) / 5);

            Console.ReadKey();
        }
    }
}