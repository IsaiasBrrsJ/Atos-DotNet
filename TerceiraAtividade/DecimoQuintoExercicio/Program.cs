namespace DecimoQuintoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
                ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
                Considerar nota 7,0 como mínima para aprovação.
             */
            double notas = 0;
            double media = 0;

            for (int i = 1; i <= 4; i++) {

                Console.WriteLine("Informe a {0}º nota: ",i);
                 notas = double.Parse(Console.ReadLine());

                if (i == 1)
                    notas = (notas * 0.2);
                else if (i == 2)
                    notas = (notas * 0.1);
                else if (i == 3)
                    notas = (notas * 0.2);
                else
                    notas = (notas * 0.4);

                media += notas;
                notas = 0;
            }

           
          

            if (media > 7.0) {
                Console.WriteLine("Média Aprovado: "+ media.ToString("0.0"));
            }
            else {
                Console.WriteLine("Média Reprovado: "+ media.ToString("0.0"));
            }
            Console.ReadKey();
        }
    }
}