using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp00 {
    internal class Carro {

        private double velocidadeMax;
        private string modelo;
        private string cor;
        private string placa { get;  set; }
        private string fabricante;
        private bool ligado;

        public double getVelocidadeMax() {

            return velocidadeMax;
        }
        public void setVelocidadeMax(double velocidadeMax) {
            this.velocidadeMax = velocidadeMax;
        }

        public string getModelo() {

            return modelo;
        }
        public void setModelo(string modelo) {
            this.modelo = modelo;
        }


        public string getPlaca() {
            return placa;
        }
        public void setPlaca(string placa) {
            this.placa = placa;
        }

        public string getFabricante() {
            return fabricante;
        }
        public void setFabricante(string fabricante) {
            this.fabricante = fabricante;
        }

        #region getCor
        public string getCor() {
            // vai retornar o que contém na variavel cor

            return cor;
        }

        public void setCor(string cor) {
            // vai atribuir uma cor pra variavel "cor", não podendo alterar diretamente a variavel original

            this.cor = cor;
        }

        #endregion

        #region getLigado
        public bool getLigado() { // todo getter deve ser publico e vai retornar algo
            return ligado;
        }
        public void ligar() {

            ligado = true;
            Console.WriteLine("O carro foi ligado!");
        }

        public void desligar() {
            ligado = false;
            Console.WriteLine("O carro foi desligado!");
        }

        #endregion

        #region coment
        // getter e setter 

        // toda clase tem um construto explicito ou implicito;
        //public Carro(string modelo) { //

        //    this.modelo = modelo;
        //}

        //public Carro(double velocidadeMax, string modelo, string cor, string placa, string fabricante, bool ligado) {
        //    this.velocidadeMax = velocidadeMax;
        //    this.modelo = modelo;
        //    this.cor = cor;
        //    this.placa = placa;
        //    this.fabricante = fabricante;
        //    this.ligado = ligado;
        //}

        //public Carro() {

        //}
        //sobrecarga metodos com mesmo nome, se difereem entre quantidade e tipos de parametros

        // t
        #endregion[


    }
}
