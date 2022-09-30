namespace DecimoQuartoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
                14 - Faça um programa que peça o tamanho de um arquivo para download (em MB)
                e a velocidade de um 
                link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
                do arquivo usando este link (em minutos).
             */

            double tamanhoArquivo = 0;
            double velocidadeLink = 0;

            Console.Write("Tamanho do arquivo em (MB): ");
            tamanhoArquivo = double.Parse(Console.ReadLine());

            Console.Write("Velocidade do link em (Mbps): ");
            velocidadeLink = double.Parse(Console.ReadLine());

            double calc = (tamanhoArquivo / (velocidadeLink / 8) ) / 60;

            Console.WriteLine("\n Levará: " + calc.ToString("0.0"));

            Console.ReadKey();
        }
    }
}