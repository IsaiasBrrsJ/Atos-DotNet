namespace ConsoleApp00 {
    internal class Program {
        static void Main(string[] args) {
            // computador sempre vai vasculha os arquivps procurando pela  class program, depois o Main();

            Carro carro = new Carro(); // new operador que invoca o construtor, semore depois do new é invocado o construtor;

            carro.ligar();
            carro.setCor("Azul");

          

            Console.WriteLine(carro.getCor());

            bool status = carro.getLigado();

            if (status) {
                Console.WriteLine("O carro está ligado");
            }
            else{
                Console.WriteLine("O carro está desligado");
            }



            Console.ReadKey();
        }
    }
}