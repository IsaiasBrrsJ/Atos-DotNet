namespace SetimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma
              palavra de pesquisa.
              O programa deve avaliar se a palavra aparece na frase, informando
              o usuário via mensagem, como por 
               exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase
             */

            string frase, palavra;

            Console.Write("Digite uma frase: ");
             frase = Console.ReadLine();

            Console.Write("Palavra que deseja pesquisar: "); 
             palavra = Console.ReadLine();

            if (frase.Contains(palavra)) {
                Console.WriteLine($"\nA {palavra} encontra-se na frase");
            }
            else {
                Console.WriteLine($"\nA {palavra} não se encontra na frase");
            }

            Console.ReadKey();
        }
    }
}