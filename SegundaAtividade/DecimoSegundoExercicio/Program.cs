namespace DecimoSegundoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             12 - Elabore um programa em VS que leia as variáveis "codigo"
                  e "numeroHoras", respectivamente código e 
                  número de horas trabalhadas de um operário.
                  Na sequência, calcule o salário sabendo-se que ele ganha 
                  R$ 10,00 por hora. Quando o número de horas exceder a
                  50 calcule o excesso de pagamento 
                  armazenando-o na variável "extra", caso contrário zerar
                  tal variável. A hora excedente de trabalho vale R$ 20,00. 
                 No final do processamento, exibir o salário total e o salário excedente do operário.
             
             */

            int cod;
            int numHora =0;
            double calcSalario =0;
            double extra =0;

            Console.WriteLine("Informe seu cod: ");
             cod = int.Parse(Console.ReadLine());

            Console.Write("Numero de horas trabalhadas: ");
             numHora = int.Parse(Console.ReadLine());

            if (numHora > 50) {
                extra = 20.0 * (numHora - 50);
                calcSalario = 10.0 * (numHora - (numHora - 50) );
            }
            else {
                calcSalario = 10.0 * numHora;
            }

            Console.WriteLine($"\nSalario total: {calcSalario.ToString("C")} \nSalario excendente: {extra.ToString("C")}");
            Console.ReadKey();

        }
    }
}