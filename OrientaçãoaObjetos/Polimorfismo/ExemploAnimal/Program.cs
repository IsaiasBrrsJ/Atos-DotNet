using ExemploAnimal.Classe;

namespace ExemploAnimal {
    internal class Program {
        static void Main(string[] args) {

            Animal a;
            a = new Leao("Lion", "X", "M");
            a.Caminhar();
            a.Dormir();
            a.EmitirSom();
            a.ExibirDados();

            Console.WriteLine("\n Lobo\n");
            a = new Lobo("Lobo", "Y", "M");
            a.Caminhar();
            a.Dormir();
            a.EmitirSom();
            a.ExibirDados();

            Console.ReadKey();
        }
    }
}