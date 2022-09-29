namespace QuintoExercicio {
    internal class Program {
        static void Main(string[] args) {

            /*
             5. Modifique o programa em VS anterior para aceitar votos nulos 
                (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
                Ao final, informe o nome do candidato vencedor, o número de votos nulos 
                e o número de pessoas que votaram.
             
             */


            int qtdVotoJoao = 0;
            int qtdVotosZeca = 0;
            int qtdVotosBranco = 0;
            int qtdVotosNulos = 0;
            int diferentes = 0;
            string resultado = "";
            string prefeito = "";
            while (true) {

                Console.Write("Digite o nome de seu candidatos (JOAO e ZECA) ou FIM para Encerrar: ");
                prefeito = Console.ReadLine().ToUpper();


                if (prefeito is "JOAO" || prefeito is "JOÃO") {
                    qtdVotoJoao++;
                }
                else if (prefeito is "ZECA") {
                    qtdVotosZeca++;
                }
                else if (prefeito is "BRANCO") {
                    qtdVotosBranco++;
                }
                else if (prefeito is "NULO") {

                    qtdVotosNulos++;
                }
                else if (prefeito is "FIM") {
                    break;
                }
                else {
                    diferentes++;
                }
                
            }

            if (qtdVotoJoao > qtdVotosZeca) {
                resultado += "João Ganhou";
            }
            else if (qtdVotosZeca > qtdVotoJoao) {
                resultado += "Zeca Ganhou";
            }
            else {
                resultado += "Não houve vencedores";
            }

            Console.WriteLine($"\n\nVencedor: {resultado}\n" +
                $"Quantidade de votos nulos: {qtdVotosNulos}\n" +
                $"Quantidades de pessoas que votaram: {(qtdVotoJoao + qtdVotosZeca + qtdVotosBranco + qtdVotosNulos + diferentes)}");

            Console.ReadKey();

        }
    }
}