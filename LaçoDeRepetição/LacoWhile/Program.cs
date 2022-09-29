namespace LacoWhile {
    internal class Program {
        static void Main(string[] args) {

            //int inicio = 0, final = 0;
            //int somaPares = 0, contaImpares = 0;

            //Console.Write("Informe o incicio da contagem: ");
            //inicio = int.Parse(Console.ReadLine());

            //while (inicio >= final) {

            //    Console.Write("Informe o final da contagem: ");
            //    final = int.Parse(Console.ReadLine());
            //}

            //for (int i = (inicio + 1); i < final; i++) {

            //    if (i % 2 == 0) {
            //        somaPares += i;
            //    }
            //    else {
            //        contaImpares++;
            //    }

            //}
            //Console.WriteLine("Soma dos pares: " + somaPares + " Contagem dos impares: " + contaImpares);

            //int i = 1;

            //while (i <= 10) {
            //    Console.WriteLine(i);
            //    i++;
            //}

            //contar quantos valores pares o usuario digitou até ele digitar um valor negativo

            int valoresPares = 0;
            int valoresDigitadosPeloUsuario =0;

            while (true) {

                Console.Write("Digite um valor: ");
                valoresDigitadosPeloUsuario = int.Parse(Console.ReadLine());

                if (valoresDigitadosPeloUsuario < 0) {
                    //continue;//encerra a iteração atual e parte para a seguinte
                    break; // encerra o laço de repetição;
                }

                if (valoresDigitadosPeloUsuario % 2 is 0) {
                    valoresPares++;
                }
            }
            Console.WriteLine("Valores pares digitados: " + valoresPares);

            Console.ReadKey();
        }
    }
}