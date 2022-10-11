using ExercicioSeis.Classe;

namespace ExercicioSeis {
    internal class Program {
        static void Main(string[] args) {
            /*

             6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de
                 realizar as seguintes operações:
                 void armazenaPessoa(String nome, int idade, float altura);
                 void removePessoa(String nome);
                 int buscaPessoa(String nome); // informa em que posição da agenda está a pessoa
                 void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
             */

            int indiceVetor = 2;
            Agenda[] agenda = new Agenda[indiceVetor];
            int posicaoPreenchida = 0;

            Menu(ref agenda, ref posicaoPreenchida);

        }
        static void Menu(ref Agenda[] agenda, ref int posicaoPreenchida) {
            do {
                Console.Clear();
                Console.WriteLine("------------------------");
                Console.Write("1-Armazenar\n2-Remover\n3-Buscar\n4-Imprimir\n5-Sair\n\nEscolha: ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha < 1 || escolha > 5) {
                    continue;
                }
                else if (escolha == 5) {
                    break;
                }
                else {

                    switch (escolha) {

                        case 1:
                            ArmazenarPessoa(ref agenda, ref posicaoPreenchida);
                            break;
                        case 2:
                            RemoverPessoa(ref agenda, ref posicaoPreenchida);
                            break;
                        case 3:
                            int indice = BuscarPessoa(ref agenda, ref posicaoPreenchida);

                            if (indice != -1) {
                                Console.WriteLine(agenda[indice].nome);
                                Console.WriteLine(agenda[indice].idade);
                                Console.WriteLine(agenda[indice].altura);
                            }
                            break;

                        case 4:
                            ImprimeAgenda(ref agenda, ref posicaoPreenchida);
                            break;

                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }

                }

                Console.ReadKey();
            } while (true);
        static void ArmazenarPessoa(ref Agenda[] agenda, ref int posicaoPreenchida) {

                if (posicaoPreenchida < agenda.Length) {

                    for (int i = posicaoPreenchida; i < agenda.Length; i++) {

                        Console.Clear();
                        Console.Write($"{i + 1} Nome: ");
                        string nome = Console.ReadLine().ToLower();

                        Console.Write($"{i + 1} Idade:  ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write($"{i + 1} Altura: ");
                        float altura = float.Parse(Console.ReadLine());

                        agenda[i] = new() {
                            nome = nome,
                            idade = idade,
                            altura = altura
                        };
                        posicaoPreenchida++;

                    }
                }
                else {
                    Console.WriteLine("Agenda Cheia");
                }
               }

            }

        static void ImprimeAgenda(ref Agenda[] agenda,ref int posPreenchida) {

            if (posPreenchida == 0) {
                Console.WriteLine("Agenda Vazia");
            }
            else {

                for (int i = 0; i < posPreenchida; i++) {
                    Console.WriteLine(agenda[i].nome);
                    Console.WriteLine(agenda[i].idade);
                    Console.WriteLine(agenda[i].altura);
                }
            }
        }

        static void RemoverPessoa(ref Agenda[] agenda, ref int indiceVet) {


          
             int posicao = BuscarPessoa(ref agenda, ref indiceVet);


                if (posicao != -1) {

                    agenda[posicao] = agenda[indiceVet - 1];
                    indiceVet--;

                    Console.WriteLine("Removido com sucesso");
                }
        }

        static int BuscarPessoa(ref Agenda[] agenda, ref int indiceVet) {

            if (indiceVet == 0) {
                Console.WriteLine("Agenda Vazia");
               
            }
            else {

                Console.Write("Nome: ");
                string nomeBuscar = Console.ReadLine().ToLower();

                for (int i = 0; i < indiceVet; i++) {

                    if (nomeBuscar == agenda[i].nome) {
                        return i;
                    }
                }

            }
            return -1;
        }

    }
}