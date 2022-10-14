using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOito.Classes {
     class ControleRemoto {

       private Televisao televisao;
       private int contadorProxCanal = 0;
       private int indiceCanalPesquisado;
       public ControleRemoto()
       {
           televisao = new Televisao(null, 0);
       }
       
       public Televisao getTelevisao()
       {
           return televisao;
       }
       
       public int getVolume()
       {
           return televisao.getVolume();
       }
       
       public void ProximoCanal(){
           var canal = televisao.geTV();
       
          if(contadorProxCanal == televisao.geTV().Count){contadorProxCanal = 0;}
       
          Console.WriteLine($"Emissora: {canal[contadorProxCanal].getNomeCanal()} Canal: {canal[contadorProxCanal].getCanal()}");
           indiceCanalPesquisado = contadorProxCanal;
           contadorProxCanal++;
       
       
       }
       public void CanalAnterior(){
           var canal = televisao.geTV();
           contadorProxCanal--;
       
           if(contadorProxCanal < 0){
              contadorProxCanal = televisao.geTV().Count-1;
           }
            Console.WriteLine($"Emissora: {canal[contadorProxCanal].getNomeCanal()} Canal: {canal[contadorProxCanal].getCanal()}");
           
               indiceCanalPesquisado = contadorProxCanal;
       }
       public void setDiminuiVolume(){
           
           if(televisao.getVolume() > 0 && televisao.getVolume() <= 100){
            televisao.setDiminuiVolume();
            Console.WriteLine("Volume: "+getVolume());
           }
           else{
           Console.WriteLine("Tv Está no mudo");
           }
       }
       
       public void setAumentarVolume(){
       
           if(televisao.getVolume() < 100){
       
             televisao.setAumentaVolume();
             Console.WriteLine("Volume: "+getVolume());
           }else{
             Console.WriteLine("Volume Está no máximo");
           }
       }
       
       public void CanalEspecifico(){
           int canal;
           bool canalOK = true;
           do{
           
            Console.Clear();
            Console.WriteLine("Digite o canal que deseja encontrar: ");
             canalOK = int.TryParse(Console.ReadLine(), out canal);
       
           }while(canalOK is false);
       
           var canalPesquisado = televisao.geTV().FirstOrDefault((p) => p.getCanal() == canal);
           indiceCanalPesquisado = televisao.geTV().IndexOf(canalPesquisado);
       
       
          if(canalPesquisado != null)
           Console.WriteLine("Emissora: "+ canalPesquisado.getNomeCanal() +" Canal: "+ canalPesquisado.getCanal());
          else
           Console.WriteLine("Canal: "+ canal+" não encontrado");
       }
       
       public void CanalAtualEVolumeAtual(){
           var tv = televisao.geTV();
           if(indiceCanalPesquisado is not -1){
               Console.WriteLine("Emissora: "+ tv[indiceCanalPesquisado].getNomeCanal() +" "+ "Canal: "+ tv[indiceCanalPesquisado].getCanal());
               Console.WriteLine("Volume: "+ televisao.getVolume());
           }
            else
            {
                ProximoCanal();
            }
       }

    }
}
