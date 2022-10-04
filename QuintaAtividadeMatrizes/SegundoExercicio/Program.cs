namespace SegundoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             
             2) Solicite ao usuário, preencher uma Matriz 3x3
                Informe ao usuário:
                *A soma dos elementos de cada linha
	             -Ex: Linha 1: 30
	              Linha 2: 17
                  *A soma dos elementos de cada coluna
	              -Ex: Coluna 1: 23
	               Coluna 2: 36
             */

            int[,] matriz = new int[3, 3];
            int somaPrimeira = 0;
            int somaSegunda = 0;
            int somaTerceira = 0;
            int somaPrimeiraColuna = 0;
            int somaSegundaColuna = 0;
            int somaTerceiraColuna = 0;

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {

                    Console.Write($"Digite o valor para [ {i + 1},{j + 1} ]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (i == 0) {
                        somaPrimeira += matriz[i, j];
                    }
                    else if (i == 1) {
                        somaSegunda += matriz[i, j];
                    }
                    else {
                    
                       if(i == 2)
                         somaTerceira += matriz[i, j];
                    }

                    if (j == 0) {
                        somaPrimeiraColuna += matriz[i, j];
                    }
                    else if (j == 1) {
                        somaSegundaColuna += matriz[i, j];
                    }
                    else {
                        somaTerceiraColuna += matriz[i, j];
                    }

                }
  
            }
          
            Console.WriteLine("\nlinha 1: " + somaPrimeira);
            Console.WriteLine("Linha 2: " + somaSegunda);
            Console.WriteLine("Linha 3: " + somaTerceira);
            Console.WriteLine("\nColuna 1: " + somaPrimeiraColuna);
            Console.WriteLine("Coluna 2: " + somaSegundaColuna);
            Console.WriteLine("Coluna 3: " + somaTerceiraColuna);
            Console.ReadKey();
        }
    }
}