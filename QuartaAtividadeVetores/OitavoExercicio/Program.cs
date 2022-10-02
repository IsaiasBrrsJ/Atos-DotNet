namespace OitavoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             
             8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de
            cada número menor que zero desse vetor. Exemplo:
                a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
                b.	escreve: 	|3|5|6|7|9|10|14|. . .
             */

            int[] vet = new int[30];

            string indiceNegativos = "";

            for (int i = 0; i < vet.Length; i++) {

                Console.Write($"Digite o {i + 1} numero: ");
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] < 0) {

                    indiceNegativos += $"{i} |";
                }
            }

            for (int i = 0; i < vet.Length; i++) {

                Console.Write($"{vet[i]} |");
            }

            Console.WriteLine("\n"+indiceNegativos);
            

            Console.ReadKey();
        }
    }
}