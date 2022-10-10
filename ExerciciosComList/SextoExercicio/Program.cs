using System.Globalization;

namespace SextoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             
             6. Continuação do exercício 1. Entretanto, quando listar os nomes, mostrar somente os sobrenomes.
                Além disso, o programa deve mostrar as pessoas que são da mesma família.
             */

            string nome = "";
            string[] nomeSplit;
            string sobrenome = "";
            List<string> nomePessoas = new List<string>();
            List<string> sobrenomes = new List<string>();
            Console.WriteLine("Digite 1 para sair\n");

           
            do {

                int cont = 0;

                Console.Write("Informe seu nome completo: ");
                nome = Console.ReadLine().ToUpper();

                cont++;
                nomeSplit = nome.Split(" ");

                if (nomeSplit.Length >= 2) {
                    sobrenome += $"{nomeSplit[cont].ToString()}\n";
               }

                if (nome == "1") {
                    break;
                }
                else {
                    if (nomeSplit.Length < 2) {
                        Console.WriteLine("Nome precisa ser completo");
                    }
                    else if (nomePessoas.Contains(nome.ToUpper())) {
                        Console.WriteLine("Nome informado já cadastrado");
                    }
                    else {
                        nomePessoas.Add(nome);
                        sobrenomes.Add(nomeSplit[cont].ToString());

                        
                    }

                }

            } while (true);
            Console.WriteLine("\n---------Sobrenomes--------\n");
            Console.WriteLine(sobrenome);
            Console.WriteLine("\n---------------------------\n");
            Console.WriteLine("\nParentes ");

           
            for (int i = 0; i < nomePessoas.Count; i++) {
                int qtdSobrenomeIguais = 0; // toda vez que voltar pro for principal é zerado essa variável

                for (int j = 0; j < sobrenomes.Count; j++) {

                    if (nomePessoas[i].Contains(sobrenomes[j])) {
                        qtdSobrenomeIguais++; // se contém na lista nome pessoa sobrenome conta um;
                    }

                    if (qtdSobrenomeIguais == 2) { // existe dois sobrenomes cadastrados igual então entra aqui e mostra o primeiro parente e para o segundo laço j
                        Console.WriteLine(nomePessoas[i]);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }


    }
}