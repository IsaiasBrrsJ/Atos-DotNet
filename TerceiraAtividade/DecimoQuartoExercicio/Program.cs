namespace DecimoQuartoExercicio {
    internal class Program {
        static void Main(string[] args) {

            //14. Mostrar as potências de 2 variando de 0 a 10.

            int potencia = 1;
            string resultado = "";
            for (int i = 0; i <= 10; i++) {
             resultado = $"{2}^{i} = {potencia}";
             potencia *= 2;
             Console.WriteLine(resultado);
            }

            Console.ReadKey();
        }
    }
}