namespace LacoFor {
    internal class Program {
        static void Main(string[] args) {


            //int i = 0; varivel que vai armazenar 
            // i < 10 condicao
            // i++ vai incrementar valores em i;


            //for (int i = 1; i <= 10; i++) {

            //    Console.WriteLine(i);
            //}

            //contar quantos valores tem, entre 55 e 127

            //int count = 0;
            //for (int i = 56; i < 127; i++) {
            //    count++;
            //}
            //Console.WriteLine(count);

            // some os valores entre 55 e 127
            //int soma = 0;
            //for (int i = 56; i < 127; i++) {
            //    soma+= i;
            //}
            //Console.WriteLine(soma);


            //Contar quantos pares existem entre 55 e 127;

            //int contarPares = 0;     
            //for (int i = 56; i < 127; i++) {

            //    if (i % 2 is 0) {
            //        contarPares++;
            //    }

            //}

            //Console.WriteLine("Pares entre 55 e 127: D"+ contarPares);

            //contar impares e somar os pares existentes entre 55 e 127:

            //int somaPares = 0;
            //int contaImpares = 0;

            //for (int i = 56; i < 127; i++) {

            //    if (i % 2 != 0) {
            //        contaImpares++;
            //    }
            //    else {
            //        somaPares += i;
            //    }
            //}

            //Console.WriteLine("Soma dos pares: " + somaPares + " Contagem dos impares: " + contaImpares);


            // Contar os impares e somar os pares existentes no intervalo informado pelo usuario;

            int inicio =0, final = 0;
            int somaPares = 0, contaImpares = 0;

            Console.Write("Informe o incicio da contagem: ");
            inicio = int.Parse(Console.ReadLine());

            while (inicio >= final) {

                Console.Write("Informe o final da contagem: ");
                final = int.Parse(Console.ReadLine());
            }

            for (int i = (inicio + 1); i < final; i++) {

                if (i % 2 == 0) {
                    somaPares += i;
                }
                else {
                    contaImpares++;
                }
            
            }

          
            Console.WriteLine("Soma dos pares: " + somaPares + " Contagem dos impares: " + contaImpares);

            Console.ReadKey();

        }
    }
}