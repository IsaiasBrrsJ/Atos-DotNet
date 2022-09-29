namespace exemplovetores {
    internal class Program {
        static void Main(string[] args) {

            double[] notas = new double[50];
            double media;
            int i;

            Console.WriteLine("------ - Leitura dos valores:------");

            for (i = 0; i < 3; i++) {
                Console.Write("Digite a nota do aluno " +i+ ":");
                notas[i] = double.Parse(Console.ReadLine());
            }

            media = 0;

            Console.WriteLine("-------Calculo da media sendo feito:-------");
            for ( i = 0; i < 3; i++) {
                media += notas[i];

            }

            media = media / 3;

            Console.WriteLine("------Mostra a media:------");
            Console.WriteLine("A media de notas é igual " + media);

            Console.ReadKey();
        }

      
    }
}