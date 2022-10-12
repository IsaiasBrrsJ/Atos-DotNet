using ExercicioOito.Classes;

namespace ExercicioOito {
    internal class Program {
        static void Main(string[] args) {


            /*
             8 - Crie uma classe Televisao e uma classe ControleRemoto que pode controlar o volume e trocar 
                 os canais da televisão. O controle de volume permite:
                - aumentar ou diminuir a potência do volume de som em uma unidade de cada vez;
                - aumentar e diminuir o número do canal em uma unidade
                - trocar para um canal indicado;
                - consultar o valor do volume de som e o canal selecionado.
             
             */
           ControleRemoto controle = new ControleRemoto();
            controle.AdcionarCanais("Rede Record", 11);
            controle.AdcionarCanais("Rede Globo", 4);
            controle.AdcionarCanais("Rede Tv", 17);
            controle.AdcionarCanais("Band", 9);
            controle.AdcionarCanais("SBT", 13);
            
            do {
                Console.Clear();
                Console.Write("\n\t[1]-Aumentar Volume\n\t[2]-Diminuir Volume\n\t[3]-Proximo Canan\n\t[4]-Canal Anterior" +
                    "\n\t[5]-Canal Especifico\n\t[6]-Consultar Volume e Canal Selecionado\n\t[0]-Sair\n\tOpcao: ");

                string opc = Console.ReadLine();

                switch (opc) {
                    case "0":
                        Environment.Exit(0);
                    break;
                    case "1":
                        controle.controle(1);
                        Console.WriteLine("Volume: "+controle.getAumentarVolume());
                        break;

                    case "2":
                        controle.controle(2);
                        Console.WriteLine("Volume: " + controle.getDiminuirVolume());
                        break;

                    case "3":
                        controle.controle(opc: 3);
                        Console.WriteLine(controle.getProxCanal());
                        break;

                    case "4":
                        controle.controle(opc: 4);
                        Console.WriteLine(controle.getCanalAnterior());
                        break;

                    case "5":
                        controle.BuscarCanalEspecifico(11);
                        Console.WriteLine(controle.getCanalEspecifico());
                        break;

                    case "6":
                        controle.controle(6);
                        break;

                    default:
                        break;
                }

                Console.ReadKey();
            } while (true);
        }
    }
}