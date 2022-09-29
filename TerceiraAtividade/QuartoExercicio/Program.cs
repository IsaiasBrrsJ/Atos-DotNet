namespace QuartoExercicio {
    internal class Program {
        static void Main(string[] args) {



            int qtdVotoJoao = 0;
            int qtdVotosZeca = 0;
            int qtdVotosBranco = 0;
            string prefeito = "";
            while (true) {

                Console.Write("Digite o nome de seu candidatos (JOAO e ZECA) ou FIM para Encerrar: ");
                prefeito = Console.ReadLine().ToUpper();

                if (((prefeito != "JOAO" && prefeito != "JOÃO") && (prefeito != "ZECA" && prefeito != "BRANCO")) && prefeito != "FIM") {

                    Console.WriteLine("Escolha entre as opçoes destacada, pressione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    continue;
                }
                else if (prefeito is "JOAO" || prefeito is "JOÃO") {
                    qtdVotoJoao++;
                }
                else if (prefeito is "ZECA") {
                    qtdVotosZeca++;
                }
                else if(prefeito is "BRANCO") {
                    qtdVotosBranco++;
                }
                else
                    if (prefeito is "FIM") {
                    break;
                }
            }

            Console.WriteLine($"Quantidade de votos João: {qtdVotoJoao}\nQuantidade de votos Zeca: {qtdVotosZeca}\n" +
                $"Quantidade de votos em branco: {qtdVotosBranco}");

            Console.ReadKey();

        }
    }
}