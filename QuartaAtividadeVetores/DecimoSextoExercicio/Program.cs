using System.Runtime.ExceptionServices;

namespace DecimoSextoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             
             16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
                •	A união de X com Y
                •	A diferença entre X e Y
                •	A interseção entre X e Y
                Escreva o vetor resultado de cada uma das operações.
             */



            int[] primeiroVetor = new int[6];
            int[] SegundoVetor = new int[primeiroVetor.Length];

            int[] uniaO = new int[primeiroVetor.Length * 2];
            int[] diferenecA = new int[primeiroVetor.Length];
            int[] diferencaB = new int[primeiroVetor.Length];
            int[] intersecaO = new int[primeiroVetor.Length];

            int countUniao = 0;
            int countDifeA = 0;
            int countDifeB = 0;
            int countInterse = 0;

            string uniao = "";
            string diferença = "";
            string intersecao = "";

            Console.WriteLine("---- Preencha o X ----\n");
            for (int i = 0; i < primeiroVetor.Length; i++) {

                Console.Write($"Digite o {i + 1} valor: ");
                primeiroVetor[i] = int.Parse(Console.ReadLine());
                uniao += $"{primeiroVetor[i]} ";
                uniaO[i] = primeiroVetor[i];
            }
            Console.WriteLine("\n---- Preencha o Y ----\n");
            for (int i = 0; i < SegundoVetor.Length; i++) {

                Console.Write($"Digite o {i + 1} valor: ");
                SegundoVetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < SegundoVetor.Length; i++) {

                for (int j = 0; j < primeiroVetor.Length; j++) {

                    if (SegundoVetor[i] == primeiroVetor[j]) {
                        break;
                    }

                    if (j == (primeiroVetor.Length - 1)) {
                        uniao += $"{SegundoVetor[i]} ";

                        uniaO[countUniao] = SegundoVetor[i];
                        countUniao++;
                    }
                }
            }
            Console.WriteLine("\n--------- A união de X com Y ---------\n");

            Console.WriteLine("\n A U B = {"+ uniao+" }");


            Console.WriteLine("\n------------ Diferenca entre X e Y ----------------");

            for (int i = 0; i < primeiroVetor.Length; i++) {

                for (int j = 0; j < SegundoVetor.Length; j++) {

                    if (primeiroVetor[i] == SegundoVetor[j]) {

                        break;
                    }

                    if (j == (SegundoVetor.Length - 1)) {

                        diferença += $"{primeiroVetor[i]} ";

                        diferenecA[countDifeA] = primeiroVetor[i];
                        countDifeA++;
                    }

                }

            }
            Console.WriteLine("X = {"+ diferença +" }");
            diferença = "";
            for (int i = 0; i < SegundoVetor.Length; i++) {

                for (int j = 0; j < primeiroVetor.Length; j++) {

                    if (SegundoVetor[i] == primeiroVetor[j]) {

                        break;
                    }

                    if (j == (SegundoVetor.Length - 1)) {

                        diferença += $"{SegundoVetor[i]} ";

                        diferencaB[countDifeB] = SegundoVetor[i];
                        countDifeB++;

                    }

                }

            }
            Console.WriteLine("Y = {" + diferença + " }");
            Console.WriteLine("\n------------ Interseção entre X e Y ----------------");

            for (int i = 0; i < primeiroVetor.Length; i++) {
                for (int j = 0; j < SegundoVetor.Length; j++) {
                    if (primeiroVetor[i] == SegundoVetor[j]) {

                        intersecao += $"{primeiroVetor[i]} ";

                        intersecaO[countInterse] = primeiroVetor[i];
                        countInterse++;
                    }
                }
            }

            Console.WriteLine("X ∩ Y = {"+ intersecao+" }");
            Console.ReadKey();
        }
    }
}