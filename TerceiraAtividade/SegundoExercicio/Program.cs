namespace SegundoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
                informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
                Exemplo:
                Digite um número inteiro positivo: 8
                Numero digitado: 8
                Números inteiros pares entre 1 e 8: 2, 4, 6.
 
                Deseja informar outro número (s/n)? S
 
                Digite um número inteiro positivo: 12
                Numero digitado: 20
                Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
                Deseja informar outro número (s/n)? N 
             
             */

            int numeroDigitado = 0;
            string resultado = "";
            string irNovamente = "";

            while (true) {

                Console.Write("Informe um número inteiro positivo: ");
                numeroDigitado = int.Parse(Console.ReadLine());

                if (numeroDigitado < 0) {
                    Console.WriteLine("\nValor incorreto!");
                }
                else {

                    for (int i = 1; i < numeroDigitado; i++) {
                        if (i % 2 is 0) {

                            resultado += $" {i}";
                        }

                    }
                    Console.WriteLine($"Números inteiros pares entre 1 e {numeroDigitado}: {resultado}.\n");

                    do {
                        Console.WriteLine("Deseja informar outro número(s / n) ?: ");
                          irNovamente = Console.ReadLine().ToUpper();

                    } while (irNovamente != "S" && irNovamente != "N");


                    if (irNovamente is "S") {
    
                        resultado = "";
                        continue;
                    }
                    else {
                        break;
                    }
                }
            }

            

            Console.ReadKey();
        }
    }
}