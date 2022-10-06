using System;

namespace AppOO {
    internal class Lampada {

        // atributos da lampada
        private bool ligada;
        private double potencia;
        //public int teste;
        //
  
        //metodos
        public void ligar() {
            ligada = true;
            Console.WriteLine("Ligando lâmpada!");
         }
         public void desligar() {
            ligada = false;
            Console.WriteLine("Desligando lâmpada!");
         }
         public bool estaLigada() {
            return ligada;
         }
        //


    }
}
