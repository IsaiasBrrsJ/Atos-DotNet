namespace SetimoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
                7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
                A cada solicitação, teste se o usuário informou um valor válido. 
                Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
                informe que ele está incorreto e saia do programa em VS. 
                Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
                informe que está errada e saia. Se estiver correta, solicite o salário. 
                Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
                Se estiver correto, mostre todos os valores lidos.
             
             */
            string nome = "";
            int idade;
            double salario;
            string resultado = "";

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();


            for (int i = 0; i > -1; i++) {

                if (nome.Contains(i.ToString()) || (nome.Contains(" ") || nome is "")){

                    resultado = "Nome Incorreto";
                    break;
                }

                if ((nome.Length + 10) == i) {
                    break;
                }
            }

            if (resultado is not "Nome Incorreto") {

                Console.Write("Digite sua idade: ");
                if (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0) {

                    resultado = "Idade Incorreta";
                }
                else {

                    Console.Write("Informe seu salario: ");

                    if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0) {

                        resultado = "Salário Incorreto";
                    }
                    else {

                        resultado = $"Nome: {nome}\nIdade: {idade}\nSalário: {salario}";
                    }

                }
            }



            Console.WriteLine("\n" + resultado);
                Console.ReadKey();
                Environment.Exit(0);
            

            
        }
    }
}