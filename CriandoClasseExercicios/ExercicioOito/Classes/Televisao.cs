using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOito.Classes {
    internal class Televisao {

         private string nomeCanal;
        private int canal;
        private int volume;

        public Televisao(string nomeCanal, int canal) {
            this.nomeCanal = nomeCanal;
            this.canal = canal;
            this.volume = 100;
        }
        public string getNomeCanal() {
            return nomeCanal;
        }
        public int getCanal() {
            return canal;
        }

        public int getVolume() {
            return volume;
        }
        public void setDiminuirVolume() {
            volume = volume -1;
        }
        public void setAumentarVolume() {
            volume = volume + 1;
        }

    }
}
