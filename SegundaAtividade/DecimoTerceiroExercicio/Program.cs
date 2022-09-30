namespace DecimoTerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
              13 - Tendo como dado de entrada a altura (h) de uma pessoa,
                      construa um programa no VS que calcule 
                      seu peso ideal, utilizando as seguintes fórmulas:
                      Para homens: (72.7 * h) - 58
                      Para mulheres: (62.1 * h) - 44.7
             */

            double altura, pesoIdeal =0;
            string sexo = "";
            Console.Write("Informe sua altura: ");
             altura = double.Parse(Console.ReadLine());

            Console.Write("Informe seu sexo (F)Feminino (M)Masculino: ");
             sexo = Console.ReadLine().ToUpper();

            if (sexo is "F") {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else if (sexo is "M") {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else {
                Console.WriteLine("Dados incorretos");
            }

            Console.WriteLine("\nSeu peso ideal: " + pesoIdeal.ToString("0.0"));
            Console.ReadKey();

        }
    }
}