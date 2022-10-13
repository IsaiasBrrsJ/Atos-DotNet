using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoOO
{
    internal class Televisao : IEletronico
    {
        private int _volts;
        private int _potencia;
        private bool _ligado;

        public bool Ligado
        {
            get => _ligado;
            set => _ligado = value;
        }
        public  void Ligar()
        {
            _ligado = true;
            Console.WriteLine("Iniciando o equipamento");
        }

        public void Desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando o equipamento");
        }
    }
}
