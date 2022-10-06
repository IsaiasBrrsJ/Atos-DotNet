namespace AppOO {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Apresentando Classes, objetos, métodos e orientação a objetos básica\n");

            Lampada l1 = new Lampada();
            bool retorno;
            l1.ligar();
            retorno = l1.estaLigada();
            
            Console.WriteLine("Status da Lâmpada "+ retorno);
            l1.desligar();
            Console.WriteLine("Status da Lâmpada " + retorno);
            Console.ReadKey();
        }
    }
}