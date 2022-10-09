using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_veiculos.Classes {
    internal class Carro {
        
        private int ID;
        private string modelo;
        private string anoModelo;
        private string nomeModelo;
        private string placa;
        public Carro(string modelo, string anoModelo, string nomeModelo, string placa) {

            this.ID = GeraId();
            this.modelo = modelo;
            this.anoModelo = anoModelo;
            this.nomeModelo = nomeModelo;
            this.placa = placa;
        }

        private int GeraId() {
            return new Random().Next(0, 1000);
        }

        public int getId() {
            return ID;
        }

        public string getPlaca() {
            return placa;
        }

        public string getModelo() {
            return modelo;
        }
        public string getNomeModelo() {
            return nomeModelo;
        }

    }
}
