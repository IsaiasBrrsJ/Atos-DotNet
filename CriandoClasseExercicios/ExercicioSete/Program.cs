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
            elevador.Inicializa(4, 5);

            do {

                Console.Clear();
                Console.WriteLine("\n[1]-Entrar\n[2]-Sair\n[3]-Subir\n[4]-Descer\n[5]-Finalizar\nOpcao: ");
                string opc = Console.ReadLine();

                switch (opc) {

                    case "1":
                        Console.WriteLine(elevador.Entrar());
                        break;
                    case "2":
                        Console.WriteLine(elevador.Sair());
                        break;
                    case "3":
                        Console.WriteLine(elevador.Sobe());
                        break;
                    case "4":
                        Console.WriteLine(elevador.Desce());
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcao Incorreta");
                        break;
                }

                Console.ReadKey();
            } while (true);
        }
    }
}