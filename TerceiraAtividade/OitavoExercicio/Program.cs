namespace OitavoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             8. Faça um programa em VS que solicite um numero inteiro. S
                e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
                Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
             */

            int numeroDigitado = 0;
            bool Einteiro = true;
            string continuar = "";

            
            while (continuar != "N") {

                Console.WriteLine("Digite um número inteiro: ");
                 Einteiro = int.TryParse(Console.ReadLine(), out numeroDigitado);

                if (Einteiro is false) {
                    continue;
                }

                if (numeroDigitado % 2 == 0) {
                    Console.WriteLine($"O valor: {numeroDigitado} é par");
                } else {
                    Console.WriteLine($"O valor: {numeroDigitado} é Ímpar");
                }

                do {
                    Console.WriteLine("Continur (S)sim (N)não: ");
                     continuar = Console.ReadLine().ToUpper();

                    if (continuar is "S") {
                        Console.Clear();
                        break;
                    }
                } while (continuar != "N");
              
            }

            Console.ReadKey();
        }
    }
}