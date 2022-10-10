namespace SegundoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             2. Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam sorteados
                randomicamente. O programa deve pedir ao usuário quantos números deseja armazenar. 
                Ao final, o programa
                deve exibir os números populados na lista.
             
             */


            int qtdQueDesejaArmazenar = 0;
            List<int> numerosArmazenados = new List<int>();

            Console.WriteLine("Informe a quantidade de números aleátorios que deseja armazenas na lista: ");
             qtdQueDesejaArmazenar = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdQueDesejaArmazenar; i++) {

                numerosArmazenados.Add(new Random().Next(0, 1001));
            }

            Console.WriteLine("Números que foram armazenados na lista\n");
            foreach (var numeros in numerosArmazenados) {
                Console.WriteLine(numeros);
            }

            Console.ReadKey();

        }
    }
}