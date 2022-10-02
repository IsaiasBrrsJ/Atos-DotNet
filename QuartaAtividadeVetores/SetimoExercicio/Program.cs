namespace SetimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um
                vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
                a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
                b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|
             */


            // falta concluir
            int[] vet = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.Write("Digite o {0} valor: ", i + 1);
                vet[i] = int.Parse(Console.ReadLine());
            }

            int pos = 0;
            int pos2 = 0;
            for (int i = 0; i < 10; i++) {

                if ((i + 1) < 10) {

                    if (vet[i + 1] % 2 == 0) {

                        Console.WriteLine(i);
                        pos = vet[i + 1];
                        pos2 = vet[i];
                        vet[i] = pos;
                        vet[i + 1] = pos2;

                    }
                }
            
            }

            for (int i = 0; i < 10; i++) {

                Console.Write("{0} |", vet[i]);
            }


            Console.ReadKey();
        }


    }
}