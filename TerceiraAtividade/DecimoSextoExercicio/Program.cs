namespace DecimoSextoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
                multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
                (N*3; N*3*3; N*3*3*3; etc).
             
             */

            int num = 0;

            do {

                Console.Write("Digite um número menor ou igual a 50: ");
                num = int.Parse(Console.ReadLine());

            } while (num > 50);

            while (num < 250) {

                Console.WriteLine(num *= 3);
            }
        
          Console.ReadKey();
        }
    }
}