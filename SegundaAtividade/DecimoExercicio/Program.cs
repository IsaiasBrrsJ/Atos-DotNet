namespace DecimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
                O programa deve mostrar os dados do atleta mais novo e mais alto.

             */

            string nomePrimeiroAtleta, nomeSegundoAtleta;
            int idadePrimeiroAtleta, idadeSegundoAtleta;
            double alturaPrimeiroAtleta, alturaSegundoAtleta;

            Console.Write("Nome primeiro atleta: ");
            nomePrimeiroAtleta = Console.ReadLine();

            Console.Write("Idade primeiro atleta: ");
             idadePrimeiroAtleta = int.Parse(Console.ReadLine());

            Console.Write("Altura primeiro atleta: ");
            alturaPrimeiroAtleta = double.Parse(Console.ReadLine());    

            Console.WriteLine("\n-----Segundo Atleta-------\n");
              

            Console.Write("Nome segundo atleta: ");
            nomeSegundoAtleta = Console.ReadLine();

            Console.Write("Idade segundo atleta: ");
            idadeSegundoAtleta = int.Parse(Console.ReadLine());

            Console.Write("Altura segundo atleta: ");
            alturaSegundoAtleta = double.Parse(Console.ReadLine());


            Console.Write("\n---Atleta mais novo-----\n");

            if (idadePrimeiroAtleta > idadeSegundoAtleta) {

                Console.WriteLine($"Nome {nomeSegundoAtleta}\nIdade {idadeSegundoAtleta}\n" +
                    $"Altura {alturaSegundoAtleta}");
            }
            else {
                Console.WriteLine($"Nome {nomePrimeiroAtleta}\nIdade {idadePrimeiroAtleta}\n" +
                      $"Altura {alturaPrimeiroAtleta}");
            }

            Console.WriteLine("\n--------- Maior Atleta -------\n");

            if (alturaPrimeiroAtleta > alturaSegundoAtleta) {

                Console.WriteLine($"Nome {nomePrimeiroAtleta}\nIdade {idadePrimeiroAtleta}\n" +
                       $"Altura {alturaPrimeiroAtleta}");
            }
            else {

                Console.WriteLine($"Nome {nomeSegundoAtleta}\nIdade {idadeSegundoAtleta}\n" +
                     $"Altura {alturaSegundoAtleta}");
            }

            Console.ReadKey();
        }
    }
}