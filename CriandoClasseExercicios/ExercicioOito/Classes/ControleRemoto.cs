using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOito.Classes {
    internal class ControleRemoto {

        private string proxCanal;
        private string canalAnterior;
        private string canalEspecifico;
        private int diminuirVolume;
        private int aumentarVolume;
        private int i = 0;

        private List<Televisao> adcionarCanais = new List<Televisao>();
        public void AdcionarCanais(string nomeCanal, int canal) {

            adcionarCanais.Add(new(nomeCanal, canal));
            aumentarVolume = adcionarCanais[0].getVolume();
        }

        public void controle(int opc) {
            for (;  i < adcionarCanais.Count;) {

                if (opc == 1) {
                    if (adcionarCanais[i].getVolume() < 100) {

                        adcionarCanais[i].setAumentarVolume();
                        aumentarVolume = adcionarCanais[i].getVolume();
                    }
                    else
                        Console.WriteLine("Volume Maximo");

                    break;
                }
                else if (opc == 2) {
                    if (adcionarCanais[i].getVolume() > 0 && adcionarCanais[i].getVolume() <= 100) {

                        adcionarCanais[i].setDiminuirVolume();
                        diminuirVolume = adcionarCanais[i].getVolume();
                       
                    }
                    else
                        Console.WriteLine("Volume mudo");

                    break;
                }
                else if (opc == 3) {
                    i = i + 1;
                    if (i < adcionarCanais.Count)
                        proxCanal = $"Emissora: {adcionarCanais[i].getNomeCanal()}\nCanal: {adcionarCanais[i].getCanal()}";
                    else
                        i = 0;
                    break;
                }
                else if (opc == 4) {
                    i = i - 1;
                    if (i > 0)
                        canalAnterior = $"Emissora: {adcionarCanais[i].getNomeCanal()}\nCanal: {adcionarCanais[i].getCanal()}";
                    else
                        i = 4;// numero de emissoras cadastradas
                    break;

                }
                else if (opc == 6) {
                    Console.WriteLine(adcionarCanais[i].getNomeCanal() + " Volume: " + adcionarCanais[i].getVolume());
                    break;
                }
            }
        }

        public void BuscarCanalEspecifico(int canal) {
            foreach (var item in adcionarCanais) {
                if (item.getCanal() == canal) {
                    canalEspecifico = $"Emissora: {item.getNomeCanal()}\nCanal: {item.getCanal()}";
                    return;
                }
            } 
           canalEspecifico = "Canal N Encontrado";
        }

        public string getProxCanal() {
            return proxCanal;
        }
        public string getCanalAnterior() {
            return canalAnterior;
        }

        public string getCanalEspecifico() {
            return canalEspecifico;
        }
        public int getAumentarVolume() {
            return aumentarVolume;
        }
        public int getDiminuirVolume() {
            return diminuirVolume;
        }

    }
}
