namespace NonoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
                9 - Faça um programa no VS que receba do usuário 3 valores de
                    glicemia em jejum, representando a medição
                    diária de um paciente diabético. Para cada
                    valor recebido analisar e informar ao paciente o seguinte:
                    Se o valor diário for menor que 65, avisá-lo
                    que corre risco de hipoglicemia
                    Se o valor diário for maior que 250, avisá-lo que
                  corre risco de hiperglicemia.

                    Além disso, o programa deve fazer a média dos 3 valores 
                    de glicemia coletados. E se a média for 
                    menor que 80, avisá-lo que é preciso diminuir 2 unidades de 
                    insulina. Se a média for maior que
                    150, avisá-lo que será necessário adicionar 2 unidades de insulina.
             */

            int primeiraMedicao, segundaMedicao, terceiraMedicao, somaGlicemia = 0;
            Console.Write("Primeira medição de glicemia: ");
            primeiraMedicao = int.Parse(Console.ReadLine());

            Console.Write("Segundo medição de glicemia: ");
            segundaMedicao = int.Parse(Console.ReadLine());

            Console.Write("Terceira medição de glicemia: ");
            terceiraMedicao = int.Parse(Console.ReadLine());

            somaGlicemia = (primeiraMedicao + segundaMedicao + terceiraMedicao);

            if (somaGlicemia > 250) {
                Console.WriteLine("\nVc corre risco de hiperglicemia");
            }
            else {
                if (somaGlicemia < 65) {
                    Console.WriteLine("\nVc corre risco de hipoglicemia");
                }
            }
            

    

            if ((somaGlicemia / 3) > 150) {
                Console.WriteLine("\nSerá necessário adicionar 2 unidades de insulina.");
            }else if((somaGlicemia / 3) > 65) {
                Console.WriteLine("\nÉ preciso diminuir 2 unidades de insulina");
            }

            Console.ReadKey();

        }   
    }
}