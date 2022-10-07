namespace Conta {
    internal class Program {
        static void Main(string[] args) {

            Cliente cliente = new Cliente();
            cliente.nome = "Isaias";
            cliente.idade = 44;

            Conta c = new Conta(cliente: cliente, saldo: 999.9m, tipo: "Corrente");
           
            while (true) {
                Console.Clear();

                Console.Write("Digite\n1- Sacar\n2- Depositar\n3-Consutar Saldo\n0-Sair\n: ");
                 int op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("Digite o valor do saque: ");
                        c.debitar(decimal.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Digite o valor do deposito: ");
                        c.creditar(decimal.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("O cliente " + c.cliente.nome + " Possui saldo de: " + c.getSaldo());
                        break;
                    
                    default:
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}