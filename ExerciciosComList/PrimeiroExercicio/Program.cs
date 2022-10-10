namespace PrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             1. Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
                Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e 
                que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e 
                exibir a lista ordenada
             */

            string nome = "";
            string[] nomeSplit;

            List<string> nomePessoas = new List<string>();
            Console.WriteLine("Digite 1 para sair\n");
            do {
               
                Console.Write("Informe seu nome completo: ");
                 nome = Console.ReadLine();
                 nomeSplit = nome.Split(" ");

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
                        nomePessoas.Add(nome.ToUpper());
                    }

                }
            
            } while (true);

            nomePessoas.Sort();

            if (nomePessoas.Count > 0) {

                Console.WriteLine("Exibindo nomes");
                foreach (var nomes in nomePessoas) {
                    Console.WriteLine(nomes);
                }
            }


            Console.ReadKey();
        }
    }
}