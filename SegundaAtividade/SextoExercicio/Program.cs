namespace SextoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             6 - Faça um programa em C# e no Visual Studio para receber o nome
                   (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
                   O programa deve calcular o Indice de Massa Corpórea
                   (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
                   O cálculo do imc = peso / (altura * altura)

                    IMC 
                    menor que 18                -> baixo peso
                    maior que 18 e menor que 25 -> peso normal
                    maior que 25 e menor que 30 -> sobrepeso
                    maior que 30 e menor que 35 -> obesidade
                    maior que 35                -> obesidade grau sério
             */
            string nome, resultado = "";
            double altura = 0, peso = 0, IMC = 0;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine().ToUpper();

            Console.Write("Informe sua altura: ");
             altura = double.Parse(Console.ReadLine());

            Console.Write("Informe seu peso (KG): ");
            peso = double.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            if (IMC > 35) {
                resultado = "Obesidade grau sério";
            }
            else if (IMC > 30) {
                resultado += "Obesidade";
            }
            else if (IMC > 25) {
                resultado += "Sobrepeso";
            }
            else if (IMC > 18) {
                resultado += "Peso normal";
            }
            else {
                resultado += "Baixo peso";
            }

            Console.WriteLine("\n"+resultado);
            Console.ReadKey();

        }
    }
}