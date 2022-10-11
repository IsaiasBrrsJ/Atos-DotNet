using ExercicioSete.Classes;

namespace ExercicioSete {
    internal class Program {
        static void Main(string[] args) {
            /*
             7 - Crie uma classe denominada Elevador para armazenar as informações de um 
              elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0),
              total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas
              estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
              Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares 
              no prédio (os elevadores sempre começam no térreo e vazio);
              Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
              Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
              Sobe : para subir um andar (não deve subir se já estiver no último andar);
              Desce : para descer um andar (não deve descer se já estiver no térreo);
              Encapsular todos os atributos da classe (criar os métodos set e get).
             
             */

            Elevador elevador = new Elevador();
            elevador.setTotalAndares(5);
            elevador.setCapacidadeElevador(10);
           

            do {
                Console.Clear();
                Console.Write("[1] Entrar\n[2] Sair\n[3] Subir\n[4] Descer\nOpção: ");
                string opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida) {
                    case "1":
                        if (elevador.getPessoasNoElevador() < elevador.getCapacidadeElevador()) {
                            elevador.setPessoasNoElevador(1);
                            Console.WriteLine("Pessoas no elevador " + elevador.getPessoasNoElevador());
                        }
                        else {
                            Console.WriteLine("Elevador Cheio");
                        }

                        break;

                    case "2":
                        if (elevador.getPessoasNoElevador() > 0) {
                            elevador.setRemoverPessoasElevador(1);
                            Console.WriteLine("Pessoas no elevador: " + elevador.getPessoasNoElevador());
                        }
                        else {
                            Console.WriteLine("Não há pessoas no elevador");
                        }
                        break;

                    case "3":

                        if (elevador.getAndarAtual() < elevador.getTotAndares()) {
                            elevador.setSubir(1);
                            Console.WriteLine("Andar Atual: " + elevador.getAndarAtual());
                        }
                        else {
                            Console.WriteLine("Andar máximo");
                        }
                        break;
                    case "4":
                        if (elevador.getAndarAtual() > 0) {
                            elevador.setDescer(1);
                            Console.WriteLine("Andar atual: " + elevador.getAndarAtual());
                        }
                        else {
                            Console.WriteLine("Elevador está no térreo");
                        }
                        break;
                    default:
                      Console.WriteLine("Opção Incorreta");
                        break;
                }



                Console.ReadKey();
            } while (true);
        }
    }
}