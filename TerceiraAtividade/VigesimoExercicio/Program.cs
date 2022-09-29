namespace VigesimoExercicio {
    internal class Program {
        static void Main(string[] args) {
            /*
             
             20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
                certa região, a qual coletou os seguintes dados referentes a cada habitante para 
                serem analisados:
                - sexo (masculino e feminino)
                - cor dos olhos (azuis, verdes ou castanhos)
                - cor dos cabelos ( loiros, castanhos, pretos)
                - idade 
 
                Faça um algoritmo que determine e escreva: 
 
                - a maior idade dos habitantes
                - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
                e que tenham olhos verdes e cabelos loiros.
                O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
             */

            string sexo = "";
            string corDosOlhos = "";
            string corDosCabelos = "";
            int maiorIdade = 0;
            int qtdIndividuosSexoFeminino = 0;
            int idade = 0;
            while (true) {
                Console.WriteLine("-1 Para encerrar\n ");
                do {
                    Console.Write("Informe sua idade: ");
                     idade = int.Parse(Console.ReadLine());  
                }while(idade < -1);

                if(idade == -1) {
                 break;
                }

                 do {

                    Console.WriteLine("Informe seu sexo (M)masculino (F)feminino");
                       sexo = Console.ReadLine().ToUpper();

                  }while(sexo != "F" && sexo != "M");

                do {
                    Console.Write("Informe a cor dos olhos ((azuis, verdes ou castanhos)): ");
                     corDosOlhos = Console.ReadLine().ToUpper();
                }while(corDosOlhos != "AZUIS" && corDosOlhos != "VERDES" && corDosOlhos != "CASTANHOS");

                do {
                    Console.Write("Informe cor dos cabelos ( loiros, castanhos, pretos): ");
                     corDosCabelos = Console.ReadLine().ToUpper();

                }while(corDosCabelos != "LOIROS" && corDosCabelos != "CASTANHOS" && corDosCabelos != "PRETOS");

                if(idade > maiorIdade) {
                    maiorIdade = idade;
                }

                if(sexo is "F" && ((idade > 18 && idade < 35) && (corDosCabelos is "LOIROS" && corDosOlhos is "VERDES"))  ){
                  qtdIndividuosSexoFeminino++;
                }
             }

            Console.WriteLine("\nindivíduos do sexo feminino que está entre 18 e 35 anos e que tem olhos verdes e cabelos loiros: "+ qtdIndividuosSexoFeminino);
            Console.WriteLine("Maior idade lida: "+ maiorIdade);

            Console.ReadKey();
        }
    }
}