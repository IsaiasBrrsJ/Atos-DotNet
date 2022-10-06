namespace TerceiroExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
            3. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
            o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
            lista, o programa deve listar os domínios de emails cadastrados no programa.

            Menu
            1 - Cadastrar email
            2 - Listar 
            3 - Sair 
            Opção: 
           */
            int opcao = 0;
            bool opcaoCorreta = true;
            string emailInformado = "";
            string dominio = "";
            string dominiosEmail = "";
            List<string> emailsCadastrados = new List<string>();

            do {


                Console.Clear();
                Console.WriteLine("\n\tMenu\n\n1-Cadastrar email\n2-Listar\n3-Sair\nOpção: ");
                opcaoCorreta = int.TryParse(Console.ReadLine(), out opcao);

                if (opcao == 3) {
                    break;
                }
                else if (opcaoCorreta is false || (opcao <= 0 || opcao > 3)) {
                    Console.WriteLine("Forneça as informações corretamente, pressiona qualquer tecla para continuar");
                    Console.ReadKey();
                    continue;
                }
                else {

                    if (opcao is 1) {

                        Console.WriteLine("Digite o email: ");
                        emailInformado = Console.ReadLine().ToLower();

                        if (emailsCadastrados.Contains(emailInformado)) {
                            Console.WriteLine($"Email [{emailInformado}] já está cadastrado, pressione qualquer tecla para continuar");
                            Console.ReadKey();
                            continue;
                        }
                        else {

                            emailsCadastrados.Add(emailInformado);
                            dominio = emailInformado.Substring(emailInformado.IndexOf("@"));
                            dominiosEmail += $"{dominio}\n";

                            Console.WriteLine("Cadastrado com sucesso, pressione para continuar");
                            Console.ReadKey();
                        }
                    }
                    else {
                        Console.WriteLine("Listagem dos emails cadastrados\n");
                        if (emailsCadastrados.Count > 0) {

                            foreach (var emails in emailsCadastrados) {

                                Console.WriteLine(emails);
                            }
                            Console.Write("\nDominios\n");
                            Console.WriteLine(dominiosEmail);

                        }
                        else {
                            Console.WriteLine("Não foram encontrados emails cadastrados");
                        }

                        Console.ReadKey();
                    }
                } 

            } while (true);

        }
    }
}