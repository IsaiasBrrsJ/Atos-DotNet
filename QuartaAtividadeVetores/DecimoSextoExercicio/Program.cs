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

            // falta terminar 

            int[] primeiroVetor = new int[5];
            int[] SegundoVetor = new int[primeiroVetor.Length];
            int[] uniao = new int[10];
            int[] diferenca = new int[10];
            Console.WriteLine("---- Preencha o X ----\n");
            for (int i = 0; i < primeiroVetor.Length; i++) {

                Console.Write($"Digite o {i + 1} valor: ");
                primeiroVetor[i] = int.Parse(Console.ReadLine());
                uniao[i] = primeiroVetor[i];
            }
            Console.WriteLine("\n---- Preencha o Y ----\n");
            for (int i = 0; i < SegundoVetor.Length; i++) {

                Console.Write($"Digite o {i + 1} valor: ");
                SegundoVetor[i] = int.Parse(Console.ReadLine());
            }

            int count = 5;

            for (int i = 0; i < primeiroVetor.Length; i++) {

                for (int j = 0; j < SegundoVetor.Length; j++) {

                    if (primeiroVetor[i] == SegundoVetor[j]) {
                       
                        break;
                    }

                    if (j == (SegundoVetor.Length - 1)) {
                        uniao[count] = SegundoVetor[i];
                        count++;
                    }

                }
            }

            for (int i = 0; i < count; i++) {


                Console.Write(uniao[i]+" |");
            }

            Console.WriteLine("\n------------ Diferenca entre x e y ----------------");
            int aux = 0;
            for (int i = 0; i < primeiroVetor.Length; i++) {
                for (int j = 0; j < SegundoVetor.Length; j++) {

                    if (primeiroVetor[i] == SegundoVetor[j]) {
                        diferenca[aux] = primeiroVetor[i];
                        aux++;
                        break;
                    }

                  
                }

            }

            //for (int i = 0; i < aux; i++) {
            //    Console.WriteLine(no)
            //}

            Console.ReadKey();
        }
    }
}