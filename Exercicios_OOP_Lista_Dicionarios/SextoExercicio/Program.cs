using SextoExercicio.Classes;

namespace SextoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6) Crie uma classe para funcionário. Ele deve ter o nome do funcionário, o departamento onde trabalha,
                seu salário (double), a data de entrada no banco (String), seu RG (String) e um valor booleano que indique se o
                funcionário ainda está ativa na empresa no momento ou se já foi mandado embora.
                Você deve criar alguns métodos de acordo com sua necessidade. Além deles, crie um método bonifica
                que aumenta o salario do funcionário de acordo com o parâmetro passado como argumento. Crie, também, um
                método demite, que não recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.
                Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir e consultar todos os funcionários cadastratos.
                Utilizando o exercício anterior, faça um método abstrato na classe funcionário chamado "ExecutaTrabalho". 
                Haverá duas implementações da classe Funcionario chamada de Gerente e Operador. 
                Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada pelo funcionário
             */

            List<Funcionario> funcionarios = new List<Funcionario>();

            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t================\n\tEmpresa Camaleao\n\t================");
                Console.Write("\n[1]-Inserir Funcionário\n[2]- Consultar Funcionários Cadastrados\n[3]-Sair\nOpcao: ");

                if ((int.TryParse(Console.ReadLine(), out opc) == false) || (opc < 0 || opc > 3))
                {
                    Console.WriteLine("Escolha uma opção apropriada, presione para continuar");
                    Console.ReadKey();
                    continue;
                }
                else
                {

                    if (opc == 1)
                    {
                        int opcCadastro;
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("\n[1]-Gerente[2]-Operador\nOpcao: ");
                            if (int.TryParse(Console.ReadLine(), out opcCadastro) == false || (opcCadastro < 1 || opcCadastro  > 2))
                            {
                                Console.WriteLine("Escolha uma opção apropriada, presione para continuar");
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                if(opcCadastro == 1) { funcionarios.Add(Gerente()); break;}
                                else
                                {
                                    funcionarios.Add(Operador());
                                    break;
                                }
                                
                            } 

                        } while (true);
                    }
                    else
                    {
                        Console.WriteLine("\nFuncionário Cadastrados\n");
                        foreach (var item in funcionarios)
                        {
                            Console.WriteLine("Nome Funcionário: " + item.NomeFuncionario);
                            Console.WriteLine("RG Funcionário: " + item.RG);
                            Console.WriteLine("Data Admissão: " + item.DataEntradaNoBanco);
                            Console.WriteLine("Departamento: " + item.Departamento);
                            Console.WriteLine("Salário: " + item.SalarioFuncionario.ToString("C"));
                            item.ExecutaTrabalho();
                            Console.WriteLine("Ativo Na Empresa: " + item.AtivoNaEmpresa + "\n");
                        }
                        Console.ReadKey();
                    }
                }
            } while (true);

        }
        static Operador Operador()
        {
            Console.Clear();
            Operador operador = new Operador();

            Console.Write("Nome: Funcionário: ");
            operador.NomeFuncionario = Console.ReadLine();

            Console.Write("Departamento: ");
            operador.Departamento = Console.ReadLine();

            Console.Write("Data de Admissao (dd/MM/yyyy): ");
            operador.DataEntradaNoBanco = Console.ReadLine();

            Console.Write("RG: ");
            operador.RG = Console.ReadLine();

            Console.Write("Salário: ");
            operador.SalarioFuncionario = double.Parse(Console.ReadLine().ToString().Replace(",", "."));

            operador.bonifica(0.15);

            int opcAtivoEmpresa;
            do
            {
                Console.Write("Ativo na empresa 1-Sim, 2-Nao: ");
            } while (int.TryParse(Console.ReadLine(), out opcAtivoEmpresa) == false || (opcAtivoEmpresa < 0 || opcAtivoEmpresa > 2));

            if (opcAtivoEmpresa == 1)
                operador.AtivoNaEmpresa = true;
            else
                operador.Demitido();

            return operador;
        }
        static Gerente Gerente()
        {
            Console.Clear();

            Gerente gerente = new Gerente();

            Console.Write("Nome: Funcionário: ");
            gerente.NomeFuncionario = Console.ReadLine();

            Console.Write("Departamento: ");
            gerente.Departamento = Console.ReadLine();

            Console.Write("Data de Admissao (dd/MM/yyyy): ");
            gerente.DataEntradaNoBanco = Console.ReadLine();

            Console.Write("RG: ");
            gerente.RG = Console.ReadLine();

            Console.Write("Salário: ");
            gerente.SalarioFuncionario = double.Parse(Console.ReadLine().ToString().Replace(",","."));

            gerente.bonifica(0.15);

            int opcAtivoEmpresa;
            do
            {
                Console.Write("Ativo na empresa 1-Sim, 2-Nao: ");
            } while (int.TryParse(Console.ReadLine(), out opcAtivoEmpresa) == false || (opcAtivoEmpresa < 0 || opcAtivoEmpresa > 2));

            if (opcAtivoEmpresa == 1)
                gerente.AtivoNaEmpresa = true;
            else
                gerente.Demitido();


            return gerente;
        }
       
    }
}