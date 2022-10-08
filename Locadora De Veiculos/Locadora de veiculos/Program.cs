using Locadora_de_veiculos.Classes;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace Locadora_de_veiculos {
    internal class Program {
        static void Main(string[] args) {

            List<Carro> carrosDisponiveis = new(){
                new Carro(modelo: "Sedã", anoModelo: "2022", nomeModelo: "Civic", placa: "NCE-0021"),
                new Carro(modelo: "Conversivel", anoModelo: "2019", nomeModelo: "Corvet", placa: "NBX-2212"),
                new Carro(modelo: "Pickup", anoModelo: "2012", nomeModelo: "Hilux", placa: "ABC-123")
            };

            List<Aluguel> aluguelCarro = new List<Aluguel>();

            MenuOpcoes(ref carrosDisponiveis, ref aluguelCarro);

            Console.ReadKey();
            
        }
        static bool VerificarSeOClienteJaAlugouOCarro(ref List<Aluguel> cliente, string cpf, string placa) {


            foreach (var item in cliente) {

                if ((item.cliente.getCPF() == cpf || item.cliente.getCPF() != cpf) && (item.getDevolucaoCarro() is false && item.carro.getPlaca() == placa)) {
                    return true;
                }
            }

            return false;
        }
        static void AlugarVeiculo(ref List<Carro> carrosDisponiveis, ref List<Aluguel> aluguel) {

            Console.Write($"\tCPF: ");
            string CPF = Console.ReadLine();


            Console.Write("\tNome Do Cliente: ");
             string nomeCliente = Console.ReadLine();

            Console.Write($"\tEndereço: ");
             string enderecoCliente = Console.ReadLine();

            Console.Write($"\tTelefone: ");
             string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nomeCliente, enderecoCliente, CPF, telefone);
            
            int indice = Carros(ref carrosDisponiveis);

            var verificacao = VerificarSeOClienteJaAlugouOCarro(ref aluguel, CPF, carrosDisponiveis[indice].getPlaca());

            if (verificacao is false) {

                aluguel.Add(new() {
                    carro = carrosDisponiveis[indice],
                    cliente = cliente
                });
                Console.WriteLine("\n\tCadastrado com sucesso, pressione qualquer tecla para continuar...");
            }
            else {
                Console.Write($"\n\tCarro: {carrosDisponiveis[indice].getNomeModelo()}\n\tPlaca: [{carrosDisponiveis[indice].getPlaca()}] já está alugado");
            }
            Console.ReadKey();

        }

        static int Carros(ref List<Carro> carrosDisponiveis) {

            int contador = 1;
            Console.Clear();
            Console.WriteLine();
                foreach (var item in carrosDisponiveis) {

                    Console.WriteLine($"\t{contador}- Carro: {item.getNomeModelo()}-{item.getModelo()} ");

                    contador++;
                }

                Console.Write("\tDigite a opção: ");
                int opc = int.Parse(Console.ReadLine());

            if (opc == 1) {
                return 0;
            }
            else if (opc == 2) {
                return 1;
            }
            else {
                return 2;
            }
         
           
        }

        static void ConsultarVeiculo(ref List<Carro> carrosDisponiveis) {

            Console.Clear();
            Console.Write("\tInforme a placa do carro: "); 
             string placa = Console.ReadLine().ToUpper();

            bool carroEncontrado = false;

            foreach (var item in carrosDisponiveis) {

                if (placa.Equals(item.getPlaca())){

                    Console.WriteLine("\tVeículo: " + item.getNomeModelo());
                    Console.WriteLine("\tModelo: " + item.getModelo());
                    Console.WriteLine("\tPlaca: " + item.getPlaca()); 
                    carroEncontrado = true;
                    break;
                }
            }

            if (carroEncontrado is false) {
                Console.WriteLine("\n\tCarro Não Encontrado");
            }

            Console.ReadKey();
            
        }
        static void ConsultarCliente(ref List<Aluguel>  aluguelCarro) {
            
            Console.Clear();
            Console.Write("Informe o CPF: ");
            string cpf = Console.ReadLine();

            bool clienteEncontrado = false;
            Console.WriteLine();
            foreach (var item in aluguelCarro) {
                       
                
                    if (cpf.Equals(item.cliente.getCPF())) {

                        Console.WriteLine("\n\tCliente: " + item.cliente.getNome());
                        Console.WriteLine("\tCarro Alugado: " + item.carro.getNomeModelo() + "-" + item.carro.getModelo());
                        
                        Console.WriteLine("\tPlaca: " + item.carro.getPlaca());
                        Console.WriteLine("\tData Aluguel: " + item.getData());

                        if (item.getDevolucao() != null) {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\tSituação: Devolvido \n\tDia: " + item.getDevolucao());
                        }
                        else {
                            Console.Write("\tSituação: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Em Circulação ");
                        }
                        clienteEncontrado = true;
                    }
                    Console.ResetColor();
                }
            
            if (clienteEncontrado is false) {
                Console.WriteLine("\n\tCliente não encontrado");

            }

            Console.ReadKey();
        }
        static void DevolverVeiculo(ref List<Aluguel> cliente) {
            Console.Clear();
            Console.WriteLine();
            Console.Write("\tInforme o cpf do cliente: ");
             string cpfCliente = Console.ReadLine();

            Console.Write("\tInforme a placa do carro: ");
            string placaCarro = Console.ReadLine().ToUpper();

            string nomeCliente = "";
            bool devolucaoOK = false;
            bool possuiVeiculosDevolver = true;
            
            foreach (var item in cliente) {

                if (
                    (cpfCliente.Equals(item.cliente.getCPF()) && placaCarro.Equals(item.carro.getPlaca()))
                    && item.getDevolucao() is null) {

                    item.setDevolucao();
                    item.setDevolucaoCarro();
                    devolucaoOK = true;
                    break;
                }

                if (item.getDevolucao() is not null && 
                   ( cpfCliente.Equals(item.cliente.getCPF()) && placaCarro.Equals(item.carro.getPlaca())) )
                {
                    nomeCliente = item.cliente.getNome();
                    possuiVeiculosDevolver = false;
                }
            }

            if (devolucaoOK) {
                Console.WriteLine("\n\tDevolução Efetuada com Sucesso");
                
            }
            else if (possuiVeiculosDevolver is false) {

                Console.WriteLine($"\n\tO cliente {nomeCliente}, não possui veículos a serem devolvidos, tente consultar a situação do cliente opção 3");
            }
            else {
                Console.Write("\n\tDados incorretos ou inexistentes...");
            }
            Console.ReadKey();

        }

        static void MenuOpcoes(ref List<Carro> carros, ref List<Aluguel> aluguelCarro) {

            int opcaoSelecionada = 0;
            do {

                Console.Clear();
                Console.WriteLine("\t+==============================+");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\t+ SISTEMA DE ALUGUEL DE CARROS +");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t+==============================+");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\t+    1- Alugar Veículo         +");
                Console.WriteLine("\t+    2- Consultar Veículo      +");
                Console.WriteLine("\t+    3- Consultar Cliente      +");
                Console.WriteLine("\t+    4- Devolver Veiculo       +");
                Console.WriteLine("\t+    5- Sair                   +");
                Console.ResetColor();
                Console.WriteLine("\t+------------------------------+");

                Console.Write("\tOpcão: ");
                int.TryParse(Console.ReadLine(), out opcaoSelecionada);


                switch (opcaoSelecionada) {

                    case 1:
                        AlugarVeiculo(ref carros, ref aluguelCarro);
                        break;
                    case 2:
                        ConsultarVeiculo(ref carros);
                        break;
                    case 3:
                        ConsultarCliente(ref aluguelCarro);
                        break;
                    case 4:
                        DevolverVeiculo(ref aluguelCarro);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                        
                }
            } while (true);
             
        }
        
    }
}