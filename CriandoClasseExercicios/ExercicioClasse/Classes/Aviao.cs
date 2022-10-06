using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasse {
    internal class Aviao {

        public string Modelo;
        public double Velocidade;
        public double Altitude;
        public string Marca;

        public void ReduzirVelocidade() {
            Velocidade = Velocidade - 10;
            Console.WriteLine("Reduzindo Velocidade para "+Velocidade);
        }

        public void Descer() {

            Altitude = Altitude - 100;
            Console.WriteLine("Descendo para altitude " + Altitude);
        }

        public void Subir() {
            Altitude = Altitude + 100;
            Console.WriteLine("Subindo para altitude "+Altitude);
        }

        public void Acelerar() {

            Velocidade = Velocidade += 10;
            Console.WriteLine("Acelerando para " + Velocidade);
            ;
        }


    }
}
