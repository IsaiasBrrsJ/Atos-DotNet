namespace QuintoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             
             5. Crie um programa em VS que popule duas listas (lista1 e lista2)
                 com números aleatórios (100 a 200).
                A quantidade de números deve ser informada pelo usuário. Em seguida, o programa deve listar os 
                conteúdos das duas listas e exibir os números que aparecem em ambas as listas.
             */
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();
            int qtdNumeros = 0;
            string numerosQueAparecemEmAmbasAsListas = "";

            Console.Write("Informe a quantidade de numeros: ");
             qtdNumeros = int.Parse(Console.ReadLine()); 



            for (int i = 0; i < qtdNumeros; i++) {
                lista1.Add(new Random().Next(100, 201));
                lista2.Add(new Random().Next(100, 201));

                if (lista1[i] == lista2[i]) {
                    
                    numerosQueAparecemEmAmbasAsListas += $"{lista1[i]} |";
                }
            }

            Console.WriteLine("\nPrimeira Lista");
            for (int i = 0; i < lista1.Count; i++) {
                Console.Write(lista1[i] +" |");
            }
            Console.WriteLine("\n\nSegunda Lista");
            for (int i = 0; i < lista2.Count; i++) {
                Console.Write(lista2[i] + " |");
            }

            Console.WriteLine("\n\nNúmeros que aparecem em ambas as listas");
            if (numerosQueAparecemEmAmbasAsListas != "")
                Console.WriteLine(numerosQueAparecemEmAmbasAsListas);
            else
                Console.WriteLine("\nOs números gerados para lista um e lista dois não se repetem");

            Console.ReadKey();
        }
    }
}