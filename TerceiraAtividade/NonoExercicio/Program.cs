namespace NonoExercicio {
    internal class Program {
        static void Main(string[] args) {


            /*
             9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
                o zoológico num determinado dia, imprimindo:
                Quantas pessoas tem entre 1 e 3 filhos.
                Quantas pessoas tem entre 4 e 7 filhos.
                Quantas pessoas tem mais de 8 filhos.
                Quantas pessoas não tem filhos.
             */
            int qtdPessoasComFilhosEntreUmETres = 0;
            int qtdPessoasComFilhosEntreQuatroESete = 0;
            int qtdPessoasComMaisDeOitoFilhos = 0;
            int qtdPessoasQueNaoPossuemFilhos = 0;

            for(int i = 1; i < 30; i++) {
            
                Console.Write("{0}º Informe quantos filhos você tem: ", i);

                if(int.TryParse(Console.ReadLine(), out int filhos) is false || filhos < 0) {
                    i--;
                    Console.Clear();
                }

                if(filhos > 8) {
                    qtdPessoasComMaisDeOitoFilhos++;
                }
                else if(filhos > 4 && filhos < 7) {
                  qtdPessoasComFilhosEntreQuatroESete++;
                }
                else if(filhos > 1 && filhos < 3) {
                  qtdPessoasComFilhosEntreUmETres++;
                }
                else {
                    qtdPessoasQueNaoPossuemFilhos++;
                }
            }

            Console.WriteLine($"\nQuantas pessoas tem entre 1 e 3 filhos: {qtdPessoasComFilhosEntreUmETres}\nQuantas pessoas tem entre 4 e 7 filhos: {qtdPessoasComFilhosEntreQuatroESete}\nQuantas pessoas tem mais de 8 filhos: {qtdPessoasComMaisDeOitoFilhos}\nQuantas pessoas não tem filhos: {qtdPessoasQueNaoPossuemFilhos}");

            Console.ReadKey();

        }
    }
}