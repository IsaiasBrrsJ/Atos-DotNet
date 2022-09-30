namespace QuintoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             5 - Escrever um algoritmo para ler duas notas de um aluno e
                 escrever na tela a palavra “Aprovado” 
                 se a média das duas notas for maior ou igual a 7,0. 

            Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e
            calcular a média final,
            é a média entre a nota do exame e a média das 2 notas. 
            Se esta média final for maior ou igual a 5,0, o programa deve escrever
            “Aprovado”, caso contrário deve 
            escrever “Reprovado”.
             */

            double primeiraNota, segundaNota, media = 0;

            Console.Write("Digite a primeira nota: ");
            primeiraNota = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunoda nota: ");
            segundaNota = double.Parse(Console.ReadLine());

            media = (primeiraNota + segundaNota) / 2;

            if (media >= 7) {
                Console.WriteLine($"\nAprovado com nota: " + media.ToString("0.0"));
            }
            else {
                Console.Write("Informe a nota do exame final: ");
                double exameFinal = double.Parse(Console.ReadLine());

                double mediaFinal = (media + exameFinal) / 2;

                if (mediaFinal >= 5) {
                    Console.WriteLine($"\nAprovado com nota: " + mediaFinal.ToString("0.0"));
                }
                else {
                    Console.WriteLine($"\nReprovado com nota: " + mediaFinal.ToString("0.0"));
                }
                    
            }


            Console.ReadKey();

        }
    }
}