namespace DecimoOitavoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
              18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
                    elevada a um expoente qualquer, ou seja, NM.
           */

            Console.Write("Informe a base: ");
            int basePo = int.Parse(Console.ReadLine());

            Console.Write("Informe o expoente: ");
            int expoente = int.Parse(Console.ReadLine());


            int resultado = basePo;

            //base 2 elevado a 8;
            // 2x2x2x2x2x2x2x2;

            for (int i = 1; i < expoente; i++) {

               resultado *= basePo;
            }
            
            Console.Write(resultado);

            Console.ReadKey();
        }
    }
}