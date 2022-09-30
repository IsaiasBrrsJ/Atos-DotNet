namespace DecimoPrimeiroExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
                11 - Faça um programa no VS que receba uma hora,
                    dividida em 2 variáveis (uma para hora e outra para minutos).
                    O programa deve exibir se a hora digitada está ou não válida. 
                    Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
             */

            Console.WriteLine("Informe uma hora: ex(12:34): ");
            string horaTempo = Console.ReadLine();

            int hora;
            int minuto;

            hora = int.Parse(horaTempo.Substring(0, 2));
            minuto = int.Parse(horaTempo.Substring(3, 2));


            if ((hora == 0 || hora <= 23) && (minuto >= 0 && minuto <= 59)) {
                Console.WriteLine("Hora válida: " + hora + ":" + minuto);

            }
            else {
                Console.WriteLine("Formato de hora Inválido");

            }
          
            Console.ReadKey();


        }
    }
}