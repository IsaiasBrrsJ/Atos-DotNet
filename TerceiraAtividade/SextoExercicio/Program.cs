namespace SextoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
                ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
                Ao final, mostre a idade digitada.
             */

            while (true) {

                Console.Write("Informe sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade <= 0){
                    Console.WriteLine("Informe idade maior que ZERO");
                    continue;
                }
                else {
                    Console.WriteLine("Idade digitada: " + idade);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}