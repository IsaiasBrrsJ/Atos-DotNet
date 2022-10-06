using System.Text.Json.Serialization;

namespace QuartoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             4. Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar) 
                completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da criptomoeda deve 
                ser cadastrado (em maiúsculo). Ao cadastrar, não pode haver duplicidade de dados na lista. Sempre
                que a opção listar for acionada, a listagem deve ser exibida de forma ordenada. No processo de 
                remoção, o usuário entra com o nome da criptomoeda que deseja remover. Caso o programa a encontre,
                deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
                ao usuário que nome não foi encontrado.

                Menu 
                1 - Cadastrar criptomoeda 
                2 - Listar criptomoedas
                3 - Remover criptomoeda
                4 - Sair
                Opção: 
             
             */
            int opcDigitada = 0;
            List<string> listCriptomoedas = new List<string>();
            string nomeCripto = "";
            bool opcaoCorreta = true;
            do {
                Console.Clear();
                Console.WriteLine("\t------------- Menu -------------");
                Console.Write("\t 1- Cadastrar criptomoeda\n\t 2- Listar criptomoedas\n\t 3- Remover criptomoeda\n\t 4- Sair\n");
                Console.WriteLine("\t------------- ==== -------------");
                Console.Write("\n\tOpção: ");
                opcaoCorreta = int.TryParse(Console.ReadLine(), out opcDigitada);

                if (opcDigitada is 4) {
                    break;
                }
                else {
                    if (opcaoCorreta is false || (opcDigitada <= 0 || opcDigitada > 4)) {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite uma opção válida, pressione qualquer tecla");
                        Console.ReadKey();
                        Console.ResetColor();
                        continue;
                    }
                    else {

                        if (opcDigitada is 1) {

                            do {

                                Console.Clear();

                                Console.Write("Digite o nome da criptomoeda OU (1 para sair): ");
                                nomeCripto = Console.ReadLine().ToUpper();

                                if (nomeCripto is "1") {
                                    break;
                                }
                                else if (listCriptomoedas.Contains(nomeCripto) || String.IsNullOrWhiteSpace(nomeCripto)) {

                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine($"\nNão é possivel adcionar {nomeCripto}, digite novamente, pressione para continuar");
                                    Console.ReadKey();

                                    Console.ResetColor();
                                    continue;
                                }
                                else {

                                    listCriptomoedas.Add(nomeCripto);
                                    listCriptomoedas.Sort();

                                    Console.ForegroundColor = ConsoleColor.Green;

                                    Console.WriteLine("Cripto adcionada com sucesso, pressione para continuar");
  
                                    Console.ResetColor();
                                    break;
                                }

                            } while (true);
                        }
                        else if (opcDigitada is 2) {


                            if (listCriptomoedas.Count > 0) {

                                foreach (var cripto in listCriptomoedas) {

                                    Console.WriteLine("Nome da criptomoeda:" + cripto);
                                }
                            }
                            else {
                                Console.WriteLine("Lista Vazia");
                            }

                        }
                        else {

                            if (listCriptomoedas.Count > 0) {

                                Console.Write("\nDigite o nome da criptomoeda que deseja remover: ");
                                nomeCripto = Console.ReadLine().ToUpper();

                                if (listCriptomoedas.Contains(nomeCripto)) {

                                    listCriptomoedas.Remove(nomeCripto);

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"\n{nomeCripto} removido com sucesso");
                                }
                                else {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\n{nomeCripto} não encontrado");
                                }
                            }
                            else {

                                Console.WriteLine("\nLista vazia");
                            }

                            Console.ResetColor();
                        }

                        Console.ReadKey();
                    }

                }

            } while (true);
        }
    }
}