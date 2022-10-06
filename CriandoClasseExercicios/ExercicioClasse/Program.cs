namespace ExercicioClasse {
    internal class Program {
        static void Main(string[] args) {

            //Aviao aviao = new Aviao();

            //aviao.Marca = "AirBus";
            //aviao.Modelo = "A330";
            //aviao.Altitude = 100000;
            //aviao.Velocidade = 800;

            //aviao.Acelerar();
            //aviao.Descer();
            //aviao.ReduzirVelocidade();
            //aviao.Subir();
             string agencia;
             string tipoDeConta;
             decimal valor;
             string conta;
             double s, d;

            //Console.Write("Digite o número da agencia: ");
            //agencia = Console.ReadLine();

            //Console.Write("Digite o número da conta: ");
            //conta = Console.ReadLine();

            //Console.Write("Digite o tipo de conta: ");
            //tipoDeConta = Console.ReadLine();

            //Console.Write("Digit valor inicial a ser depositado na conta: ");
            //valor = decimal.Parse(Console.ReadLine());

           TransacaoBancaria contaBancaria = new TransacaoBancaria();

       
            contaBancaria.Depositar();
            contaBancaria.ConsultarSaldo();
            contaBancaria.ExibirDados();



            Console.ReadKey();
        }
    }
}