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

            controle.getTelevisao().adcionarCanais("SBT", 13);
            controle.getTelevisao().adcionarCanais("Record", 11);
            controle.getTelevisao().adcionarCanais("Globo", 4);
            controle.getTelevisao().adcionarCanais("Band", 9);
            controle.getTelevisao().adcionarCanais("Tv Cultura", 22);

            do{
                
                Console.Clear();
                Console.Write("[1]-Aumentar Volume\n[2]-Diminuir Volume\n[3]-Próximo Canal\n[4]-Canal Anterior\n[5]-Canal Especifico\n[6]-Som e Canal\nDigite: ");
                 string opc = Console.ReadLine();

                 switch (opc)
                 {
                    case "1":
                    controle.setAumentarVolume();
                    break;
                    case "2":
                    controle.setDiminuiVolume();
                    break;
                    case "3":
                    controle.ProximoCanal();
                    break;
                    case "4":
                    controle.CanalAnterior();
                    break;
                    case "5":
                     controle.CanalEspecifico();
                    break;
                    case "6":
                    controle.CanalAtualEVolumeAtual();
                    break;
                    default:
                    Console.WriteLine("Opção Incorreta");
                    break;
                 }

                 Console.ReadKey();
            }while(true);
        }
    }
}