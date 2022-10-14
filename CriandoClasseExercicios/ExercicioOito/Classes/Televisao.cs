using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOito.Classes {
     class Televisao {

        private string nomeCanal;
        private int canal;
        private int volume = 100;

        private List<Televisao> tv = new List<Televisao>();
       
        public Televisao(string nomeCanal, int canal)
        {
            this.nomeCanal = nomeCanal;
            this.canal = canal;
        }
        
        public int getVolume()
        {
            return volume;
        }
        public void setAumentaVolume(){
            volume++;
        }
        public void setDiminuiVolume(){
            volume--;
        }

        public void adcionarCanais(string nomeCanal, int canal)
        {
            tv.Add(new(nomeCanal, canal));
        }
        public string getNomeCanal(){
            return nomeCanal;
        }
        public int getCanal(){
            return canal;
        }
        public List<Televisao> geTV(){
            return tv;
        }

    }
}
